using System;
using System.Collections;

namespace Karakter_Tersten_Yazdırma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("Bir kelime giriniz: ");
                string metin = Console.ReadLine();//Kullanıcıdan kelimemizi alıyoruz.
                
                char[] harfler = metin.ToCharArray();//Daha sonra harflere bölüyoruz.

                ArrayList harf = new ArrayList();//Burası ise bir klon oluşturmak için(Aynı zamanda ArrayList kütüphanesinden faydalanmak için)

                
                harf.AddRange(harfler);//Klonu oluşturduk.

                char ilk = harfler[0];//İlk harfi tespit ettik.
                
                harf.RemoveAt(0);//Daha sonra sildik.

                harf.Add(ilk);//İlk kelimemizi ArrayList içine attık. Yeni bir değişken eklendiğinde otomatik olarak son index elemanı olur.

                foreach (var item in harf)
                {
                    Console.Write(item);//Daha sonra tüm harfleri bitişik olarak yazdırdık. Böylece konsolda bir kelime olarak gözüktü.
                }
                Console.WriteLine();//Alt satıra geçti.
            }//Sonsuz bir döngü olduğu için işlemi farklı kelimeler ile sonsuz denilebilir.

            
        }
    }
}
/*
Verilen string ifade içerisindeki karakterleri bir önceki karakter ile 
yer değiştiren console uygulamasını yazınız.

Örnek: Input: Merhaba Hello Question

Output: erhabaM elloH uestionQ
*/