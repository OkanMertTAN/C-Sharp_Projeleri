using System;

namespace Proje_3 
{
    class Program //Üçgen Çizimi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen Çizme Sistemi");
            Console.WriteLine("Lütfen üçgenin kaç boyutlu (sayısal bir değer) yapmak istediğinizi yazınız : ");

            try
            {
                int sayac = int.Parse(Console.ReadLine());//Üçgenin kaç boyutlu olduğunu giriyoruz.

            for (int i = 0; i < sayac; i++)//Döngüler yardımıyla üçgen oluşturyoruz. 
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            }
            catch (System.Exception)//Eğer ki int bir değer girilmezse konsola mesaj yazdırır.
            {
                System.Console.WriteLine("Lütfen sayısal bir değer giriniz!!!!");
            }
           Console.ReadKey();
        }
    }
}