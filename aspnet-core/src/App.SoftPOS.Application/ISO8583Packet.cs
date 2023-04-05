using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SoftPOS
{
    public class ISO8583Packet
    {
        [MaxLength(14)]
        public string ISOHeader { get; set; }
        [MaxLength(4)]
        public string MTI_Code { get; set; }
        [MaxLength(32)]
        public string Bitmap { get; set; }
        [MaxLength(19)] //two digits in front to identify number of digits in it
        public string PAN { get; set; }
        [MaxLength(6)]
        public string Processing_Code { get; set; }
        [MaxLength(12)]
        public string Amount_Trans { get; set; }
        [MaxLength(12)]
        public string Amount_Sett { get; set; }
        [MaxLength(12)]
        public string Amount_CardHolder { get; set; }
        [MaxLength(10)]
        public string Tran_Date { get; set; }
        [MaxLength(8)]
        public string Amount_CardHolder_fee { get; set; }
        [MaxLength(8)]
        public string Conver_Rate_Sett { get; set; }
        [MaxLength(8)]
        public string Conver_Rate_CardHolder { get; set; }
        [MaxLength(6)]
        public string STAN { get; set; } //System Trace Audit Number
        [MaxLength(6)]
        public string Local_Trans_Time { get; set; }
        [MaxLength(4)]
        public string Local_Trans_Date { get; set; }
        [MaxLength(4)]
        public string Exp_Date { get; set; } //expiration Date
        [MaxLength(4)]
        public string Sett_Date { get; set; }
        [MaxLength(4)]
        public string Currency_Conv_Date { get; set; }
        [MaxLength(4)]
        public string Capture_Date { get; set; }
        [MaxLength(4)]
        public string MCC { get; set; } //Merchant Category Code
        [MaxLength(3)]
        public string Acquiring_Instit { get; set; } //Acquring Instition (Country Code)
        [MaxLength(3)]
        public string PAN_Extended_CC { get; set; } //PAN With Country Code
        [MaxLength(3)]
        public string Forwarding_Instit { get; set; }
        [MaxLength(3)]
        public string POS_Entry_Mode { get; set; }
        [MaxLength(3)]
        public string App_PAN_Seq_Number { get; set; }
        [MaxLength(3)]
        public string Function_Code { get; set; } //Network International Indentifier or Function Code
        [MaxLength(2)]
        public string POS_Condition_Code { get; set; }
        [MaxLength(2)]
        public string POS_Capture_Code { get; set; }
        [MaxLength(1)]
        public string Auth_Identif_Resp_Len { get; set; }
        [MaxLength(8)] //Start with either 'C' for +ve/Credit or -ve/Debit then 8 digits
        public string Amount_Trans_Fee { get; set; }
        [MaxLength(8)] //Start with either 'C' for +ve/Credit or -ve/Debit then 8 digits
        public string Amount_Sett_Fee { get; set; }
        [MaxLength(8)] //Start with either 'C' for +ve/Credit or -ve/Debit then 8 digits
        public string Amount_Trans_Processing_Fee { get; set; }
        [MaxLength(8)] //Start with either 'C' for +ve/Credit or -ve/Debit then 8 digits
        public string Amount_Sett_Processing_Fee { get; set; }
        [MaxLength(11)] //two digits in front to idenify number of digits in it
        public string Acq_Instit_Identif_Code { get; set; }
        [MaxLength(11)] //two digits in front to idenify number of digits in it
        public string Forwarding_Instit_Identif_Code { get; set; }
        [MaxLength(28)] //two digits in front to identify number of digits in it & it takes special char and numbers only
        public string PAN_Extended { get; set; } //PAN Without Country Code

        public string Track02_Data { get; set; }
        [MaxLength(104)] //3 digits in front to identify number of digits in it
        public string Track03_Data { get; set; }
        [MaxLength(12)] //12 Alphanumeric (1-F)
        public string Retrieval_Ref_Number { get; set; }
        [MaxLength(6)] //6 Alphanumeric (1-F)
        public string Auth_Identif_Resp { get; set; }
        [MaxLength(2)] //2 Alphanumeric (1-F)
        public string Resp_Code { get; set; }
        [MaxLength(3)] //3 Alphanumeric (1-F)
        public string Service_Restriction_Code { get; set; }
        [MaxLength(8)] //8 Alphabetic, numeric and special characters.
        public string CATI { get; set; } //Card Acceptor Terminal Identifion
        [MaxLength(15)] //15 Alphabetic, numeric and special characters.
        public string CATC { get; set; } //Card Acceptor Terminal Code
        [MaxLength(40)] //40 Alphabetic, numeric and special characters.
        public string Card_Acceptor_Name_Location { get; set; } //1-23 street address, -36 City, -38 State, 39-40 Country
        [MaxLength(25)] //25 Alphabetic and numeric & 2 digits in front to identify of number of digits in it
        public string Addititonal_Resp_Data { get; set; }
        [MaxLength(76)] //76 Alphabetic and numeric & 2 digits in front to identify of number of digits in it
        public string Track01_Data { get; set; }
        [MaxLength(999)] // Alphabetic and numeric & 3 digits in front to identify of number of digits in it
        public string Additional_Data_ISO { get; set; }
        [MaxLength(999)] // Alphabetic and numeric & 3 digits in front to identify of number of digits in it
        public string Additional_Data_National { get; set; }
        [MaxLength(999)] // Alphabetic and numeric & 3 digits in front to identify of number of digits in it
        public string Additional_Data_Private { get; set; }
        [MaxLength(3)] //numbers or alphabetic
        public string CC_Trans { get; set; } //Currency Code Transaction
        [MaxLength(3)] //numbers or alphabetic
        public string CC_Sett { get; set; } //Currency Code Settlement
        [MaxLength(3)] //numbers or alphabetic
        public string CC_Cardholder_Billing { get; set; } //Currency Code CardHolder Billing
        [MaxLength(64)]
        public string PIND { get; set; } // Personal identification number data
        [MaxLength(16)]
        public string SRCI { get; set; } // Security related control information
        [MaxLength(120)] //alph and numeric & 3 digits in front to identify of number of digits in it
        public string Additional_Amounts { get; set; }
        [MaxLength(999)] //Alphabetic, numeric and special characters & 3 digits in front to identify of number of digits in it
        public string ICC_Data { get; set; }
        [MaxLength(999)] //Alphabetic, numeric and special characters & 3 digits in front to identify of number of digits in it
        public string Reserved_ISO { get; set; }
        [MaxLength(999)] //Alphabetic, numeric and special characters & 3 digits in front to identify of number of digits in it
        public string[] Reserved_National { get; set; } //DE(57,58,59,60)
        [MaxLength(999)] //Alphabetic, numeric and special characters & 3 digits in front to identify of number of digits in it
        public string[] Reserved_Private { get; set; } //DE(61,62,63)
        [MaxLength(16)] //Alpha and numbers
        public string MAC01 { get; set; } //Message Authentication Code
        [MaxLength(1)]
        public string Extended_Bitmap_Indicator { get; set; }
        [MaxLength(1)]
        public string Sett_Code { get; set; }
        [MaxLength(2)]
        public string Extended_Payment_Code { get; set; }
        [MaxLength(3)]
        public string RICC { get; set; } //Recieving Institution Country Code
        [MaxLength(3)]
        public string SICC { get; set; } //Settlement Institution Country Code
        [MaxLength(3)]
        public string NMIC { get; set; } //Network Management Info Code
        [MaxLength(4)]
        public string Message_Number { get; set; }
        [MaxLength(4)]
        public string Last_Message_Number { get; set; }
        [MaxLength(6)]
        public string Action_Date { get; set; } //(YYMMDD)
        [MaxLength(10)]
        public string Number_of_Credits { get; set; }
        [MaxLength(10)]
        public string Credits { get; set; } //Credits Reversal Number
        [MaxLength(10)]
        public string Number_of_Debits { get; set; }
        [MaxLength(10)]
        public string Debits { get; set; } //Debits Reversal Number
        [MaxLength(10)]
        public string Number_of_Transfers { get; set; }
        [MaxLength(10)]
        public string Transfers { get; set; } //Transfer Reversal Number
        [MaxLength(10)]
        public string Number_of_Inquiries { get; set; }
        [MaxLength(10)]
        public string Number_of_Auth { get; set; }
        [MaxLength(12)]
        public string Credits_Processing_Fee_Amount { get; set; }
        [MaxLength(12)]
        public string Credits_Trans_Fee_Amount { get; set; }
        [MaxLength(12)]
        public string Debits_Processing_Fee_Amount { get; set; }
        [MaxLength(12)]
        public string Debits_Trans_Fee_Amount { get; set; }
        [MaxLength(16)]
        public string Total_Amount_Credits { get; set; }
        [MaxLength(16)]
        public string Credits_Reversal_Amount { get; set; }
        [MaxLength(16)]
        public string Total_Amount_Debits02 { get; set; }
        [MaxLength(16)]
        public string Debits_Reversal_Amount { get; set; }
        [MaxLength(42)]
        public string Original_Data_Element { get; set; }
        [MaxLength(1)] //Alpha and Number
        public string File_Update_Code { get; set; }
        [MaxLength(2)] //Alpha and Number
        public string File_Security_Code { get; set; }
        [MaxLength(5)] //Alpha and Number
        public string Resp_Indicator { get; set; }
        [MaxLength(7)] //Alpha and Number
        public string Service_Indicator { get; set; }
        [MaxLength(42)] //Alpha and Number
        public string Replacement_Amounts { get; set; }
        [MaxLength(16)] //alpha and number
        public string Message_Security_Code { get; set; }
        [MaxLength(16)] //Start with either 'C' for +ve/Credit or -ve/Debit then 8 digits
        public string Net_Sett_Amount { get; set; }
        [MaxLength(25)] //Alpha, numbers and special char
        public string Payee { get; set; }
        [MaxLength(11)] //2 digits in front to to identify of number of digits in it
        public string SIIC { get; set; } //Settlement Instition Identification Code
        [MaxLength(11)] //2 digits in front to to identify of number of digits in it
        public string RIIC { get; set; } //Receving Instition Identification Code
        [MaxLength(17)] //Apha, number and special char & 2 digits in front to to identify of number of digits in it
        public string File_Name { get; set; }
        [MaxLength(28)] //Apha, number and special char & 2 digits in front to to identify of number of digits in it
        public string Account_Ident01 { get; set; }
        [MaxLength(28)] //Apha, number and special char & 2 digits in front to to identify of number of digits in it
        public string Account_Ident02 { get; set; }
        [MaxLength(100)] //Apha, number and special char & 2 digits in front to to identify of number of digits in it
        public string Trans_Descrip { get; set; }
        [MaxLength(999)] // 3 digits in front to to identify of number of digits in it
        public string[] Reversed_ISO_Use { get; set; } //DE(105-111)
        [MaxLength(999)] // 3 digits in front to to identify of number of digits in it
        public string[] Reversed_National_Use { get; set; } //DE(112-119)
        [MaxLength(999)] // 3 digits in front to to identify of number of digits in it
        public string[] Reversed_Private_Use { get; set; } //DE(120-127)
        [MaxLength(16)] //Alpha and number
        public string MAC02 { get; set; } //Message Authentication Code

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

        //Get Bitmap

        //msg = Data_Element_Type(Data_Element[i], msg, out DE[i]) ## after execluding DE part
        public string Data_Element_Type(string type, string msg, out string DE)
        {
            List<string> typeConfig = new List<string>();
            typeConfig = type.Split(" ").ToList();
            string CharType = "";
            int count = 0;
            int PrefixCount = 0;
            string[] Res = new string[2];
            for(int i = 0; i <  typeConfig.Count; i++)
            {
                //char type
                if (typeConfig[i] == "n")
                {
                    CharType = "Numeric";
                }
                else if(typeConfig[i] == "a")
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
                    if(count > 0)
                    {
                        int x = 0;
                        bool isDigit = false;
                        //start decoding msg
                        //check for prefix
                        if(PrefixCount > 0)
                        {
                            string p = msg.Substring(0, PrefixCount*2);
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
            else if(CharType == "Alpha")
            {
                res = msg.Substring(0, count);
                DE = msg.Substring(0, count);
            }
            else if (CharType == "AlphaNumeric")
            {
                res = msg.Substring(0, count*2);
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
                res = msg.Substring(0, count*2);
                DE = res;
            }
            else if (CharType == "Alpha or Numeric")
            {
                if (int.TryParse(msg[0].ToString(), out _)){
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
                    if(hs == "1D") //start of new segment
                    {
                        //new line
                        if(ascii.Last() != '@')
                        {
                            ascii += '@';
                        }
                        
                        //end last segment
                        isSeg = false;
                        if(!segments.TryAdd(segNumber, segment.ToString()))
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
                        if(isSeg)
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
                    if(!string.IsNullOrEmpty(s.Value))
                    {
                        ascii += s.Value + "\n\n";
                    }
                }
                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return string.Empty;
        }
    }
}