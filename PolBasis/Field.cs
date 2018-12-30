using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolBasis
{
    class Field
    { 

        public static int[] String_To_Byte(string polynom)
        {

            var bitlenth = polynom.Length;
            int [] number = new int[bitlenth];

            for (var i = 0; i < bitlenth; i++)
            {
                number[i] = Convert.ToByte(polynom.Substring(polynom.Length - (i + 1), 1), 2);
            }

            return number;

        }

        public static string Byte_To_String(int[] polynom)
        {
            StringBuilder stringline = new StringBuilder();
            for (int i = polynom.Length-1; i >=0; i--)
            {
                stringline.Append(Convert.ToString(polynom[i], 2));
            }
            return stringline.ToString();
        }


        public static int[] Add(int[]a,int[]b)
        {
            var maxlenght = Math.Max(a.Length, b.Length);
            Array.Resize(ref a, maxlenght);
            Array.Resize(ref b, maxlenght);
            int[] result = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = (a[i] ^ b[i]);

            }
            return result;
        }
    }
}
