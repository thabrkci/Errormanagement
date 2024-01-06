using System;

namespace Errormanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı girmesini isteyen ve girilen sayıyı ekrana yazdıran kod bloğu
            // Ancak bu kısımda hata olup olmadığını kontrol etmek için try-catch-finally bloğu kullanılmamış.

            //try
            //{
            //    Console.WriteLine("Bir sayi giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayi:" + sayi);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Hata:" + ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("İşlem tamamlandı");
            //}

            // Hata yönetimi için try-catch bloğu kullanılmış.
            try
            {
                // Hata alması muhtemel bir kod parçası
                // int a = int.Parse("test"); // Bu satır, FormatException'a neden olur.
                int a = int.Parse("-2000000000");
            }
            // ArgumentNullException, FormatException ve OverflowException türündeki hataların her biri için ayrı catch bloğu kullanılmış.
            catch (ArgumentNullException kex)
            {
                // Boş değer girildiğinde bu blok çalışır.
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(kex); // Hatanın ayrıntılarını yazdırır.
            }
            catch (FormatException kex)
            {
                // Geçersiz bir formatta veri girildiğinde bu blok çalışır.
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(kex); // Hatanın ayrıntılarını yazdırır.
            }
            catch (OverflowException kex)
            {
                // Büyük veya küçük bir değer girildiğinde bu blok çalışır.
                Console.WriteLine("Büyük yada küçük değer girdiniz");
                Console.WriteLine(kex); // Hatanın ayrıntılarını yazdırır.
            }
        }
    }
}
