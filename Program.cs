using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void mrk(int n)
        {
            if (n < 1) return;
            Console.Write("{0}, ", n);
            mrk(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nN = {0} -> ", n);
            mrk(n);

            Console.ReadKey();
        }
    }
}
