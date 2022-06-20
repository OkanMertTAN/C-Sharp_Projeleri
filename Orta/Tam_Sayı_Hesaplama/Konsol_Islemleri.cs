using System;

namespace Tam_Sayı_Hesaplama
{
    public class Konsol_Islemleri
    {
        public void Menü()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("İkili Tam Sayı Hesaplama");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Konsola girilen iki sayı : ");
            Console.WriteLine("Birbirinden farklı ise toplanır,");
            Console.WriteLine("Aynı ise o sayının karesi alınır.");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Kaç tane ikili sayı istersininz = ");
            
        }
        public void KaresiKonsolaGösterme(int value)
        {
           Console.WriteLine("-------------------------");
           Console.WriteLine("Konsole girdiğiniz değerler birbirinin aynısıdır.");
           Console.WriteLine("Bu yüzden sayını karesi : "+value); 
           Console.WriteLine("-------------------------");
        }
        public void ToplamıKonsolaGösterme(int value)
        {
           Console.WriteLine("-------------------------"); 
           Console.WriteLine("Konsole girdiğiniz değerler birbirininden farklıdır.");
           Console.WriteLine("Bu yüzden sayını toplamı : "+ value); 
           Console.WriteLine("-------------------------");
        }
        public void DevamEtmek()
        {
            Console.WriteLine("Devam Etmek İçin Herhangibi Butona Tuslayıp,Entere Basınız.");
            Console.ReadLine();
        }
    }
}