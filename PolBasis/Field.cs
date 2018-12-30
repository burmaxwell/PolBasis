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

        public static int[] Expansion(int[] arr, int size) //расширает массив , добывает нули в старшие разряды 
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
            int[] clean_result = new int[dimension-arr.Length] ;

            return clean_result;
        }

        public static int[] ShiftBits(int[]arr,int ind) // сдвигаем биты для умножения в сторону высших разрядов
        {
            int[] result = new int[arr.Length+ind];
            for(int i=0;i<arr.Length;i++)
            {
                result[i+ind] = arr[i];
            }
            return result;
        }

        public static int[] Div_two_polynoms(int[]a)
        {
            //string generator = "10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010111";
            string generator = "1011";
            int[] generator_arr = new int[1];
            int[] rest = new int[1];
            int[] temp = new int[1];
            generator_arr = String_To_Byte(generator);

            if (a.Length<generator_arr.Length)
            {
                return a;
            }
            else
            {
                temp = ShiftBits(generator_arr, a.Length - generator_arr.Length);
                rest = Add(a, temp);
            }
            return rest;
        }

        public static int[] Mul(int[] a, int[] b)
        {
            int[] temp = new int[1];
            int[] result = new int[1];
            for(int i=0;i<a.Length;i++)
            {
                if (b[i]==1)
                {
                    temp = ShiftBits(a, i);
                    result = Add(result, temp);
                }
            }
            result = Div_two_polynoms(result);

            return result;
        }
    }
}
