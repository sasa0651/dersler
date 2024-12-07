using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birinci = 150000;             //150000 sayısına bir isim atar bundan sonra birinci yazılan değeri 150000 olarak tanır.
            Console.WriteLine(birinci);       //birinci değişkenini ekrana yazdırır.
            Console.WriteLine(int.MinValue);  //int komutunun minumum değerini ekrana yazdırır.
            Console.WriteLine(int.MaxValue);  //int komutunun maximum değerini ekrana yazdırır.
            Console.ReadLine();               //Yazdırma ekranını durdurur kapanmasını önler.
        }
    }
}
