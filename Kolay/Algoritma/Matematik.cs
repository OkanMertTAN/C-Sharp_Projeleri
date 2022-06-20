using System;
using System.Collections;

namespace Algoritma
{
    public class Matematik
    {
        public void Islem()
        {
            int intput = int.Parse(Console.ReadLine());
            ArrayList kelimeler = new ArrayList();
            
            for (var i = 0; i < intput; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz : ",i+1);
                string kelime = Console.ReadLine();
                Console.WriteLine("{0}. kelimenin silmek istediğiniz karakterinin (sol baştan sayarak) numarasını yazınız  : ",i+1);
                int sayı = int.Parse(Console.ReadLine());
                
                Console.WriteLine("{0}. kelimenin '{1}' yeni hali  ",i+1,kelime.Remove(sayı-1,1));
                Console.WriteLine("*****************************");
            }
            
        }
    }
}