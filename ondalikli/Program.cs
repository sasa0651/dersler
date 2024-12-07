using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ondalikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float 7 basamağa kadar kullanılır.
            // double 15 basamağa kadar kullanılır.
            float ondalikli_sayi1 = 35.56f; //varsayılan double olarak tanıdığı için biz float olduğunu belirtmek için sonuna f koyduk.
            float ondalikli_sayi2 = 12.5f;  //varsayılan double olarak tanıdığı için biz float olduğunu belirtmek için sonuna f koyduk.
            double ondalikli_sayi3 = 351.56;//double 15 basamağa kadar ondalıklı sayılarda kullanılır.
            char karakter = '?';    //tek tırnak arasına yazılır.tek karakter harf yada sayı yazdırır.
            string isim = "Enes";   //çift tırnak içinde yazılır.
            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);
            Console.WriteLine(ondalikli_sayi3);
            Console.WriteLine(karakter); //ekrana karakter değişkeninin karakterini yazar.
            Console.WriteLine(isim);     //ekrana isim değişkeninin metnini yazar.
            Console.ReadLine();

        }
    }
}
