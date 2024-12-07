using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sınav 1 puanını giriniz");  //metni ekrana yazdırdık.
            string not1 = Console.ReadLine();      //ekranı beklettik.
            Console.WriteLine("sınav 2 puanını giriniz");  //metni ekrana yazdırdık.
            string not2 = Console.ReadLine();      //ekranı beklettik.
            Console.WriteLine("sınav 3 puanını giriniz");  //metni ekrana yazdırdık.
            string not3 = Console.ReadLine();      //ekranı beklettik.

            Console.WriteLine("sınav 1 puanı : " + not1);  //metni ekrana yazdırdık ve yanına ekranda yazacağımız metni koyacak.
            Console.WriteLine("sınav 2 puanı : " + not2); //metni ekrana yazdırdık ve yanına ekranda yazacağımız metni koyacak.
            Console.WriteLine("sınav 3 puanı : " + not3); //metni ekrana yazdırdık ve yanına ekranda yazacağımız metni koyacak.
         
            Console.ReadLine();                    //ekranı beklettik.
            int a = int.Parse(not1);   //string ten int a tür değiştirdik işlem yapabilmek için.
            int b = int.Parse(not2);
            int c = int.Parse(not3);

            int sonuc=(a+b+c)/3;
            Console.WriteLine("ortalama puanı :" + sonuc);
            Console.ReadLine();
            if (sonuc >= 50)
            {
                Console.WriteLine("geçti :"+sonuc);
                Console.ReadLine();
            }
            if (sonuc <= 49)
            {
                Console.WriteLine("kaldı :"+sonuc); 
                Console.ReadLine();
            }
        }
    }
}
