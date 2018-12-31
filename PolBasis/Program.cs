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
            string a = "01111111000011111010000010111011010000011111110011000011100100101011100111011101111010001110110101101000011101001010010001010100010010001110100101110000001110000001100101000011011";//1001
            string b = "00100100110100001111101111011010000010001001100011110100111011011100010110111110011010011110111100110110101100100010000101111011000110011000001110010010000111000101111010110111100";//1010
            string c = "00000100010011000011001100111100010001110011100010010110111101001011010101011111111101101001011111010001011110001001110001111100000111100111011100101001110101000101100101111100011";//1011010
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            Console.WriteLine(b);
            //Console.WriteLine(Field.Byte_To_String(Field.Trace(p1)));
            //Console.WriteLine(Field.Byte_To_String(Field.Trace(p2)));
            Console.WriteLine(Field.Byte_To_String(Field.BigPower(p1,p3)));
            //Console.WriteLine(Field.Byte_To_String(Field.Mul(p1,p2)));
            //Console.WriteLine(Field.Byte_To_String(Field.Div_two_polynoms(p3)));
            //Console.WriteLine(Field.Byte_To_String(Field.RemoveHighZeros(p3,43)));
            //Console.WriteLine(Field.Byte_To_String(Field.ShiftBits(p1, 2)));
            //Console.WriteLine(Field.Byte_To_String(Field.Add(p1, p2)));
            Console.ReadKey();
        }
    }
}
