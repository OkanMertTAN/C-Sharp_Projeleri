using System;
using System.Collections;

namespace Karakter_Degistirme
{
    public class Matematik
    {
        Konsol konsol = new Konsol();
        public void Islem2()
        {
            string[] kelimeler = konsol.MetinAl();//Bölünmüş kelimeler dizi içine aktarılır.
            int kelimesayısı = kelimeler.Length;//Kaç kelime oluduğu değişkenin içinde atıyoruz.
            for (var i = 0; i < kelimesayısı; i++)//Kelime sayısı kadar döngü işlemi başlatıyoruz ve kelimeleri tek tek işlem yapacağız.
            {
                int kelimeninSonHarfini = 0;
                for (var j = 0; j < kelimeler[i].Length; j++)
                {
                    kelimeninSonHarfini = j;//Bu döngüde kelime son harfinin index numarasını buluyoruz.
                }
                char[] harfler = new char[kelimeler[i].Length];

                harfler = kelimeler[i].ToCharArray();//Sıradaki (i) kelimeyi harflere bölüp, harfler dizesinin içine aktarıyoruz.
                
                char ilkharf = harfler[0];//İlk harfi tespit ettik. Bir char değerine kayıt ettik.
                char sonharf = harfler[kelimeninSonHarfini];//Son harfi tespit ettik. Bir char değerine kayıt ettik.

                ArrayList yeniharfler = new ArrayList();//Bir klon oluştruldu. Önemli işlemleri bunun içinde yapacağız.
                yeniharfler.AddRange(harfler);//Klonun içine harflerimizi ekledik.

                yeniharfler.Remove(harfler[0]);//İlk harfi sildik.
                yeniharfler.Remove(harfler[kelimeninSonHarfini]);//Son harfi sildik.

                ArrayList sonucharfler = new ArrayList();//Son hali içinde bir ArrayList oluşturduk. İstediğimiz ekleme işlemi yaptık.
                sonucharfler.Add(sonharf);
                sonucharfler.AddRange(yeniharfler);
                sonucharfler.Add(ilkharf);

                foreach (var item in sonucharfler)
                {
                    Console.Write(item);//Harflerimizi bitişik sekilde yan yana sıraladık. Konsolda kelime gibi gözükecek.
                }
                Console.WriteLine();//Bir sonraki kelime için satır atlıyacak .
            }
        }
    }
}