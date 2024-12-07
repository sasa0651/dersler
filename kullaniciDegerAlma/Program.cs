using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullaniciDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adınızı giriniz");  //metni ekrana yazdırdık.
            string isim = Console.ReadLine();      //ekranı beklettik.

            Console.WriteLine("soyisim giriniz");  //metni ekrana yazdırdık.
            string soyisim = Console.ReadLine();   //ekranı beklettik.

            Console.WriteLine("kullanıcı ismi : "+ isim);  //metni ekrana yazdırdık ve yanına ekranda yazacağımız metni koyacak.
            Console.WriteLine("kullanıcı soyismi : "+ soyisim); //metni ekrana yazdırdık ve yanına ekranda yazacağımız metni koyacak.
            Console.ReadLine();                    //ekranı beklettik.

        }
    }
}
