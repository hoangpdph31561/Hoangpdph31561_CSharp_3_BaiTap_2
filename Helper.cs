using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hoangpdph31561_CSharp_3_BaiTap_2
{
    internal static class Helper
    {
        public static bool CheckTextExist(string input)
        {
            if (input == null || input.Trim().Length == 0) return true;
            return false;
        }
        public static bool CheckRegex(string input, string regex)
        {
            if (!Regex.IsMatch(input, regex)) return true;
            return false;
        }
    }
}
