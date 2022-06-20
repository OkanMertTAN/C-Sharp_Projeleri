using System;
using System.Collections;

namespace Tam_Sayı_Hesaplama
{
    class Hesaplama
    {
        public void Islemler1()
        {
            konsol.Menü();
            int intput = int.Parse(Console.ReadLine());
            ArrayList sayılar = new ArrayList();

            for (var i = 0; i < intput; i++)
            {
                Console.WriteLine("{0}. sayıları (iki adet) giriniz ",i+1);
                var ikilisayı = Console.ReadLine().Split(" ");
                
                if (ikilisayı[0] != ikilisayı[1])
                {
                    int sayı = Convert.ToInt32(ikilisayı[0])+Convert.ToInt32(ikilisayı[1]);
                    sayılar.Add(sayı);
                }
                else
                {
                    int sayı = Convert.ToInt32(ikilisayı[0])+Convert.ToInt32(ikilisayı[1]);
                    sayılar.Add(sayı*sayı);
                }
            }
                foreach (var item in sayılar)
                {
                    Console.WriteLine(item);
                }
        }
        Konsol_Islemleri konsol = new Konsol_Islemleri();
    }
}