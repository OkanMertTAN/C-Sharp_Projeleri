using System;

namespace Karakter_Degistirme
{
    public class Konsol
    {
        public void IlkMesaj()
        {
            Console.WriteLine("Girmiş olduğunuz kelimelerin ilk harfi ile son harfinin yer değiştirelecektir."+
            "Lütfen cümlenizi giriniz : ");
        } 
        public string[] MetinAl()
        {
            string metin = Console.ReadLine();//Kullanıcı tarafından metin giriliyor.
            return metin.Split(" ");//Alınan metinler kelimelere bölünüyor.
        }
    }
}