using System;
using System.Diagnostics.Eventing.Reader;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            while (true) // Sonsuz döngü
            {
                Console.Clear(); // Ekranı temizler
                Console.WriteLine("ATM ye Hoşgeldiniz");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("1 : Bakiye Görme");
                Console.WriteLine("2 : Para Çekme");
                Console.WriteLine("3 : Para Yatırma");
                Console.WriteLine("4 : Para Gönderme");
                Console.WriteLine("5 : Çıkış");

                string secim = Console.ReadLine();
                switch (secim)
                {

                    case "1":
                        Console.WriteLine("Bakiyeniz: " + bakiye);
                        Console.ReadLine();
                        break;


                    case "2":

                        Console.WriteLine("Çekilecek tutarı giriniz:");
                        int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                        if (cekilecek_tutar <= bakiye)

                        {
                            bakiye -= cekilecek_tutar;
                            Console.WriteLine("Kalan bakiye: " + bakiye);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        break;


                    case "3":

                        Console.WriteLine("Yatırılacak tutarı giriniz:");
                        int yatan = Convert.ToInt32(Console.ReadLine());
                        if (yatan <= 10000)
                        {
                            bakiye += yatan;
                            Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Yatırdığınız tutar çok fazla. En fazla 10000 TL yatırabilirsiniz.");
                        }
                        break;

                    case "4":

                        int ahmet = 123456;
                        int mehmet = 654321;
                        int sukru = 135790;

                        Console.WriteLine("Kime para göndereceksiniz:");
                        Console.WriteLine("Lütfen IBAN Giriniz:");
                        Console.WriteLine("kayıtlı kişiler ");
                        Console.WriteLine("ahmet = 123456 , mehmet = 654321 , şükrü = 135790");
                        int IBAN = Convert.ToInt32(Console.ReadLine());

                        if (IBAN == sukru)
                        {
                            Console.WriteLine("Gönderilecek tutarı giriniz:");
                            int gonderilen = Convert.ToInt32(Console.ReadLine());
                            if (gonderilen <= bakiye)
                            {
                                bakiye -= gonderilen;
                                Console.WriteLine(IBAN + " şükrü kişisine " + gonderilen + " TL gönderildi.");
                                Console.WriteLine("Yeni bakiye: " + bakiye);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Bakiyeniz yetersiz.");
                                Console.ReadLine();
                            }
                        }
                        else if (IBAN == mehmet)
                        {
                            Console.WriteLine("Gönderilecek tutarı giriniz:");
                            int gonderilen1 = Convert.ToInt32(Console.ReadLine());
                            if (gonderilen1 <= bakiye)
                            {
                                bakiye -= gonderilen1;
                                Console.WriteLine(IBAN + " mehmet kişisine " + gonderilen1 + " TL gönderildi.");
                                Console.WriteLine("Yeni bakiye: " + bakiye);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Bakiyeniz yetersiz.");
                                Console.ReadLine();
                            }
                        }
                        else if (IBAN == ahmet)
                        {
                            Console.WriteLine("Gönderilecek tutarı giriniz:");
                            int gonderilen1 = Convert.ToInt32(Console.ReadLine());
                            if (gonderilen1 <= bakiye)
                            {
                                bakiye -= gonderilen1;
                                Console.WriteLine(IBAN + " ahmet kişisine " + gonderilen1 + " TL gönderildi.");
                                Console.WriteLine("Yeni bakiye: " + bakiye);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Bakiyeniz yetersiz.");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı iban");
                            Console.ReadLine();
                        }

                        break;



                    case "5":

                        Console.WriteLine("Hoşçakalın.");
                        Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Geçerli bir değer giriniz.");
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}