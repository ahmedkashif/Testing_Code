using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    public class Util
    {

        public static double GetFloat(object s, double newValue)
        {
            if (s == null || s == DBNull.Value || s.ToString() == "")
            { return newValue; }

            else
            {

                return double.Parse(s.ToString());
            }
        }

        public static void IsInt(string val)
        {
            try
            {
                int.Parse(val).ToString();
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }

        public static string GetValue(string s)
        {
            if (s == null)
                return "";
            else
                return s;
        }

        public static int ParseStringValueToInteger(string data)
        {
            int output = -1;
            Int32.TryParse(data, out output);
            return output;
        }

        public static int GetInt(object s)
        {
            if (s == null || s == DBNull.Value || s.ToString() == "")
            { return -1; }

            else
            {
                return int.Parse(s.ToString());
            }
        }

        public static int ParsePositiveInt(object data)
        {
            try
            {
                return GetInt(data);
            }
            catch
            {
                return -1;
            }
        }

        public static string ParseDouble(object data, ref double output, ref bool isEmptyData)
        {
            try
            {
                if (data == null || data == DBNull.Value || data.ToString() == "")
                { 
                    output = 0;
                    isEmptyData = true;
                }
                else
                {
                    output = double.Parse(data.ToString());
                }
                return "";
            }
            catch
            {
                return "InValid Data!";
            }
        }
    }
}
