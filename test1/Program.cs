using System;
using System.Diagnostics.Eventing.Reader;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Random rastgele = new Random();
                int sayi = rastgele.Next(100);
                Console.WriteLine(sayi);
              
               // int a = Convert.ToInt32(Console.ReadLine());
                string b = "çift rakam";
                string c = "tek rakam";
                if (sayi %2==0)
                {    
                    Console.WriteLine(b);
                    Console.ReadLine();
                }
                else
                {     
                    Console.WriteLine(c);
                    Console.ReadLine();
                }
            }
        }
    }
}