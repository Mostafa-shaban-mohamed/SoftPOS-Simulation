using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.SoftPOS.ISOMsgs;
using BIM_ISO8583.NET;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Text;

namespace App.SoftPOS
{
    public class MsgAppService : CrudAppService<ISOMsg, ISOMsgDto, Guid, PagedAndSortedResultRequestDto>, ImsgAppService
    {
        public MsgAppService(IRepository<ISOMsg, Guid> repository) : base(repository)
        {
            // GetPolicyName = SourceCodePermissions.Types.Default;
            // GetListPolicyName = SourceCodePermissions.Types.Default;
            // CreatePolicyName = SourceCodePermissions.Types.Create;
            // UpdatePolicyName = SourceCodePermissions.Types.Update;
            // DeletePolicyName = SourceCodePermissions.Types.Delete;
        }

        public async Task<string> GetResponse()
        {
            string path = @"D:\SoftPos\Documents\test.txt";
            var buffer = "";
            string readText = await File.ReadAllTextAsync(path);
            buffer += readText;
            return buffer;
        }

        public async Task<string[]> GetISOMsgHex(string msg)
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

        public string GetArabicString (string hexString)
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

        public string[] GetBitmapValues(string bitmap)
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

        public string GetConvertHex(string hexString)
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

        public static string ConvertHex(string hexString)
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

        public async Task<string> GetDE72(string hexString)
        {
            string ascii = string.Empty;
            try
            {
                for(int i = 0; i < hexString.Length-2; i+=2)
                {
                    ascii += HexToUnicode(hexString.Substring(i,2));
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
            return ascii;
        }

        public static char HexToUnicode(string hex)
        {
            byte[] bytes = HexToBytes(hex);
            Encoding enc = Encoding.GetEncoding("UTF-8");
            var decodedItem = enc.GetString(bytes).ToCharArray();
            char c = decodedItem[0];
            if (bytes.Length == 1)
            {
                c = (char)bytes[0];
            }
            else if (bytes.Length == 2)
            {
                c = (char)((bytes[0] << 8) + bytes[1]);
            }
            else
            {
                throw new Exception(hex);
            }

            return c;
        }
        
        public static byte[] HexToBytes(string hex)
        {
            hex = hex.Trim();

            byte[] bytes = new byte[hex.Length / 2];

            for (int index = 0; index < bytes.Length; index++)
            {
                bytes[index] = Convert.ToByte(hex.Substring(index * 2, 2), 16);
            }

            return bytes;
        }
    }
}