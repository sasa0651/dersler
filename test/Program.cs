using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("merhaba boy kilo endeksinizi hesaplayalım");
            Console.WriteLine("boyunuzu giriniz");
            Double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            double ke = kilo / (boy * boy);
            Console.WriteLine("vücut kitle endeksiniz :"+ ke);
      
            if (ke > 25)
            {
                Console.WriteLine("obezsiniz");
                Console.ReadLine();
            }
            else if (ke < 25 && ke > 20)
            {
                Console.WriteLine("normalsiniz");
                Console.ReadLine();
            }
            else if (ke < 20)
            { 
                Console.WriteLine("zayıfsınız");
                Console.ReadLine();
            }
        }
    }
}
