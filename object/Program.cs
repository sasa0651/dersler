using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = '?';
            object b = "şükrü";
            object c = 32000;
            object d = 10 < 5;
            object e = 14.32;
            object f = -235000;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.ReadLine();               //Yazdırma ekranını durdurur kapanmasını önler.

        }
    }
}
