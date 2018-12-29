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
            string a = "011";
            string b = "101";
            int[] p1 = new int[1];
            int[] p2 = new int[1];
            p1 = Field.String_To_Byte(a);
            p2 = Field.String_To_Byte(b);
            Console.WriteLine(Field.Add(p1, p2));
            Console.ReadKey();
        }
    }
}
