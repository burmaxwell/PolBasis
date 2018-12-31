using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolBasis
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1001";//1001
            string b = "1010";//1010
            string c = "1011010";//1011010
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            Console.WriteLine(Field.Byte_To_String(Field.Mul(p1,p2)));
            //Console.WriteLine(Field.Byte_To_String(Field.Div_two_polynoms(p3)));
            //Console.WriteLine(Field.Byte_To_String(Field.RemoveHighZeros(p3,43)));
            //Console.WriteLine(Field.Byte_To_String(Field.ShiftBits(p1, 2)));
            //Console.WriteLine(Field.Byte_To_String(Field.Add(p1, p2)));
            Console.ReadKey();
        }
    }
}
