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
            string a = "10110010001101110100010110001100011000110001110001011001101111111000010100001001101011100111010000010000111011001110100000101010001100011001110010111001010100011010100110010001100";//1001
            string b = "01000110100011011000110000010100010011000000000010011100010110111001000100100000111110010101100110000111110110011001000111100100001101001101010101001011011000100010101101110100011";//1010
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
