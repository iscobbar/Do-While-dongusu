using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1-100 arasındaki sayıları yazdıran do-while döngüsü
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i <= 100);


            // Kullanıcı adı ve parolası doğru olana kadar klavyeden isteyen program:
            string kadi = "smartpro";
            string parola = "123456";

            string gir_kadi;
            string gir_parola;
            do
            {
                Console.Write("Kullanıcı adı giriniz:");
                gir_kadi = Console.ReadLine();

                Console.Write("Parola giriniz:");
                gir_parola = Console.ReadLine();

                if (kadi != gir_kadi || parola != gir_parola)
                {
                    Console.WriteLine("Hatalı Giriş! Tekrar Deneyiniz!");
                }
            } while (kadi != gir_kadi || parola != gir_parola);

            Console.WriteLine("Başarılı Giriş!");


            // 1-100 arasında rastgele üretilen sayıyı bulma oyunu:
            // 7 tahmin hakkı olsun.
            // Her tahminde ipuçu olarak: Daha küçük veya daha büyük giriniz desin.

            Random rastgele = new Random();
            byte rastSayi = (byte)rastgele.Next(1, 101);
            byte tahmin, sayac = 1;
            do
            {
                Console.Write("Tahminiz: ");
                tahmin = Convert.ToByte(Console.ReadLine());
                if (tahmin == rastSayi)
                {
                    Console.WriteLine("Tebrikler Bildiniz!");
                }
                else
                {
                    if (tahmin > rastSayi)
                    {
                        Console.WriteLine("Azalt");
                    }
                    else
                    {
                        Console.WriteLine("Büyüt");
                    }
                }

                sayac++;

                if (sayac > 7)
                {
                    Console.WriteLine("Başka Deneme Hakkınız Kalmadı!!!");
                }


            } while (tahmin != rastSayi && sayac < 8);

            Console.Read();
        }
    }
}