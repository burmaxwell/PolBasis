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

        public static int[] LenghtControl(int[]a)
        {
            if (a.Length < 178)
            {
                Array.Resize(ref a, 179);
            }
            return a;
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
            return LenghtControl( result);
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

        public static int [] Square (int[] a)
        {
            int[] A = new int[2*a.Length];
            int[] result = new int[1];
            for(int i=0;i<a.Length;i++)
            {
                A[2 * i] = a[i];
            }
            result =Div_two_polynoms(A);
            return result;
        } 
        
        public static int[] Trace(int[]a)
        {
            int[] result = new int[1];
            int[] temp = new int[1];
            result = a;
            temp = a;
            for(int i=1;i<179;i++)
            {
                temp = Square(temp);
                result =Add(result, temp);
            }
            result = Div_two_polynoms(result);
            return result;
        }
          
        public static int[] BigPower(int [] a, int [] n)
        {
            string One = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001";
            int[] result = new int[a.Length];
            result = String_To_Byte(One);
            for(int i=0;i<a.Length;i++)
            {
                if(n[i]==1)
                {
                    result = Mul(result, a);
                }
                a = Square(a);
            }
            return result;
        }

         public static int[] Inverse_el(int[]a)
          {
              string One = "000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001";
              int[] inversed = new int[a.Length];
              int[] temp = new int[a.Length];
              int[] n = new int[a.Length];
              n = String_To_Byte(One);
              inversed = String_To_Byte(One);
              temp = BigPower(a, n);

              for(int i=1;i<a.Length;i++)
              {
                  inversed = Mul(inversed, temp);
                  temp = Square(temp);
              }
              inversed = Square(inversed);
              return inversed;
          }
          


        // :(
        
        /*public static int[] Inverse_el(int[] a) //
        {
            int[] lambda = new int[a.Length];
            int[] inversed = new int[a.Length];

            lambda[0] = 0;
            for(int i=1;i<a.Length;i++)
            {
                lambda[i] = 1;
            }

            inversed=BigPower (a, lambda);
            return inversed;
        }*/

        public static int[] Check_abc(int[]a, int[]b, int[]c)
        {
            int[] One = new int[1];
            One[0] = 1;
            int[] Zero = new int[1];
            Zero[0] = 1;
            int[] ans1 = new int[a.Length];
            int[] ans2 = new int[a.Length];
            ans1 = Mul(c, Add(a, b));
            ans2 = Add(Mul(c, a), Mul(c, b));
            if (ans1 == ans2) return One;
            else return Zero;
        }
        
    }
}
