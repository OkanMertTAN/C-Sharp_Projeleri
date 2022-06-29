using System;

namespace Karakter_Degistirme
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Konsol konsol = new Konsol();
            konsol.IlkMesaj();
            matematik.Islem2();
            //İşlem sıralaması Konsol>Matematik dosyaşarı şeklinde sıralanmıştır.
        }
    }
}
/*
Verilen string ifade içerisindeki ilk ve son karakterin yerini 
değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

Örnek: Input: Merhaba Hello Algoritma x

Output: aerhabM oellH algoritmA x
*/