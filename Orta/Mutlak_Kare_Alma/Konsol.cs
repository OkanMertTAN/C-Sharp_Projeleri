using System;

namespace Mutlak_Kare_Alma
{
    public class Konsol
    {
        public void IlkMesaj()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("--- Mutlak Kare Alma Sistemi ---");
            Console.WriteLine("Konsola girilen sayıların eğer ki 67'den küçük ise farklarının toplamı alınacak,"+
            "67'den büyük ise farklarının mutlak değeri alınıp toplama işlemi yapılacaktır.");
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
        public void DevamveyaDurmak()
        {
            Console.WriteLine("İşleme Devam Etmek İsterseniz. '1' ,  Devam Etmek İstemiyorsanız '0' tuşlayın.");
        } 
        public void MutlakDegerIslemiMesaji(int value)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("{0} adet girmiş olduğunuz sayıları mutlak değer alma işlemi yapılacaktır.67'den küçük olanlar farklarının"+
            "toplamı,67'den buyük olanları farkların mutlak değerleri toplama işlemi yapılacaktır.",value);
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
        public void Sonuc(int value1,int value2)
        {
            Console.WriteLine("Büyüksayıların İşlem Sonucu {0} ,"+
            "Küçüksayıların İşlem Sonucu {1} ",value1,value2);
        }
    }    
}