using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Hashing
{
    class Program
    {
        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        public static string[] DataTypes = { "Digits", "characters" };

        public enum DataType
        {
            Numeric = 0,
            Alphabets = 1
        }

        //public static void SetRefValue(ref string sRef)
        //{
        //    sRef = "Testing Reference value";
        //}

        private static string ValidateEmailaddress(string emailAddress) 
        {
            try
            {
                MailAddress _address = new MailAddress(emailAddress);
                return "";
            }
            catch {
                return "Invalid Email Address.";
            }            
        }

        public static string CapitalizeString(string strData)
        {
            return String.Join(" ", strData.Trim().Split(new string[] { " " }, 
                    StringSplitOptions.RemoveEmptyEntries).Select(item => item.ToUpper().Substring(0, 1) + item.Substring(1).ToLower())).Replace(" Llc", 
                        " LLC").Replace(" LLc", " LLC").Replace(" Llp", " LLP").Replace(" LLp", " LLP");
        }

        public static bool isSumOfTwoPositiveInteger(int sampleData)
        {
            bool isValid = false;
            int tempNo = 0;

            for (int no = 1; no <= sampleData; no++)
            {
                tempNo += no;
                if (tempNo == sampleData)
                {
                    return true;
                }
                if (tempNo > sampleData)
                {
                    return false;
                }
            }
            return isValid;
        }

        public static void Main(string[] args)
        {

            //int[] data = { 32, 37, 13, 21, 16, 55, 58, 37, 20, 50, 32, 14, 6, 25, 28, 51, 33, 1, 16, 8, 128, 25, 8, 64, 18, 16, 44, 19, 31, 3, 57, 21, 21, 20, 32, 8, 60, 27, 23, 8, 37, 33, 39, 10, 15, 56, 53, 26, 10, 4 };
            int[] data = { 20 };

            int count = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (isSumOfTwoPositiveInteger(data[i]))
                {
                    Console.WriteLine(data[i].ToString());
                    count++;
                }
            }

            Console.WriteLine("Total: " + count.ToString());           


            //string var = "96h11k4959q615948s50922o38h1453ij38w73413d5577lzrqw3780b389750vf100zd29z73j5wh73l6965n85vm77cw10awrjr29265289222238n10013uk10062f9449acbhfgcm35j78q80";
            //string mystr = Regex.Replace(var, @"\d", "");
            //string mynumber = Regex.Replace(var, @"\D", "");
            ////Console.WriteLine(mynumber);
            //char[] arr = mynumber.ToCharArray();
            //foreach (char c in arr)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            //var temp = arr.Sum(a => int.Parse(a.ToString()));
            //Console.WriteLine(temp);


            //double baseCharge = -1, priceLess = -1;
            //bool isEmptyBaseCharge = false, isEmptyPriceLess = false;

            //string IsValidBaseCharge = Util.ParseDouble("4", ref baseCharge, ref isEmptyBaseCharge);
            //string IsValidpriceLess = Util.ParseDouble("4.1", ref priceLess, ref isEmptyPriceLess);

            //if (IsValidBaseCharge == String.Empty && IsValidpriceLess == String.Empty)
            //{
            //    if ((!isEmptyBaseCharge && !isEmptyPriceLess) || (isEmptyPriceLess && isEmptyBaseCharge))
            //    {
            //        Console.WriteLine("Not OK");
            //    }
            //    else
            //    {
            //        Console.WriteLine("OK");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid! Not OK");
            //}

            // checking partially filename
            //string filename = "Promo_Export_20150116_0248.csv";
            //string tocomparefilename = "Promo_Export_20150118";

            //if (filename.Contains(tocomparefilename))
            //{
            //    Console.WriteLine(filename);
            //    Console.WriteLine(tocomparefilename);
            //    Console.WriteLine("OK");
            //}
            //else {
            //    Console.WriteLine(filename);
            //    Console.WriteLine(tocomparefilename);
            //    Console.WriteLine("NOT OK");
            //}
            // ending checking partially filename

            //Console.WriteLine(ParsePositiveInt("1.5"));

            //double d = 100.5 / 100.00;
            //Console.WriteLine(d.ToString() + " " + d.ToString("N" + (d.ToString().Length - 1).ToString()));

            //string data = "0.003";
            //Console.WriteLine(Convert.ToDouble(data).ToString("F2"));

            //string strDate = "2014-01-05";

            //DateTime dt1;

            //if (DateTime.TryParseExact(strDate, "yyyy-MM-01", new System.Globalization.CultureInfo("en-US"),
            //     System.Globalization.DateTimeStyles.None, out dt1) == false)
            //{
            //    Console.WriteLine("InValid");
            //}
            //else {
            //    Console.WriteLine("Valid");
            //}


            //Console.WriteLine(DateTime.Parse(strDate).ToString("yyyy-MM-dd"));
            //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));

            //string LicenseNo = "1 ";

            //if (GetValue(LicenseNo) != string.Empty)
            //{
            //    LicenseNo = new string('X', LicenseNo.Length);
            //    Console.WriteLine(LicenseNo);
            //}
            //else
            //{
            //    Console.WriteLine("No License No.");
            //}

            //string SSN ="123-45-6666";

            //if (GetValue(SSN) != string.Empty) {
            //    Console.WriteLine("SSN Replaced " + "XXX-XX-" + SSN.Substring(7));
            //}
            //else{
            //    Console.WriteLine("No SSN");
            //}


            //string strStart = "09/16/2014";
            //string strEnd = "09/15/2014";

            //DateTime dtToday = DateTime.Parse(DateTime.Today.ToString("MM/dd/yyyy"));
            //DateTime dtStart = DateTime.Parse(strStart);
            //DateTime dtEnd = DateTime.Parse(strEnd);

            //if (dtToday < dtStart || dtToday > dtEnd)
            //{
            //    Console.WriteLine("Error");
            //}
            //else {
            //    Console.WriteLine("Not an Error");
            //}


            //string Val = "";

            //string[] arr = Val.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            //try
            //{
            //    Array.ForEach<string>(arr, IsInt);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            

            //try
            //{
            //    DateTime.Parse(dt);
            //}
            //catch (FormatException fe) {
            //    Console.WriteLine("Fe" + fe.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string TestingData = "350";

            //double DepositAmount = 0;

            //DepositAmount = GetFloat(TestingData, DepositAmount) / 2;

            //Console.WriteLine(string.Concat("$", DepositAmount.ToString()));

            // Console.Write(CapitalizeString(TestingData));


            //DateTime dt = DateTime.Parse("07/01/2014");
            //DateTime dt1 = DateTime.Parse("06/30/2014");
            //Console.WriteLine((dt-dt1).Days.ToString());

         //   Console.Write(DateTime.Now.AddMonths(6).ToString("MMMM yyyy"));

            //StringBuilder strSQL = new StringBuilder();            

            //strSQL.AppendFormat(" Select ID, AccountNumber From Customer where AccountNumber = '{0}'", "123-332144");
            //Console.WriteLine(strSQL.ToString());

            //strSQL.Remove(0, strSQL.Length);
            //Console.WriteLine(strSQL.ToString());


            //string margin = "0.000000000";
            //decimal dmargin = 0;
            //decimal.TryParse(margin, out dmargin);
            //// SetValue(ref ColumnIndexer, RowIndexer, worksheet, dmargin.ToString("#.#########"), ExcelHorizontalAlignment.Right);
            //Console.Write(dmargin.ToString("#.#########"));

            //double EnergyCharge = 100;
            //string Content = "#EnergyCharge#";

            //EnergyCharge = Math.Round((EnergyCharge / (float)100),6);

            //string EC = EnergyCharge.ToString();

            //if (EC.Contains(".") && EC.Substring(EC.LastIndexOf(".")+1).Length == 1)
            //{                 
            //    Content = Content.Replace("#EnergyCharge#", "$" + EnergyCharge.ToString() + "0");
            //}
            //else {                
            //    Content = Content.Replace("#EnergyCharge#", "$" + EnergyCharge.ToString());
            //}

            //string email = "kashif@";
            //Console.WriteLine(ValidateEmailaddress(email));
            //Console.ReadKey();


            //string strdt = "06/10/2014";
            //DateTime now = DateTime.Now;
            //DateTime dt = DateTime.Parse(strdt).AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
            //Console.WriteLine(dt);


            //string strRef = "";
            //SetRefValue(ref strRef);
            //Console.WriteLine(strRef);

            //string strHash = GetHash("628308369");
            //StreamWriter writer = new StreamWriter(@"D:\Kashif\Projects\Hashing\Hashing\bin\Debug\log.txt", true);
            //writer.WriteLine(strHash);
            //writer.Flush();
            //writer.Close();
            //writer.Dispose();
            //Console.WriteLine(strHash);
            // string strEncrypt = Encrypt("628308369");
            //string strDecrypt = Decrypt(strEncrypt);
            //string strQuery = "http://50.63.64.71:900/SelectPlan.aspx?Zip=77057&PromoCode=&Type=1&TDSP=4&Service=Electricity&parameter=1" + 
            //        " &StateCode=TX&Zone=&UserName=nRy/sK5Z7ENvGsSwfcmLzw==";
            //string strQuery =  "580160000";            

            //var str = strQuery.SkipWhile( s => s == '0') ;
            //string strTemp = "";

            //foreach (char c in str)
            //{
            //    strTemp = string.Concat(strTemp, c.ToString());                
            //}

            //Console.WriteLine(strTemp);
            //decimal val = 0;
            //decimal.TryParse("",out val);
            //Console.WriteLine(val.ToString("#.#############"));

            //string[] strBCC = { "", "" };

            //foreach (string BCC in strBCC)
            //{
            //    Console.WriteLine(BCC);
            //}                                  

            //string AcctNo = "XXXXXXXX-0002";
            //Console.WriteLine(AcctNo.Substring(AcctNo.Length - 2,2).PadLeft(4,'X'));

            //Console.WriteLine(DataTypes[DataType.Numeric.GetHashCode()]);
            //try
            //{
            //    int i = int.Parse("2");
            //    Console.WriteLine(i.ToString());
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine(fe.Message);
            //}

            //string DistributorName = "JCP&Lt";
            
            //string[] Distributors = { "Pepco MD", "JCP&L", "Atlantic City Electric", "Public Service Electric and Gas – Electric", "Duke Energy Ohio", "Delmarva Power MD", "Commonwealth Edison" };

            //string distributor = Distributors.Where(r => r == DistributorName).SingleOrDefault();
            
            //Console.WriteLine(distributor);

            //string customername = "BECERRA-";
            //Console.WriteLine(customername.Substring(0, customername.LastIndexOf("-")) + " " +
            //    customername.Substring(customername.LastIndexOf("-")+1).Trim());

            //string dt = "2014-0405";
            //try
            //{                
            //    DateTime dt1;
            //    if (DateTime.TryParseExact(dt, "yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"), 
            //         System.Globalization.DateTimeStyles.None, out dt1) == false)
            //    {
            //        Console.WriteLine("Invalid date");
            //    }
            //}
            //catch {
            //    Console.WriteLine("Invalid");
            //}

            //double Avg3 = 0;
            // Avg3 = (2000 * (EnergyCharge + TDSPKwh) + BaseCharge + TDSPMonthly) / 2000 * 100;
            //Energy Charge = 6.1
            //Mills = 6
            //TDSPMonthly = 5.25
            //TDSPKwh = 3.223 
            //TDSPKwh = 0
            //BaseCharge = 0 

            //Avg3 = (2000 * ((6.1 / 100.00) + (6 / 1000.00) + (3.223 / 100.00)) + 0 + 5.25) / 2000.00 * 100;
            //Avg3 = ((3500 * (0.067 + 0.03223) + 0 + 5.25) + (16 * 0)) / 3500.00 * 100;
            //Avg3 = Math.Round(Avg3, 1);
            //Console.WriteLine(Avg3.ToString());

            //object s = null;
            //if (s == DBNull.Value || s == null || s.ToString() == "")
            //{
            //    Console.WriteLine(s);
            //}

            //DataTable tbl = new DataTable();
            //tbl.Columns.Add("test1", System.Type.GetType("System.String"), "").DefaultValue = "";
            // Demo
            // {"System":{"Client":"SigmaPIA","ACX":"V2ViSnNvbkVOUkxAU2lnbWFQSUE6V2ViJFBJQWpzb24=","KEY":"QW51bWF0aGlVbmRhQFNpZ21hUElBOlVuZHVBbnVtYXRoaQ==","ClientIP":"127.0.0.1","Mode":"UPDATE"},"Module":{"Process": "BatchEnrollment","Version":"2.1.5","DataDefinition":[{"Name": "enrolment_queue","RecType": "","IncludeRecType": false,"Identifier": "sys_batch_no","Header":["rec_type","batch_no","batch_file_name","source","source_line","agent_code","premise_id","plan_group","request_date","enrol_type","offcycle_switch_date","company_name","cust_firstname","cust_lastname","cust_mi","ssn","phone1","cm_address1","cm_address2","cm_address3","cm_city","cm_state","cm_zip","phone2","email_address","contact1","contact2","account_rep","life_support","waiver_notice","cust_status","plan_id1","plan_id2","plan_id3","cust_ref_id","billto_cust_id","contract_ind","contract_no","master_contract_no","contract_date","contract_start_date","contract_end_date","contract_term","contract_type","calc_method","sys_charge_code_st","rate_type","contract_rate","adder1_rate","adder2_rate","agent_commission_rate","contract_comments","holdover_contract","mcp_multiplier","fixed_rate_factor","lock_box","pay_term","cust_bill_type","cust_bill_mode","tax_exempt1","tax_exempt2","tax_exempt3","tax_exempt4","tax_exempt5","tax_exempt6","tax_exempt7","tax_exempt8","credit_id","edi_bill_presenter","deposit_plan","deposit_amount","deposit_pay_type","deposit_aba_nbr","deposit_account_no","deposit_cc_no","deposit_expiry_YYYY","deposit_expiry_MM","deposit_security_code","deposit_pay_amount","Deposit_charge","deposit_acct_type","deposit_card_type","agent_duns","default_contract_id","plan_id_t1","plan_id_t1_rate","plan_id_t1_rateper","plan_id_t2","plan_id_t2_rate","plan_id_t2_rateper","plan_id_t3","plan_id_t3_rate","plan_id_t3_rateper","use_data_from_file","pm_address1","pm_address2","pm_city","pm_state","pm_zip","pm_county","pm_country","pm_duns","pm_meter","pm_multiplier","sysusg1_type","sysusg1_rate","sysusg2_type","sysusg2_rate","sysusg3_type","sysusg3_rate","sysusg4_type","sysusg4_rate","sysusg5_type","sysusg5_rate","sysusg6_type","sysusg7_type","sysusg7_rate","sysusg8_type","sysusg8_rate","bill_msg","priority_code","multi_plan","multi_plan_rate","spouse_email","cust_fax1","use_cust_id","flow_status","CUST_DRL_NBR","CUST_DRL_STATE","CUST_DRL_EXPIRE","CUST_DOB"]}],"Data": [["","Batch","","Web","1234","V001","PREMISE1","R1","8/8/2014","S","","","kashif","ahmed","","628308311","3334445555","2323 S Voss. RD","Suite# 390","","Houston","TX","77057","","kashif@medtractions.com","333-444-5555","333-444-5555","","N","","P","PR1402100003","","","","","","","","","","","12","months","1","","4","","2","","1","","","1","0","","","Default","","","","","","","","","","","ESP","No Deposit Needed","","","","","","","","","","","","","","","","","","","","","","","","","2323 S Voss RD","Suite# 390","Houston","TX","77057","","US","","","","","","","","","","","","","","","","","","","","","","","","","","100","","","","",""]]}}

            //string []Columns = { "rec_type","batch_no","batch_file_name","source","source_line","agent_code","premise_id","plan_group","request_date","enrol_type","offcycle_switch_date","company_name","cust_firstname","cust_lastname","cust_mi","ssn","phone1","cm_address1","cm_address2","cm_address3","cm_city","cm_state","cm_zip","phone2","email_address","contact1","contact2","account_rep","life_support","waiver_notice","cust_status","plan_id1","plan_id2","plan_id3","cust_ref_id","billto_cust_id","contract_ind","contract_no","master_contract_no","contract_date","contract_start_date","contract_end_date","contract_term","contract_type","calc_method","sys_charge_code_st","rate_type","contract_rate","adder1_rate","adder2_rate","agent_commission_rate","contract_comments","holdover_contract","mcp_multiplier","fixed_rate_factor","lock_box","pay_term","cust_bill_type","cust_bill_mode","tax_exempt1","tax_exempt2","tax_exempt3","tax_exempt4","tax_exempt5","tax_exempt6","tax_exempt7","tax_exempt8","credit_id","edi_bill_presenter","deposit_plan","deposit_amount","deposit_pay_type","deposit_aba_nbr","deposit_account_no","deposit_cc_no","deposit_expiry_YYYY","deposit_expiry_MM","deposit_security_code","deposit_pay_amount","Deposit_charge","deposit_acct_type","deposit_card_type","agent_duns","default_contract_id","plan_id_t1","plan_id_t1_rate","plan_id_t1_rateper","plan_id_t2","plan_id_t2_rate","plan_id_t2_rateper","plan_id_t3","plan_id_t3_rate","plan_id_t3_rateper","use_data_from_file","pm_address1","pm_address2","pm_city","pm_state","pm_zip","pm_county","pm_country","pm_duns","pm_meter","pm_multiplier","sysusg1_type","sysusg1_rate","sysusg2_type","sysusg2_rate","sysusg3_type","sysusg3_rate","sysusg4_type","sysusg4_rate","sysusg5_type","sysusg5_rate","sysusg6_type","sysusg7_type","sysusg7_rate","sysusg8_type","sysusg8_rate","bill_msg","priority_code","multi_plan","multi_plan_rate","spouse_email","cust_fax1","use_cust_id","flow_status","CUST_DRL_NBR","CUST_DRL_STATE","CUST_DRL_EXPIRE","CUST_DOB"};
            //string[] Values = { "", "t1", "", "Web", "", "V001", "PREMISE1", "R1", "05/15/2014", "S", "05/18/2014", "", "kashif", "ahmed", "", "123456789", "123-456-7890", "2323 S Voss RD", "Suite# 390", "", "Houston", "TX", "77057", "", "kashif@itconcepts.com", "", "", "", "N", "N", "P", "PR1402100001", "", "", "10000000230", "", "Y", "", "", "05/18/2014", "05/18/2014", "05/18/2015", "12", "months", "", "", "4", "", "0.02", "", "0.0015", "", "", "1", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "LDC", "", "350", "C", "", "", "", "", "", "", "350", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "N", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "120", "", "", "", "01/10/1966" };            

            //string []Columns = {"rec_type","batch_no","batch_file_name","source","source_line","agent_code","premise_id","plan_group","request_date","enrol_type","offcycle_switch_date","company_name","cust_firstname","cust_lastname","cust_mi","ssn","phone1","cm_address1","cm_address2","cm_address3","cm_city","cm_state","cm_zip","phone2","email_address","contact1","contact2","account_rep","life_support","waiver_notice","cust_status","plan_id1","plan_id2","plan_id3","cust_ref_id","billto_cust_id","contract_ind","contract_no","master_contract_no","contract_date","contract_start_date","contract_end_date","contract_term","contract_type","calc_method","sys_charge_code_st","rate_type","contract_rate","adder1_rate","adder2_rate","agent_commission_rate","contract_comments","holdover_contract","mcp_multiplier","fixed_rate_factor","lock_box","pay_term","cust_bill_type","cust_bill_mode","tax_exempt1","tax_exempt2","tax_exempt3","tax_exempt4","tax_exempt5","tax_exempt6","tax_exempt7","tax_exempt8","credit_id","edi_bill_presenter","deposit_plan","deposit_amount","deposit_pay_type","deposit_aba_nbr","deposit_account_no","deposit_cc_no","deposit_expiry_YYYY","deposit_expiry_MM","deposit_security_code","deposit_pay_amount","Deposit_charge","deposit_acct_type","deposit_card_type","agent_duns","default_contract_id","plan_id_t1","plan_id_t1_rate","plan_id_t1_rateper","plan_id_t2","plan_id_t2_rate","plan_id_t2_rateper","plan_id_t3","plan_id_t3_rate","plan_id_t3_rateper","use_data_from_file","pm_address1","pm_address2","pm_city","pm_state","pm_zip","pm_county","pm_country","pm_duns","pm_meter","pm_multiplier","sysusg1_type","sysusg1_rate","sysusg2_type","sysusg2_rate","sysusg3_type","sysusg3_rate","sysusg4_type","sysusg4_rate","sysusg5_type","sysusg5_rate","sysusg6_type","sysusg7_type","sysusg7_rate","sysusg8_type","sysusg8_rate","bill_msg","priority_code","multi_plan","multi_plan_rate","spouse_email","cust_fax1","use_cust_id","flow_status","CUST_DRL_NBR","CUST_DRL_STATE","CUST_DRL_EXPIRE","CUST_DOB"};
            //string[] Values = { "", "", "", "Web", "", "", "1008901024900682730113", "C1", "5/29/2014 9:00:37 PM", "M", "", "", "ben", "ahmed", "", "789-78-9789", "7897897897", "14700 WOODSON PARK DR #626", "", "", "HOUSTON", "TX", "77044", "", "kashif@itconcepts.com", "", "", "", "N", "N", "P", "PR1402190001", "", "", "10000000116", "", "Y", "", "", "2014-05-29", "2014-05-30", "2015-05-30", "12", "months", "", "", "4", "", "0.02", "", "False", "", "", "1", "", "", "", "Default", "", "", "", "", "", "", "", "", "", "", "DUAL", "", "200", "C", "", "", "", "", "", "", "200", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "N", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "100", "", "TX", "", "07/07/1966" };
           
         
            //if (Columns.Length != Values.Length)
            //{
            //    Console.WriteLine("Something wrong");
            //}
            //else if (Columns.Length == Values.Length)
            //{
            //    Console.WriteLine("all is well.");
            //}

            //System.Collections.Hashtable hash = new System.Collections.Hashtable();
            //for (int i = 0; i < Columns.Length; i++)
            //{
            //    hash.Add(Columns[i], Values[i]);
            //    Console.WriteLine("Key: " + Columns[i] + ", Value: " + Values[i] + " Len: " + Values[i].Length.ToString() );
            //}

            //string s = null;
            //if (s == null)
            //{
            //    Console.WriteLine("hello");
            //}
            //else {
            //    Console.WriteLine("bye");
            //}           

            //string data = "01/01/1966";
            //try
            //{
            //    DateTime dt1 = DateTime.Parse(data);
            //    int  CustomerYear = (dt1 - DateTime.Today).Days / 365 * (-1);
            //}
            //catch (Exception ex) { 

            //}

            //Test t = new Test();
            //T1(t);
            //Console.WriteLine(t.I);

            
            Console.ReadKey();
        }

        public static void T1(Test r)
        {
            r.I = 1;
            r.J = 2;
            r.K = 3;
        }
        public static string GetHash(string data)
        {
            if (data == "") return "";
            MD5 hash = MD5.Create();
            byte[] inputbytes = Encoding.UTF8.GetBytes(data);
            byte[] hashbytes = hash.ComputeHash(inputbytes);

            StringBuilder strHash = new StringBuilder();
            for (int i = 0; i < hashbytes.Length; i++)
            {
                strHash.Append(hashbytes[i].ToString("X2"));
            }
            return strHash.ToString();
        }

        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        public static object s { get; set; }

        public class Test {

            int i, j, k;
            public Test() { 

            }

            public int I { get; set; }
            public int J { get; set; }
            public int K { get; set; }
        }
    }
}
