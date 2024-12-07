using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("-"+i);  //Write konsolda yan yana yazmaya yarar. WriteLine ise alt alta
            }
            Console.ReadLine();
        }
    }
}
