using System.Reflection;

namespace Hata_Yönetimi;

class Program
{
    static void Main(string[] args)
    {
       //try//bu kısımda hata olup olmadığını alabilmek adına yazacağımız kod yazma bölümü(Kodu güvence altına almak için).
       //{
       //    Console.WriteLine("Bir sayi giriniz");
       //int sayi = Convert.ToInt32(Console.ReadLine());
       //    Console.WriteLine("Girmiş olduğunuz sayi:" +sayi);

       //}
       //catch(Exception ex)//bu kısımda hatayı yakaladığında ne yapılsın hangi mesaj verilsin kısmı?
       //{
       //    Console.WriteLine("Hata:" +ex.Message.ToString());

       //}
       //finally//bu kısımda hata alındıktan sonra ne yapılsın ?(zorunlu değil).
       //{
       //    Console.WriteLine("İşlem tamamland");
       //
       //}
        
        try
        {
           // int a = int.Parse("test");
              int a = int.Parse("-2000000000");
        }
        catch (ArgumentNullException kex)

        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(kex);
        }
           // catch(FormatException kex)
           // {
           //        Console.WriteLine("Veri tipi uygun değil");
           //        Console.WriteLine(kex);
           // }
           catch(OverflowException kex)
            {
                Console.WriteLine("Büyük yada küçük değer girdiniz");
                Console.WriteLine(kex);
            }

    }
}
