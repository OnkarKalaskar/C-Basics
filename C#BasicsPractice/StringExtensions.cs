using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicsPractice
{
    internal static class StringExtensions
    {
        public static string CapitalizedString(this string str)
        {
            string capitalisedString = "";

            if(str == null)
            {
                return "";
            }

            string[] stringArr = str.Split(new char[] { ' ', '?' });

            foreach(string s in stringArr)
            {
                capitalisedString += s[0].ToString().ToUpper() + s.Substring(1) + " ";
            }

            capitalisedString.Trim();

            return capitalisedString;
        }
    }
}
