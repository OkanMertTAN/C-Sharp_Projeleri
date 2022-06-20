using System;
using System.Collections;

namespace Algoritma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Matematik matematik = new Matematik();
                Konsol konsol = new Konsol();
                konsol.IlkMesaj();
                matematik.Islem();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Lütfen geçerli değerler giriniz !!!!");
            }
            
            
            
        }
    }
}
/*
Ekrandan bir string bir de sayı alan (aralarında virgül ile), 
ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran 
console uygulasını yazınız.

Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

Output: Algritma Algortma Algoritma lgoritma
*/