using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ParalelKenar,Kare ,Üçgen,Silindir
//Çevre,Alan,HACİM
namespace Alan_Hesaplama //
{
    internal class Program
    {
        Konsol_İslemleri metot1 = new Konsol_İslemleri();
        Geometrik_Şekiller metot3 = new Geometrik_Şekiller();
        internal void Main()
        {
            metot1.Ekran_Yazdirma("Alan, Hacim ve Çevre Hesaplama Sistemi ");
            metot1.Ekran_Yazdirma("İşlem yapmak istidiğiniz şekili numarasını seçiniz  : ");
            metot1.Ekran_Yazdirma("--------------------------");
            metot1.Ekran_Yazdirma("1-) ParalelKenar");
            metot1.Ekran_Yazdirma("2-) Kare");
            metot1.Ekran_Yazdirma("3-) Üçgen");
            metot1.Ekran_Yazdirma("4-) Silindir");
            metot1.Ekran_Yazdirma("--------------------------");

            int index = int.Parse(Console.ReadLine());

            switch (index)
            {
                case 1 : 
                metot3.ParalelKenar();
                    break;
                case 2 :
                metot3.Kare();
                    break;
                case 3 : 
                metot3.Üçgen();
                    break; 
                case 4 :
                metot3.Silindir();
                    break;      
                default:
                metot1.Ekran_Yazdirma("Lütfen geçerli sayılar ile tekrar deneyiniz !!!");
                    break;
            }
        }
        
    }
}