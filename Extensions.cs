using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processor
{
    internal static class Extensions
    {
        internal static string RemoveComment(string text)
        {
            int idx = text.LastIndexOf("#");
            return idx > 0 ? text.Substring(0, idx) : text;
        }

        /// <summary>
        /// Removes leading 0x prefix in hexadecimal instructions, only returning 4 char part
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string RemoveLeading(string text)
        {
            if (text.Contains("0x")) return text.Remove(0, 2);
            MessageBox.Show("Error while parsing code:\nHexadecimal instruction codes must start with \"0x\"!", "Vole Language Parser");
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

        internal static string ToBin(this int value) => Convert.ToString(value, 2).PadLeft(8, '0');

        internal static string ToHex(this int value) => Convert.ToString(value, 16);

        internal static string ToHex2(this int value) => value.ToHex().PadLeft(2, '0');

        internal static int Hex2Int(this string value) => Convert.ToInt32(value, 8);
    }
}
