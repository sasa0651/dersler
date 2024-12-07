using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            while (true)
            {
                Console.WriteLine("kullanıcı adı");
                string kullanici = Console.ReadLine();
                Console.WriteLine("şifre");
                string sifre = Console.ReadLine();
                if (kullanici == "admin" && sifre == "1234")
                {
                    Console.WriteLine("giriş yaptınız");
                  
                    break;
                }
                else
                {
                    Console.WriteLine("kullanıcı adı veya şifre yanlış");
                    if (hak > 0)
                    { 
                        hak -= 1; 
                    }
                    if (hak == 0)
                    {
                        Console.WriteLine("giriş hakkınız doldu");
                        break;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
