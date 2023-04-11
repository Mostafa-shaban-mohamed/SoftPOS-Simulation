using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace App.SoftPOS
{
    public class MobileRequest
    {
        //mti code
        public string Mti_Code { get; set; }
        //DE 1
        public string Bitmap { get; set; }
        //DE 7
        public string Transmission_Date { get; set; }
        //DE 11
        public string System_Trace_Audit_Number { get; set; }
        //DE 12
        public string Local_Transaction_Time { get; set; }
        //DE 24
        public string Function_Code { get; set; }
        //DE 32
        public string Acquiring_Instition_Identification_Code { get; set; }
        //DE 41
        public string Card_Acceptor_Terminal_Identifion { get; set; }
        //DE 42
        public string Card_Acceptor_Terminal_Code { get; set; }
        //DE 53
        public string Security_Related_Control_Information { get; set; }
        //DE 62
        public string Reserved_Private02 { get; set; }
        //DE 72
        public string Last_Message_Number { get; set; }
        //DE 128
        public string MAC02 { get; set; }
    }


    public class Message
    {
        //mti code
        public string Mti_Code { get; set; }
        //DE 1
        public string Bitmap { get; set; }
        //DE 2
        public string PAN { get; set; } //Primary Account Number
        //DE 3
        public string Processing_Code { get; set; }
        //DE 4
        public string Amount_Transaction { get; set; }
        //DE 5
        public string Amount_Settlement { get; set; }
        //DE 6
        public string Amount_CardHolder_billing { get; set; }
        //DE 7
        public string Transmission_Date { get; set; }
        //DE 8
        public string Amount_CardHolder_Billing_fee { get; set; }
        //DE 9
        public string Conversion_Rate_Settlement { get; set; }
        //DE 10
        public string Conversion_Rate_CardHolder_Billing { get; set; }
        //DE 11
        public string System_Trace_Audit_Number { get; set; }
        //DE 12
        public string Local_Transaction_Time { get; set; }
        //DE 13
        public string Local_Transaction_Date { get; set; }
        //DE 14
        public string Expiration_Date { get; set; } //expiration Date
        //DE 15
        public string Settlement_Date { get; set; }
        //DE 16
        public string Currency_Conversion_Date { get; set; }
        //DE 17
        public string Capture_Date { get; set; }
        //DE 18
        public string Merchant_Category_Code { get; set; }
        //DE 19
        public string Acquiring_Instition { get; set; } //Acquring Instition (Country Code)
        //DE 20
        public string PAN_Extended_Country_Code { get; set; } //PAN With Country Code
        //DE 21
        public string Forwarding_Instition { get; set; }
        //DE 22
        public string POS_Entry_Mode { get; set; }
        //DE 23
        public string App_PAN_Sequence_Number { get; set; }
        //DE 24
        public string Function_Code { get; set; } //Network International Indentifier or Function Code
        //DE 25
        public string POS_Condition_Code { get; set; }
        //DE 26
        public string POS_Capture_Code { get; set; }
        //DE 27
        public string Auth_Identification_Response_Length { get; set; }
        //DE 28
        public string Amount_Transaction_Fee { get; set; }
        //DE 29
        public string Amount_Settlement_Fee { get; set; }
        //DE 30
        public string Amount_Transaction_Processing_Fee { get; set; }
        //DE 31
        public string Amount_Settlement_Processing_Fee { get; set; }
        //DE 32
        public string Acquiring_Instition_Identification_Code { get; set; }
        //DE 33
        public string Forwarding_Instition_Identification_Code { get; set; }
        //DE 34
        public string PAN_Extended { get; set; }
        //DE 35
        public string Track02_Data { get; set; }
        //DE 36
        public string Track03_Data { get; set; }
        //DE 37
        public string Retrieval_Reference_Number { get; set; }
        //DE 38
        public string Auth_Identification_Response { get; set; }
        //DE 39
        public string Response_Code { get; set; }
        //DE 40
        public string Service_Restriction_Code { get; set; }
        //DE 41
        public string Card_Acceptor_Terminal_Identifion { get; set; }
        //DE 42
        public string Card_Acceptor_Terminal_Code { get; set; }
        //DE 43
        public string Card_Acceptor_Name_Location { get; set; } //1-23 street address, -36 City, -38 State, 39-40 Country
        //DE 44
        public string Addititonal_Response_Data { get; set; }
        //DE 45
        public string Track01_Data { get; set; }
        //DE 46
        public string Additional_Data_ISO { get; set; }
        //DE 47
        public string Additional_Data_National { get; set; }
        //DE 48
        public string Additional_Data_Private { get; set; }
        //DE 49
        public string CC_Transaction { get; set; } //Currency Code Transaction
        //DE 50
        public string CC_Settlement { get; set; } //Currency Code Settlement
        //DE 51
        public string CC_Cardholder_Billing { get; set; } //Currency Code CardHolder Billing
        //DE 52
        public string Personal_Identification_Number_Data { get; set; }
        //DE 53
        public string Security_Related_Control_Information { get; set; }
        //DE 54
        public string Additional_Amounts { get; set; }
        //DE 55
        public string ICC_Data { get; set; }
        //DE 56
        public string Reserved_ISO { get; set; }
        //DE 57
        public string Reserved_National01 { get; set; }
        //DE 58
        public string Reserved_National02 { get; set; }
        //DE 59
        public string Reserved_National03 { get; set; }
        //DE 60
        public string Reserved_National04 { get; set; }
        //DE 61
        public string Reserved_Private01 { get; set; }
        //DE 62
        public string Reserved_Private02 { get; set; }
        //DE 63
        public string Reserved_Private03 { get; set; }
        //DE 64
        public string MAC01 { get; set; } //Message Authentication Code
        //DE 65
        public string Extended_Bitmap_Indicator { get; set; }
        //DE 66
        public string Settlement_Code { get; set; }
        //DE 67
        public string Extended_Payment_Code { get; set; }
        //DE 68
        public string Recieving_Institution_Country_Code { get; set; }
        //DE 69
        public string Settlement_Institution_Country_Code { get; set; }
        //DE 70
        public string Network_Management_Info_Code { get; set; }
        //DE 71
        public string Message_Number { get; set; }
        //DE 72
        public string Last_Message_Number { get; set; }
        //DE 73
        public string Action_Date { get; set; } //(YYMMDD)
                                                //DE 74
        public string Number_of_Credits { get; set; }
        //DE 75
        public string Credits { get; set; } //Credits Reversal Number
                                            //DE 76
        public string Number_of_Debits { get; set; }
        //DE 77
        public string Debits { get; set; } //Debits Reversal Number
                                           //DE 78
        public string Number_of_Transfers { get; set; }
        //DE 79
        public string Transfers { get; set; } //Transfer Reversal Number
                                              //DE 80
        public string Number_of_Inquiries { get; set; }
        //DE 81
        public string Number_of_Auth { get; set; }
        //DE 82
        public string Credits_Processing_Fee_Amount { get; set; }
        //DE 83
        public string Credits_Transaction_Fee_Amount { get; set; }
        //DE 84
        public string Debits_Processing_Fee_Amount { get; set; }
        //DE 85
        public string Debits_Transaction_Fee_Amount { get; set; }
        //DE 86
        public string Total_Amount_Credits { get; set; }
        //DE 87
        public string Credits_Reversal_Amount { get; set; }
        //DE 88
        public string Total_Amount_Debits02 { get; set; }
        //DE 89
        public string Debits_Reversal_Amount { get; set; }
        //DE 90
        public string Original_Data_Elements { get; set; }
        //DE 91
        public string File_Update_Code { get; set; }
        //DE 92
        public string File_Security_Code { get; set; }
        //DE 93
        public string Response_Indicator { get; set; }
        //DE 94
        public string Service_Indicator { get; set; }
        //DE 95
        public string Replacement_Amounts { get; set; }
        //DE 96
        public string Message_Security_Code { get; set; }
        //DE 97
        public string Net_Settlement_Amount { get; set; }
        //DE 98
        public string Payee { get; set; }
        //DE 99
        public string Settlement_Instition_Identification_Code { get; set; }
        //DE 100
        public string Receving_Instition_Identification_Code { get; set; }
        //DE 101
        public string File_Name { get; set; }
        //DE 102
        public string Account_Identification01 { get; set; }
        //DE 103
        public string Account_Identification02 { get; set; }
        //DE 104
        public string Transaction_Description { get; set; }
        //DE(105-111)
        public string Reversed_ISO_Use01 { get; set; }
        public string Reversed_ISO_Use02 { get; set; }
        public string Reversed_ISO_Use03 { get; set; }
        public string Reversed_ISO_Use04 { get; set; }
        public string Reversed_ISO_Use05 { get; set; }
        public string Reversed_ISO_Use06 { get; set; }
        public string Reversed_ISO_Use07 { get; set; }
        //DE(112-119)
        public string Reversed_National_Use01 { get; set; }
        public string Reversed_National_Use02 { get; set; }
        public string Reversed_National_Use03 { get; set; }
        public string Reversed_National_Use04 { get; set; }
        public string Reversed_National_Use05 { get; set; }
        public string Reversed_National_Use06 { get; set; }
        public string Reversed_National_Use07 { get; set; }
        public string Reversed_National_Use08 { get; set; }
        //DE(120-127)
        public string Reversed_Private_Use01 { get; set; }
        public string Reversed_Private_Use02 { get; set; }
        public string Reversed_Private_Use03 { get; set; }
        public string Reversed_Private_Use04 { get; set; }
        public string Reversed_Private_Use05 { get; set; }
        public string Reversed_Private_Use06 { get; set; }
        public string Reversed_Private_Use07 { get; set; }
        public string Reversed_Private_Use08 { get; set; }
        //DE 128
        public string MAC02 { get; set; } //Message Authentication Code
    }

    //handles ISO message packets
    public class ISO8583Packet
    {
        //store in DE Array
        public string[] DE { get; set; } = new string[128];
        //HS
        public Dictionary<int, string> Data_Elements = new Dictionary<int, string>();

        public ISO8583Packet()
        {
            Data_Elements.Add(1, "an 32");
            Data_Elements.Add(2, "n .. 19");
            Data_Elements.Add(3, "n 6");
            Data_Elements.Add(4, "n 12");
            Data_Elements.Add(5, "n 12");
            Data_Elements.Add(6, "n 12");
            Data_Elements.Add(7, "n 10");
            Data_Elements.Add(8, "n 8");
            Data_Elements.Add(9, "n 8");
            Data_Elements.Add(10, "n 8");
            Data_Elements.Add(11, "n 6");
            Data_Elements.Add(12, "n 12");
            Data_Elements.Add(13, "n 4");
            Data_Elements.Add(14, "n 4");
            Data_Elements.Add(15, "n 4");
            Data_Elements.Add(16, "n 4");
            Data_Elements.Add(17, "n 4");
            Data_Elements.Add(18, "n 4");
            Data_Elements.Add(19, "n 3");
            Data_Elements.Add(20, "n 3");
            Data_Elements.Add(21, "n 3");
            Data_Elements.Add(22, "an 12");
            Data_Elements.Add(23, "n 3");
            Data_Elements.Add(24, "n 3");
            Data_Elements.Add(25, "n 4");
            Data_Elements.Add(26, "n 4");
            Data_Elements.Add(27, "n 1");
            Data_Elements.Add(28, "n 6");
            Data_Elements.Add(29, "x n 8");
            Data_Elements.Add(30, "n 12");
            Data_Elements.Add(31, "x n 8");
            Data_Elements.Add(32, "n .. 11");
            Data_Elements.Add(33, "n .. 11");
            Data_Elements.Add(34, "ns .. 28");
            Data_Elements.Add(35, "z .. 37");
            Data_Elements.Add(36, "n .. 104");
            Data_Elements.Add(37, "anp 12");
            Data_Elements.Add(38, "anp 6");
            Data_Elements.Add(39, "n 3");
            Data_Elements.Add(40, "an 3");
            Data_Elements.Add(41, "ans 16");
            Data_Elements.Add(42, "ans 15");
            Data_Elements.Add(43, "ans .. 99");
            Data_Elements.Add(44, "ans .. 99");
            Data_Elements.Add(45, "an .. 76");
            Data_Elements.Add(46, "an ... 999");
            Data_Elements.Add(47, "ans ... 999");
            Data_Elements.Add(48, "ans ... 999");
            Data_Elements.Add(49, "n 3");
            Data_Elements.Add(50, "n 3");
            Data_Elements.Add(51, "aorn 3");
            Data_Elements.Add(52, "b 8");
            Data_Elements.Add(53, "b .. 48");
            Data_Elements.Add(54, "ans ... 120");
            Data_Elements.Add(55, "b .. 255");
            Data_Elements.Add(56, "anp .. 58");
            Data_Elements.Add(57, "ans ... 999");
            Data_Elements.Add(58, "ans ... 999");
            Data_Elements.Add(59, "ans ... 999");
            Data_Elements.Add(60, "ans ... 999");
            Data_Elements.Add(61, "ans ... 999");
            Data_Elements.Add(62, "ans ... 999");
            Data_Elements.Add(63, "ans ... 999");
            Data_Elements.Add(64, "b 8");
            Data_Elements.Add(65, "b 1");
            Data_Elements.Add(66, "n 1");
            Data_Elements.Add(67, "n 2");
            Data_Elements.Add(68, "n 3");
            Data_Elements.Add(69, "n 3");
            Data_Elements.Add(70, "n 3");
            Data_Elements.Add(71, "n 4");
            Data_Elements.Add(72, "ans ... 999");
            Data_Elements.Add(73, "n 6");
            Data_Elements.Add(74, "n 10");
            Data_Elements.Add(75, "n 10");
            Data_Elements.Add(76, "n 10");
            Data_Elements.Add(77, "n 10");
            Data_Elements.Add(78, "n 10");
            Data_Elements.Add(79, "n 10");
            Data_Elements.Add(80, "n 10");
            Data_Elements.Add(81, "n 10");
            Data_Elements.Add(82, "n 12");
            Data_Elements.Add(83, "n 12");
            Data_Elements.Add(84, "n 12");
            Data_Elements.Add(85, "n 12");
            Data_Elements.Add(86, "n 16");
            Data_Elements.Add(87, "n 16");
            Data_Elements.Add(88, "n 16");
            Data_Elements.Add(89, "n 16");
            Data_Elements.Add(90, "n 42");
            Data_Elements.Add(91, "an 1");
            Data_Elements.Add(92, "an 2");
            Data_Elements.Add(93, "an 5");
            Data_Elements.Add(94, "an 7");
            Data_Elements.Add(95, "an 42");
            Data_Elements.Add(96, "b 64");
            Data_Elements.Add(97, "x n 16");
            Data_Elements.Add(98, "ans 25");
            Data_Elements.Add(99, "n .. 11");
            Data_Elements.Add(100, "n .. 11");
            Data_Elements.Add(101, "ans .. 17");
            Data_Elements.Add(102, "ans .. 28");
            Data_Elements.Add(103, "ans .. 28");
            Data_Elements.Add(104, "ans ... 100");
            Data_Elements.Add(105, "ans ... 999");
            Data_Elements.Add(106, "ans ... 999");
            Data_Elements.Add(107, "ans ... 999");
            Data_Elements.Add(108, "ans ... 999");
            Data_Elements.Add(109, "ans ... 999");
            Data_Elements.Add(110, "ans ... 999");
            Data_Elements.Add(111, "ans ... 999");
            Data_Elements.Add(112, "ans ... 999");
            Data_Elements.Add(113, "ans ... 999");
            Data_Elements.Add(114, "ans ... 999");
            Data_Elements.Add(115, "ans ... 999");
            Data_Elements.Add(116, "ans ... 999");
            Data_Elements.Add(117, "ans ... 999");
            Data_Elements.Add(118, "ans ... 999");
            Data_Elements.Add(119, "ans ... 999");
            Data_Elements.Add(120, "ans ... 999");
            Data_Elements.Add(121, "ans ... 999");
            Data_Elements.Add(122, "ans ... 999");
            Data_Elements.Add(123, "ans ... 999");
            Data_Elements.Add(124, "ans ... 999");
            Data_Elements.Add(125, "ans ... 999");
            Data_Elements.Add(126, "ans ... 999");
            Data_Elements.Add(127, "ans ... 999");
            Data_Elements.Add(128, "b 8");
        }

        //msg = Data_Element_Type(Data_Element[i], msg, out DE[i]) ## after execluding DE part
        public string Data_Element_Type(string type, string msg, out string DE)
        {
            List<string> typeConfig = new List<string>();
            typeConfig = type.Split(" ").ToList();
            string CharType = "";
            int count = 0;
            int PrefixCount = 0;
            string[] Res = new string[2];
            for (int i = 0; i < typeConfig.Count; i++)
            {
                //char type
                if (typeConfig[i] == "n")
                {
                    CharType = "Numeric";
                }
                else if (typeConfig[i] == "a")
                {
                    CharType = "Alpha";
                }
                else if (typeConfig[i] == "an")
                {
                    CharType = "AlphaNumeric";
                }
                else if (typeConfig[i] == "ans" || typeConfig[i] == "anp")
                {
                    CharType = "Alpha, Numeric & Special";
                }
                else if (typeConfig[i] == "ns")
                {
                    CharType = "Numeric & Special";
                }
                else if (typeConfig[i] == "as")
                {
                    CharType = "Alpha & Special";
                }
                else if (typeConfig[i] == "b")
                {
                    CharType = "Binary";
                }
                else if (typeConfig[i] == "aorn")
                {
                    CharType = "Alpha or Numeric";
                }
                else
                {
                    //check for prefix
                    if (typeConfig[i] == "x")
                    {
                        PrefixCount = 1;
                    }
                    else if (typeConfig[i].Contains('.'))
                    {
                        PrefixCount = typeConfig[i].Count(m => m == '.');
                    }
                }
                //Digits
                if (int.TryParse(typeConfig[i], out count))
                {
                    //Start Extraction
                    if (count > 0)
                    {
                        int x = 0;
                        bool isDigit = false;
                        //start decoding msg
                        //check for prefix
                        if (PrefixCount > 0)
                        {
                            string p = msg.Substring(0, PrefixCount * 2);
                            msg = msg.RemovePreFix(p);
                            p = ConvertHexToAscii(p);
                            isDigit = int.TryParse(p, out x);
                        }

                        //Get DE
                        if (isDigit && count > x)
                        {
                            Res = getDE(msg, x, CharType);
                        }
                        else
                        {
                            Res = getDE(msg, count, CharType);
                        }
                    }
                }
            }
            DE = Res[1];
            msg = msg.RemovePreFix(Res[0]);
            return msg;
        }

        //DE = getDE(msg, count, CharType) ## before Converting to ascii 
        public string[] getDE(string msg, int count, string CharType) // 0 => msg.Remove, 1 => DE 
        {
            string res = "";
            string DE = "";
            if (CharType == "Numeric" || CharType == "Alpha, Numeric & Special")
            {
                res = msg.Substring(0, count * 2);
                DE = ConvertHexToAscii(res);
            }
            else if (CharType == "Alpha")
            {
                res = msg.Substring(0, count);
                DE = msg.Substring(0, count);
            }
            else if (CharType == "AlphaNumeric")
            {
                res = msg.Substring(0, count * 2);
                DE = ConvertHexToAscii(res);
            }
            else if (CharType == "Numeric & Special")
            {
                res = msg.Substring(0, count);
                DE = msg.Substring(0, count);
            }
            else if (CharType == "Alpha & Special")
            {
                res = msg.Substring(0, count);
                DE = msg.Substring(0, count);
            }
            else if (CharType == "Binary")
            {
                res = msg.Substring(0, count * 2);
                DE = res;
            }
            else if (CharType == "Alpha or Numeric")
            {
                if (int.TryParse(msg[0].ToString(), out _))
                {
                    res = msg.Substring(0, count * 2);
                    DE = ConvertHexToAscii(msg.Substring(0, count * 2));
                }
                else
                {
                    res = msg.Substring(0, count);
                    DE = msg.Substring(0, count);
                }
            }
            else
            {
                DE = msg.Substring(0, count);
            }
            return new string[] { res, DE };
        }

        //GET n data elements (n)
        public static string ConvertHexToAscii(String hexString)
        {
            try
            {
                string ascii = string.Empty;
                //in repsonse 1314
                bool isSeg = false; // true => init new segement 
                string segNumber = "";
                Dictionary<string, string> segments = new Dictionary<string, string>();
                StringBuilder segment = new StringBuilder();

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;
                    hs = hexString.Substring(i, 2);
                    if (hs == "1D") //start of new segment
                    {
                        //new line
                        if (ascii.Last() != '@')
                        {
                            ascii += '@';
                        }

                        //end last segment
                        isSeg = false;
                        if (!segments.TryAdd(segNumber, segment.ToString()))
                        {
                            segments[segNumber] += "\n" + segment.ToString();
                        }
                        //reset segment
                        segment.Clear();
                        //init new segment
                        isSeg = true;
                        //segment.Append($"({hexString.Substring(i + 4, 4)}):");
                        segNumber = hexString.Substring(i + 4, 4);
                        i = i + 6;
                    }
                    //add separator
                    else if (hs == "1C")
                    {
                        if (isSeg)
                        {
                            segment.Append(", ");
                        }
                        else
                        {
                            ascii += ", ";
                        }
                    }
                    else
                    {
                        uint decval = Convert.ToUInt32(hs, 16);
                        char character = ' ';
                        if (decval > 127) //arabic chars
                        {
                            character = Encoding.GetEncoding("ISO-8859-6").GetChars(new byte[] { (byte)decval })[0];
                        }
                        else //normal ascii char
                        {
                            character = Convert.ToChar(decval);
                        }
                        // check if this is segment number
                        if (isSeg)
                        {
                            segment.Append(character);
                        }
                        else
                        {
                            ascii += character;
                        }
                    }
                }
                //last segment
                if (!segments.TryAdd(segNumber, segment.ToString()))
                {
                    segments[segNumber] += "\n" + segment.ToString();
                }
                //Add each segment to DE(72) Final Message
                foreach (var s in segments)
                {
                    if (!string.IsNullOrEmpty(s.Value))
                    {
                        ascii += s.Value + "\n\n"; //end of segment
                    }
                }
                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return string.Empty;
        }

        //Get message for mobile app
        public Message ISOMobileMessage(string[] DE, string mti)
        {
            var message = new Message();
            message.Mti_Code = mti;
            for(int i = 0; i < DE.Length; i++)
            {
                switch (i+1)
                {
                    case 1:
                        message.Bitmap = DE[i];
                        break;
                    case 2:
                        message.PAN = DE[i];
                        break;
                    case 3:
                        message.Processing_Code = DE[i];
                        break;
                    case 4:
                        message.Amount_Transaction = DE[i];
                        break;
                    case 5:
                        message.Amount_Settlement = DE[i];
                        break;
                    case 6:
                        message.Amount_CardHolder_billing = DE[i];
                        break;
                    case 7:
                        message.Transmission_Date = DE[i];
                        break;
                    case 8:
                        message.Amount_CardHolder_Billing_fee = DE[i];
                        break;
                    case 9:
                        message.Conversion_Rate_Settlement = DE[i];
                        break;
                    case 10:
                        message.Conversion_Rate_CardHolder_Billing = DE[i];
                        break;
                    case 11:
                        message.System_Trace_Audit_Number = DE[i];
                        break;
                    case 12:
                        message.Local_Transaction_Time = DE[i];
                        break;
                    case 13:
                        message.Local_Transaction_Date = DE[i];
                        break;
                    case 14:
                        message.Expiration_Date = DE[i];
                        break;
                    case 15:
                        message.Settlement_Date = DE[i];
                        break;
                    case 16:
                        message.Currency_Conversion_Date = DE[i];
                        break;
                    case 17:
                        message.Capture_Date = DE[i];
                        break;
                    case 18:
                        message.Merchant_Category_Code = DE[i];
                        break;
                    case 19:
                        message.Acquiring_Instition = DE[i];
                        break;
                    case 20:
                        message.PAN_Extended_Country_Code = DE[i];
                        break;
                    case 21:
                        message.Forwarding_Instition = DE[i];
                        break;
                    case 22:
                        message.POS_Entry_Mode = DE[i];
                        break;
                    case 23:
                        message.App_PAN_Sequence_Number = DE[i];
                        break;
                    case 24:
                        message.Function_Code = DE[i];
                        break;
                    case 25:
                        message.POS_Condition_Code = DE[i];
                        break;
                    case 26:
                        message.POS_Capture_Code = DE[i];
                        break;
                    case 27:
                        message.Auth_Identification_Response_Length = DE[i];
                        break;
                    case 28:
                        message.Amount_Transaction_Fee = DE[i];
                        break;
                    case 29:
                        message.Amount_Settlement_Fee = DE[i];
                        break;
                    case 30:
                        message.Amount_Transaction_Processing_Fee = DE[i];
                        break;
                    case 31:
                        message.Amount_Settlement_Processing_Fee = DE[i];
                        break;
                    case 32:
                        message.Acquiring_Instition_Identification_Code = DE[i];
                        break;
                    case 33:
                        message.Forwarding_Instition_Identification_Code = DE[i];
                        break;
                    case 34:
                        message.PAN_Extended = DE[i];
                        break;
                    case 35:
                        message.Track02_Data = DE[i];
                        break;
                    case 36:
                        message.Track03_Data = DE[i];
                        break;
                    case 37:
                        message.Retrieval_Reference_Number = DE[i];
                        break;
                    case 38:
                        message.Auth_Identification_Response = DE[i];
                        break;
                    case 39:
                        message.Response_Code = DE[i];
                        break;
                    case 40:
                        message.Service_Restriction_Code = DE[i];
                        break;
                    case 41:
                        message.Card_Acceptor_Terminal_Identifion = DE[i];
                        break;
                    case 42:
                        message.Card_Acceptor_Terminal_Code = DE[i];
                        break;
                    case 43:
                        message.Card_Acceptor_Name_Location = DE[i];
                        break;
                    case 44:
                        message.Addititonal_Response_Data = DE[i];
                        break;
                    case 45:
                        message.Track01_Data = DE[i];
                        break;
                    case 46:
                        message.Additional_Data_ISO = DE[i];
                        break;
                    case 47:
                        message.Additional_Data_National = DE[i];
                        break;
                    case 48:
                        message.Additional_Data_Private = DE[i];
                        break;
                    case 49:
                        message.CC_Transaction = DE[i];
                        break;
                    case 50:
                        message.CC_Settlement = DE[i];
                        break;
                    case 51:
                        message.CC_Cardholder_Billing = DE[i];
                        break;
                    case 52:
                        message.Personal_Identification_Number_Data = DE[i];
                        break;
                    case 53:
                        message.Security_Related_Control_Information = DE[i];
                        break;
                    case 54:
                        message.Additional_Amounts = DE[i];
                        break;
                    case 55:
                        message.ICC_Data = DE[i];
                        break;
                    case 56:
                        message.Reserved_ISO = DE[i];
                        break;
                    case 57:
                        message.Reserved_National01 = DE[i];
                        break;
                    case 58:
                        message.Reserved_National02 = DE[i];
                        break;
                    case 59:
                        message.Reserved_National03 = DE[i];
                        break;
                    case 60:
                        message.Reserved_National04 = DE[i];
                        break;
                    case 61:
                        message.Reserved_Private01 = DE[i];
                        break;
                    case 62:
                        message.Reserved_Private02 = DE[i];
                        break;
                    case 63:
                        message.Reserved_Private03 = DE[i];
                        break;
                    case 64:
                        message.MAC01 = DE[i];
                        break;
                    case 65:
                        message.Extended_Bitmap_Indicator = DE[i];
                        break;
                    case 66:
                        message.Settlement_Code = DE[i];
                        break;
                    case 67:
                        message.Extended_Payment_Code = DE[i];
                        break;
                    case 68:
                        message.Recieving_Institution_Country_Code = DE[i];
                        break;
                    case 69:
                        message.Settlement_Institution_Country_Code = DE[i];
                        break;
                    case 70:
                        message.Network_Management_Info_Code = DE[i];
                        break;
                    case 71:
                        message.Message_Number = DE[i];
                        break;
                    case 72:
                        message.Last_Message_Number = DE[i];
                        break;
                    case 73:
                        message.Action_Date = DE[i];
                        break;
                    case 74:
                        message.Number_of_Credits = DE[i];
                        break;
                    case 75:
                        message.Credits = DE[i];
                        break;
                    case 76:
                        message.Number_of_Debits = DE[i];
                        break;
                    case 77:
                        message.Debits = DE[i];
                        break;
                    case 78:
                        message.Number_of_Transfers = DE[i];
                        break;
                    case 79:
                        message.Transfers = DE[i];
                        break;
                    case 80:
                        message.Number_of_Inquiries = DE[i];
                        break;
                    case 81:
                        message.Number_of_Auth = DE[i];
                        break;
                    case 82:
                        message.Credits_Processing_Fee_Amount = DE[i];
                        break;
                    case 83:
                        message.Credits_Transaction_Fee_Amount = DE[i];
                        break;
                    case 84:
                        message.Debits_Processing_Fee_Amount = DE[i];
                        break;
                    case 85:
                        message.Debits_Transaction_Fee_Amount = DE[i];
                        break;
                    case 86:
                        message.Total_Amount_Credits = DE[i];
                        break;
                    case 87:
                        message.Credits_Reversal_Amount = DE[i];
                        break;
                    case 88:
                        message.Total_Amount_Debits02 = DE[i];
                        break;
                    case 89:
                        message.Debits_Reversal_Amount = DE[i];
                        break;
                    case 90:
                        message.Original_Data_Elements = DE[i];
                        break;
                    case 91:
                        message.File_Update_Code = DE[i];
                        break;
                    case 92:
                        message.File_Security_Code = DE[i];
                        break;
                    case 93:
                        message.Response_Indicator = DE[i];
                        break;
                    case 94:
                        message.Service_Indicator = DE[i];
                        break;
                    case 95:
                        message.Replacement_Amounts = DE[i];
                        break;
                    case 96:
                        message.Message_Security_Code = DE[i];
                        break;
                    case 97:
                        message.Net_Settlement_Amount = DE[i];
                        break;
                    case 98:
                        message.Payee = DE[i];
                        break;
                    case 99:
                        message.Settlement_Instition_Identification_Code = DE[i];
                        break;
                    case 100:
                        message.Receving_Instition_Identification_Code = DE[i];
                        break;
                    case 101:
                        message.File_Name = DE[i];
                        break;
                    case 102:
                        message.Account_Identification01 = DE[i];
                        break;
                    case 103:
                        message.Account_Identification02 = DE[i];
                        break;
                    case 104:
                        message.Transaction_Description = DE[i];
                        break;
                    case 105:
                        message.Reversed_ISO_Use01 = DE[i];
                        break;
                    case 106:
                        message.Reversed_ISO_Use02 = DE[i];
                        break;
                    case 107:
                        message.Reversed_ISO_Use03 = DE[i];
                        break;
                    case 108:
                        message.Reversed_ISO_Use04 = DE[i];
                        break;
                    case 109:
                        message.Reversed_ISO_Use05 = DE[i];
                        break;
                    case 110:
                        message.Reversed_ISO_Use06 = DE[i];
                        break;
                    case 111:
                        message.Reversed_ISO_Use07 = DE[i];
                        break;
                    case 112:
                        message.Reversed_National_Use01 = DE[i];
                        break;
                    case 113:
                        message.Reversed_National_Use02 = DE[i];
                        break;
                    case 114:
                        message.Reversed_National_Use03 = DE[i];
                        break;
                    case 115:
                        message.Reversed_National_Use04 = DE[i];
                        break;
                    case 116:
                        message.Reversed_National_Use05 = DE[i];
                        break;
                    case 117:
                        message.Reversed_National_Use06 = DE[i];
                        break;
                    case 118:
                        message.Reversed_National_Use07 = DE[i];
                        break;
                    case 119:
                        message.Reversed_National_Use08 = DE[i];
                        break;
                    case 120:
                        message.Reversed_Private_Use01 = DE[i];
                        break;
                    case 121:
                        message.Reversed_Private_Use02 = DE[i];
                        break;
                    case 122:
                        message.Reversed_Private_Use03 = DE[i];
                        break;
                    case 123:
                        message.Reversed_Private_Use04 = DE[i];
                        break;
                    case 124:
                        message.Reversed_Private_Use05 = DE[i];
                        break;
                    case 125:
                        message.Reversed_Private_Use06 = DE[i];
                        break;
                    case 126:
                        message.Reversed_Private_Use07 = DE[i];
                        break;
                    case 127:
                        message.Reversed_Private_Use08 = DE[i];
                        break;
                    case 128:
                        message.MAC02 = DE[i];
                        break;
                    default:
                        break;
                }
            }

            return message;
        }
    }
}