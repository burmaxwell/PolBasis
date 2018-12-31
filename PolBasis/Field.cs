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
            return RemoveHighZeros(result,maxlenght);
        }

        public static int[] RemoveHighZeros(int[] arr,int dim)
        {            
            int iter = 0;
            var i = dim-1;
            while (arr[i]==0)
            {
                iter++;
                i--;
                if (i == -1) return arr;
            }
            int[] clean_result = new int[arr.Length-iter];
            for (int j=0;j<arr.Length-iter;j++)
            {
                clean_result[j] = arr[j];
            }
            return clean_result;
        }

        public static int[] ShiftBits(int[]arr,int ind) 
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
            string generator = "100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010111";
            int[] generator_arr = new int[1];
            generator_arr = String_To_Byte(generator);
            int[] result = new int[1];
            result = a;
            int len_a = a.Length;
            var maxlenght = Math.Max(a.Length, generator_arr.Length);

            if (a.Length <generator_arr.Length)
            {
                return a;
            }
            else
            {
                int[] temp = new int[1];
                while ( result.Length >= generator_arr.Length)
                { 
                temp = ShiftBits(generator_arr, result.Length - generator_arr.Length);
                result = Add(result, temp);
                }
            }
            return result;
        }

        public static int[] Mul(int[] a, int[] b)
        {
            var maxlenght = Math.Max(a.Length, b.Length);
            Array.Resize(ref a, maxlenght);
            Array.Resize(ref b, maxlenght);

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
