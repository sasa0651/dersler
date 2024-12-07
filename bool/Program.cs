using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = false; //yanlış demek
            bool kontrol2 = true; //doğru demek

            bool sonuc = 4 < 8; //işlemi yazıyoruz.
            bool sonuc2 = 10 < 6; //ikinci işlemi yazıyoruz.

            Console.WriteLine(sonuc);  //sonuc işleminin sonucu doğru yani ekranda true yazacak.
            Console.WriteLine(sonuc2); //sonuc2 işleminin sonucu yanlış yani ekranda false yazacak.
            Console.ReadLine();  //ekranı kapatmaz sabit tutar.

        }
    }
}
