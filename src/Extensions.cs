using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace processor
{
    internal static class Extensions
    {
        internal static string RemoveComment(string text)
        {
            int idx = text.LastIndexOf("#");
            return idx > 0 ? text[..idx] : text;
        }

        /// <summary>
        /// Removes leading 0x or 1x prefix in hexadecimal instructions, only returning 4 char part
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string RemoveLeading(string text)
        {
            if (text.StartsWith("0x") || text.StartsWith("1x")) 
                return text.Remove(0, 2);
            MessageBox.Show("Error while parsing code:\nHexadecimal CPU instructions must start with \"0x\" and ram write instructions must start with \"1x\"!", "Vole Language Parser");
            return "";
        }

        public static IEnumerable<string> Split2(this string text)
        {
            for (int i = 0; i < text.Length; i += 2)
                yield return text.Substring(i, Math.Min(2, text.Length - i));
        }

        internal static IEnumerable<string> Split4(this string text)
        {
            for (int i = 0; i < text.Length; i += 4)
                yield return text.Substring(i, Math.Min(4, text.Length - i));
        }

        internal static string[] Split1(this string text)
        {
            char[] a = text.ToCharArray();
            string[] r = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                r[i] = a[i].ToString();
            }
            return r;
        }

        internal static double CalculateBinFloat(string bin)
        {
            if (bin.Length is not 8)
                throw new ArgumentOutOfRangeException(nameof(bin), "Binary representation of float value is not an 8-bit string.");
            
            int sign = bin[0] is '1' ? -1 : 1;
            string exponent = new(new[] { bin[1], bin[2], bin[3] });
            int exp = exponent switch
            {
                "000" => -4,
                "001" => -3,
                "010" => -2,
                "011" => -1,
                "100" => 0,
                "101" => 1,
                "110" => 2,
                "111" => 3,
                _ => 0
            };

            string mantissa = new(new[] { '.', bin[4], bin[5], bin[6], bin[7] });
            switch (exp)
            {
                case > 0:
                    mantissa = mantissa.Remove(0, 1).Insert(exp, ".");
                    break;
                case < 0:
                    mantissa = mantissa.Remove(0, 1).Insert(0, Add("0", -1 * exp)).Insert(0, "0.");
                    break;
                default:
                    mantissa = mantissa.Insert(0, "0");
                    break;
            }
            

            string[] parts = mantissa.Split('.');
            double sum = Convert.ToInt32(parts[0], 2);
            for (int i = 0; i < parts[1].Length; i++)
                sum += int.Parse(parts[1][i].ToString()) / Math.Pow(2, i + 1);

            return sign * sum;
        }

        internal static double CalculateHexFloat(string hex)
        {
            if (hex.Length is not 2)
                throw new ArgumentOutOfRangeException(nameof(hex), "Hexadecimal representation of float value is not an 2 character string.");
            return CalculateBinFloat(Convert.ToString(Convert.ToInt32(hex, 16), 2).PadLeft(8, '0'));
        }

        internal static string CnvB10FloatToB2Float(double num)
        {
            string binary = "";
            
            int integral = (int) num;
            double fraction = num - integral;
            
            while (integral > 0)
            {
                int rem = integral % 2;
                binary += (char)(rem + '0'); // a nice trick to append 0 to binary string if rem = 0 and append 1 if rem = 1 
                integral /= 2;
            }

            binary = binary.Reverse(); // somehow we need to reverse the remainder collection to get the actual binary integral part
            
            binary += '.';

            int precision = 2; // don't touch t
            while (precision-- > 0)
            {
                fraction *= 2;
                int fract_bit = (int) fraction;
  
                if (fract_bit == 1)
                {
                    fraction -= fract_bit;
                    binary += (char)(1 + '0');
                }
                else binary += (char)(0 + '0');
                }
  
            return binary;
        }
  
        private static string Reverse(this string text)
        {
            char[] temparray = text.ToCharArray();
            int left, right = 0;
            right = temparray.Length - 1;
  
            for (left = 0; left < right; left++, right--)
                (temparray[left], temparray[right]) = (temparray[right], temparray[left]);

            return string.Join("",temparray);
        }

        internal static int BooleanOr(int left, int right) => left + right >= 1 ? 1 : 0;

        internal static int BooleanAnd(int left, int right) => left + right > 1 ? 1 : 0;

        internal static int BooleanXor(int left, int right)
        {
            if (left + right is > 1 or 0)
                return 0;
            return 1;
        }

        private static string Add(string str, int count = 0)
        {
            for (int i = 1; i < count; i++)
                str = str.Insert(0, str[0].ToString());
            return str;
        }
    }
}
