using System;
//Ortalama Hesaplama(Mod Alma)
namespace Proje_1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Ortalama Hesaplama****");
            try
            {
            Console.WriteLine("Girmek istediğiniz sayı adeti yazınız : ");
            int index = int.Parse(Console.ReadLine());
            int[] sayiadeti = new int[index];
            
            Console.Clear();

            System.Console.WriteLine("Lütfen Girmek İstediğiniz Sayıları Giriniz");
            int top = 0;
            for (int i = 0; i < index; i++)
            {
                System.Console.WriteLine("{0}. Sayıyı Giriniz : ",i);
                sayiadeti[i] = int.Parse(Console.ReadLine()); 
                top += sayiadeti[i] ;
            }

            int ortalama = top/index;
            System.Console.WriteLine("Girmiş Oduğunuz Sayıların Ortalaması : "+ortalama);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Lütfen Sayısal Bir Değer Giriniz !!!!!");
            }
        }
        
    }
    
    
}
