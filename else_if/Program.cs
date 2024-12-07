using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci notunuzu giriniz");   //ekrana metin yazdırdık.
            int not1 = Convert.ToInt32(Console.ReadLine());  //not1 e girilen değeri int e çevirdik.
            Console.WriteLine("ikinci notunuzu giriniz");   //ekrana metin yazdırdık.
            int not2 = Convert.ToInt32(Console.ReadLine());  //not2 e girilen değeri int e çevirdik.
            Console.WriteLine("üçüncü notunuzu giriniz");   //ekrana metin yazdırdık.
            int not3 = Convert.ToInt32(Console.ReadLine());  //not3 e girilen değeri int e çevirdik.

            int sonuc = (not1 + not2 + not3) / 3;
            Console.WriteLine("ortalama notunuz :" + sonuc);   //ekrana metin yazdırdık
            Console.ReadLine();

            if (sonuc <= 100 && sonuc >= 80)
            {
                Console.WriteLine("A+ başarılı");
                Console.ReadLine();
            }
            else if (sonuc < 80 && sonuc >= 60)
            { 
                Console.WriteLine("B+ orta başarılı");
                Console.ReadLine();
            }
            else if (sonuc < 60 && sonuc >= 40)
            {
                Console.WriteLine("C+ Başarısız");
                Console.ReadLine();
            }
            else if (sonuc >100)
            {
               Console.WriteLine("geçersiz not girildi");
               Console.ReadLine();
            }
            else
            {
                Console.WriteLine("F Sınıfta Kaldı");
                Console.ReadLine();
            }
        }
    }
}
