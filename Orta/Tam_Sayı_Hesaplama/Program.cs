using System;

namespace Tam_Sayı_Hesaplama
{
    public class Program
    {
        public static void Main()
        {
            Konsol_Islemleri konsol =new Konsol_Islemleri();
            Hesaplama hesaplama = new Hesaplama();
            
            
            hesaplama.Islemler1();
        }
        
    }
}
/*Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden 
farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran 
console uygulamasını yazınız.

Örnek Input: 2 3 1 5 2 5 3 3

Output: 5 6 7 81
*/