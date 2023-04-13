using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.ISOMsgs;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Polly.Caching;
using App.SoftPOS.MTIs;
using App.SoftPOS.RetailerDatas;
using App.SoftPOS.CardSchemas;
using App.SoftPOS.MessageTexts;
using App.SoftPOS.PublicKeys;
using App.SoftPOS.TerminalConnections;
using App.SoftPOS.DeviceSpecifics;
using App.SoftPOS.AIDLists;
using App.SoftPOS.AIDDatas;
using App.SoftPOS.RevokeCertificates;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace App.SoftPOS
{
    public class MsgAppService : CrudAppService<ISOMsg, ISOMsgDto, Guid, PagedAndSortedResultRequestDto>, ImsgAppService
    {
        public MsgAppService(IRepository<ISOMsg, Guid> repository) 
            : base(repository)
        {
            // GetPolicyName = SourceCodePermissions.Types.Default;
            // GetListPolicyName = SourceCodePermissions.Types.Default;
            // CreatePolicyName = SourceCodePermissions.Types.Create;
            // UpdatePolicyName = SourceCodePermissions.Types.Update;
            // DeletePolicyName = SourceCodePermissions.Types.Delete;
        }

        //Read Text File containing message (API)
        //public async Task<string> GetResponse(string filename)
        //{
        //    //temporary hardcoded for now
        //    if (filename == "3064444")
        //    {
        //        return null;
        //    }
        //    int resp = int.Parse(filename) + 100;
        //    string filesentName = resp.ToString() + ".txt";
        //    string path = @"D:\Projects\SoftPOS\SourceCode\aspnet-core\src\App.SoftPOS.HttpApi.Host\DownloadParameters\" + filesentName;
        //    var buffer = "";
        //    string readText = await File.ReadAllTextAsync(path);
        //    buffer += readText;
        //    return buffer;
        //}

        //request download parameters
        public string? PostMobileRequest(MobileRequest json)
        {
            //get required response form file-system storing data
            var msg = Response(json.Last_Message_Number);
            //is msg valid
            if (!string.IsNullOrEmpty(msg))
            {
                var DE = ISOMsgHex(msg, mti: out string mti);
                ISO8583Packet packet = new();
                var message = packet.ISOMobileMessage(DE, mti: mti);
                var options = new JsonSerializerOptions 
                { 
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic)
                };
                string jsonString = JsonSerializer.Serialize(message, options);

                return jsonString;
            }
            return null;
        }
        
        //get JSON message for mobile app (API)
        public string PostMessage([FromBody] string msg)
        {
            var DE = ISOMsgHex(msg, mti: out string mti);
            //get Message object returned with values
            ISO8583Packet packet = new ISO8583Packet();
            var message = packet.ISOMobileMessage(DE, mti: mti);
            //remove all properties with value = null
            var options = new JsonSerializerOptions { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            string jsonString = JsonSerializer.Serialize(message, options);

            return jsonString; 
        }

        //get DE array of message (API)
        public string[] GetISOMsgHex(string msg)
        {
            //get bitmap (primary & secondary)
            //mti, header                        
            string MsgHeaderHex = msg.Substring(0, 14); string mtiHex = msg.Substring(14, 8);
            msg = msg.RemovePreFix(MsgHeaderHex);
            msg = msg.RemovePreFix(mtiHex);
            //init ISO8583 Packet
            var packet = new ISO8583Packet();
            //get DE values
            packet.DE = GetBitmapValues(msg.Substring(0, 64));
            
            for (int i = 0; i < packet.DE.Length; i++)
            {
                if (packet.DE[i] == "Value")
                    msg = packet.Data_Element_Type(packet.Data_Elements[i + 1], msg, out packet.DE[i]);
            }
            return packet.DE;
        }
        
        //test method to check hex to arabic (API)
        public static string GetArabicString (string hexString)
        {
            if (hexString == null)
                throw new ArgumentNullException("hexString");
            if (hexString.Length % 2 != 0)
                throw new ArgumentException("hexString must have an even length", "hexString");
            var bytes = new byte[hexString.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                string currentHex = hexString.Substring(i * 2, 2);
                bytes[i] = Convert.ToByte(currentHex, 16);
            }
              
            return Encoding.GetEncoding("ISO-8859-6").GetString(bytes);
        }
        //test method to check the bitmap of message (API)
        public static string[] GetBitmapValues(string bitmap)
        {
            bitmap = ConvertHex(bitmap);
            //convert hex string to binary string
            string binarystring = String.Join(String.Empty,
                bitmap.Select(
                    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                )
            );
            //get positions of 1s and store it in DE string
            string[] DE = new string[128]; //store DE values
            //string DE = "";
            for(int i = 0; i < binarystring.Length; i++)
            {
                if (binarystring[i] == '1')
                {
                    DE[i] = $"Value";
                    //DE += $"{(i + 1).ToString()} ";
                }
            }
            return DE;
        }
        //get convert from Hex to Ascii (API)
        public static string GetConvertHex(string hexString)
        {
            try
            {
                string ascii = string.Empty;
                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;
                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;
                }
                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return string.Empty;
        }

        //internal methods --------------------------

        //Read Text File containing message (API) ## depends on file-system storing records
        private static string? Response(string filename)
        {
            filename = filename.RemovePreFix("306");
            //fetch current record number
            var certainRecordNumber = filename.Substring(0, filename.Length / 2);
            // total number of records
            var totalRecords = "";
            if (filename == "0000") //temprarily hardcoded
            {
                totalRecords = "44"; 
            }
            else
            {
                totalRecords = filename.RemovePreFix(certainRecordNumber);
            }
            //check if this is the last record
            if (certainRecordNumber == totalRecords) 
            {
                return null;
            }
            int resp = int.Parse(certainRecordNumber) + 1;
            string filesentName = "306" + resp.ToString("D" + totalRecords.Length.ToString()) + totalRecords + ".txt";
            //relative Path to Download Parameters files
            var relativePath = Directory.GetCurrentDirectory() + "\\DownloadParameters\\" + filesentName; 
            //fetch data from file
            string readText = File.ReadAllText(relativePath);
            //is text valid
            if (string.IsNullOrEmpty(readText))
                return null;

            return readText;
        }

        //internal method for DE array of message to be used in Mobile app
        private static string[] ISOMsgHex(string msg, out string mti)
        {
            //get bitmap (primary & secondary)
            //mti, header                        
            string MsgHeaderHex = msg.Substring(0, 14); string mtiHex = msg.Substring(14, 8);
            mti = ConvertHex(mtiHex);
            msg = msg.RemovePreFix(MsgHeaderHex);
            msg = msg.RemovePreFix(mtiHex);
            //init ISO8583 Packet
            var packet = new ISO8583Packet();
            //get DE values
            packet.DE = GetBitmapValues(msg.Substring(0, 64));
            //replace value string with actual value of this field
            for (int i = 0; i < packet.DE.Length; i++)
            {
                if (packet.DE[i] == "Value")
                    msg = packet.Data_Element_Type(packet.Data_Elements[i + 1], msg, out packet.DE[i]);
            }
            return packet.DE;
        }

        //convert from hex to ascii
        private static string ConvertHex(string hexString)
        {
            try
            {
                string ascii = string.Empty;
                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;
                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;
                }
                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return string.Empty;
        }

        //public async Task<string> GetDE72(string hexString)
        //{
        //    string ascii = string.Empty;
        //    try
        //    {
        //        for(int i = 0; i < hexString.Length-2; i+=2)
        //        {
        //            ascii += HexToUnicode(hexString.Substring(i,2));
        //        }
        //    }
        //    catch (Exception ex) 
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
            
        //    return ascii;
        //}

        //public static char HexToUnicode(string hex)
        //{
        //    byte[] bytes = HexToBytes(hex);
        //    Encoding enc = Encoding.GetEncoding("UTF-8");
        //    var decodedItem = enc.GetString(bytes).ToCharArray();
        //    char c = decodedItem[0];
        //    if (bytes.Length == 1)
        //    {
        //        c = (char)bytes[0];
        //    }
        //    else if (bytes.Length == 2)
        //    {
        //        c = (char)((bytes[0] << 8) + bytes[1]);
        //    }
        //    else
        //    {
        //        throw new Exception(hex);
        //    }

        //    return c;
        //}
        
        //public static byte[] HexToBytes(string hex)
        //{
        //    hex = hex.Trim();

        //    byte[] bytes = new byte[hex.Length / 2];

        //    for (int index = 0; index < bytes.Length; index++)
        //    {
        //        bytes[index] = Convert.ToByte(hex.Substring(index * 2, 2), 16);
        //    }

        //    return bytes;
        //}
    }
}