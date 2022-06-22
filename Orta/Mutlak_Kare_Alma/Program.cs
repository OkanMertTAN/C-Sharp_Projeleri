using System;

namespace Mutlak_Kare_Alma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Konsol konsol =new Konsol();
            konsol.IlkMesaj();
            matematik.Islem();
        }
    }
}
/*Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna tespit edebilen. Küçük olanların farklarının toplamını,
büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

Örnek: Input: 56 45 68 77

Output: 33 101
*/