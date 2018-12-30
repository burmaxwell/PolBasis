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

        public static int[] Expansion(int[] arr, int size) //расширает массив , добывает нули в старшие разряды(стдвиг влево) 
        {
            int[] extended_array = new int[size];
            for (var i = 0; i < arr.Length; i++)
            {
                extended_array[i] = arr[i];
            }
            return extended_array;
        }

        public static int[] RemoveHighZeros(int[] arr, int dimension)// пока хз как оно должно работать 
        {
            int[] clean_result = new int[dimension-arr.Length];

            return clean_result;
        }

        public static int[] ShiftBits(int[]arr,int ind) // сдвигаем биты для умножения в сторону высших разрядов(сдвиг вправо) 
        {
            int[] result = new int[arr.Length+ind];
            for(int i=0;i<arr.Length;i++)
            {
                result[i+ind] = arr[i];
            }
            return result;
        }

        public static int[] Mul(int[] a, int[] b)
        {
            int[] result = new int[a.Length*2];
            return result;
        }
    }
}
