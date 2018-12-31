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
            string a = "00000111100011100100111110000110011011010010110010110011011010011011100011000110011111010001010110011110110100011001000000010100110010110111011100110110100000100100000011010110111";//1001
            string b = "11100010110010101111111110001111111100011101011111110000001011100010100011000101010010100110011011000110010001110111001110001010100100100010101110110101010110100111110110000000001";//1010
            string c = "11110110100110110010101100101111000111000001000111000111011011100101011010100011001110001010100110000110100111010010011011101001010101010110010011000001011100101000110011101010100";//1011010
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            int[] p3 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            p3 = Field.String_To_Byte(c);
            //Console.WriteLine(b);
            //Console.WriteLine(Field.Byte_To_String(Field.Trace(p1)));
            //Console.WriteLine(Field.Byte_To_String(Field.Trace(p2)));
            Console.WriteLine(Field.Byte_To_String(Field.Check_abc(p1,p2,p3)));
            //Console.WriteLine(Field.Byte_To_String(Field.Mul(p1,p2)));
            //Console.WriteLine(Field.Byte_To_String(Field.Div_two_polynoms(p3)));
            //Console.WriteLine(Field.Byte_To_String(Field.RemoveHighZeros(p3,43)));
            //Console.WriteLine(Field.Byte_To_String(Field.ShiftBits(p1, 2)));
            //Console.WriteLine(Field.Byte_To_String(Field.Add(p1, p2)));
            Console.ReadKey();
        }
    }
}
