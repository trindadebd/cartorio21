using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cartorio21
{
    internal class ctrUtil
    {
        public static string RetornarApenasNumeros(string input)
        {
            return Regex.Replace(input, @"[^\d]", "");
        }

        public static string FormatarCPFCNPJ(string input)
        {

            string numeros = Regex.Replace(input, @"[^\d]", "");

            if (numeros.Length == 11)
            {
                return Convert.ToUInt64(numeros).ToString(@"000\.000\.000\-00");
            }
            else if (numeros.Length == 14)
            {
                return Convert.ToUInt64(numeros).ToString(@"00\.000\.000\/0000\-00");
            }
            else
            {
                return input;
            }
        }
    }
}
