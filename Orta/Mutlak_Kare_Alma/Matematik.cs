using System;
using System.Collections;
using System.Collections.Generic;

namespace Mutlak_Kare_Alma
{
    public class Matematik
    {
        Konsol konsol =new Konsol();
        public void Islem()
        {
            for ( ; ; )
            {
                ArrayList sayılar = new ArrayList();
                ArrayList küçüksayılar = new ArrayList();
                ArrayList büyüksayılar = new ArrayList();
                int sayı ;

                
                bool döngü = true;
                int sayaç = 0;
                int sayılarkapasite = 0;
                Console.WriteLine("En fazla 4 tane sayı giriniz : ");
                while (döngü)
                {
                    Console.WriteLine("{0}. sayıyı giriniz :  ",sayaç+1);
                    sayı = int.Parse(Console.ReadLine());
                    sayılar.Add(sayı);
                    sayaç++;
                    if (sayaç==4)
                    {
                        konsol.DevamveyaDurmak();
                        Console.WriteLine("Eklem İşlemine");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a==0)
                        {
                            break;
                        }
                        else
                        {
                           Console.WriteLine("İşlem devam ediyor."); 
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        foreach (var item in sayılar)
                        {
                            Console.WriteLine(item);
                            sayılarkapasite++;
                        }
                        Console.WriteLine("Mevcut girmiş olduğunuz sayı miktarı {0}",sayılarkapasite);
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                    }
                }
                
                sayılar.Sort();
                    
                Console.Clear();

                konsol.MutlakDegerIslemiMesaji(sayılarkapasite);
                foreach (int item in sayılar)
                {
                    if (item<=67)
                    {
                        küçüksayılar.Add(item);
                    }
                    else
                    {
                        büyüksayılar.Add(item);
                    }
                }
                
                küçüksayılar.Sort();
                büyüksayılar.Sort();
                int[] küçükfarkı = new int[küçüksayılar.Count];
                int küçüksayıfarktoplamı = 0;
                int[] büyükfarkı = new int[büyüksayılar.Count];
                int büyüksayıkaresitoplamı = 0;
                int ü = 0;
                foreach (int item in küçüksayılar)
                {
                    küçükfarkı[ü] = 67-item;
                    ü++;
                }
                for (var i = 0; i <küçüksayılar.Count ; i++)
                {
                    küçüksayıfarktoplamı += küçükfarkı[i];
                }


                int p = 0;
                foreach (int item in büyüksayılar)
                {
                    büyükfarkı[p] = item-67;
                    p++;
                }
                int[] büyüklerinkaresi = new int[100]; 
                for (var i = 0; i < büyüksayılar.Count; i++)
                {
                    büyüklerinkaresi[i] =  (büyükfarkı[i])^2;
                }
                for (var i = 0; i < büyüksayılar.Count; i++)
                {
                    büyüksayıkaresitoplamı += büyüklerinkaresi[i];
                }
                Console.Clear();
                Console.WriteLine("---------------------------");
                konsol.Sonuc(büyüksayıkaresitoplamı,küçüksayıfarktoplamı);
                Console.WriteLine("---------------------------");
                Console.WriteLine("İşlemin devam edebilmsi için rasgele tuş girip,entere basınız");
                Console.ReadLine();

                konsol.DevamveyaDurmak();
                Console.WriteLine("Eğer ki işleme devam edeceniz tüm bilgiler siliniz !!!");
                int b = int.Parse(Console.ReadLine());
                if (b==0)
                {
                    break;
                }
                else
                {
                    sayılar.Clear();
                    büyüksayılar.Clear();
                    küçüksayılar.Clear();
                }
            }
        }
    }
}