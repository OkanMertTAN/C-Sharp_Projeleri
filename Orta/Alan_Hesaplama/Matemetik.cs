using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama ////Çevre,Alan,HACİM
{
    class Matematik
    {
    Konsol_İslemleri metot1 = new Konsol_İslemleri();
     public void ParalelKenar_Alan()
     {
        metot1.Ekran_Yazdirma("Taban Kenarının Uzunluğunu(cm) Giriniz : ");int kenar = int.Parse(Console.ReadLine());
        metot1.Ekran_Yazdirma("Parelelkenarın Yükseliğini(cm) Giriniz : ");
         int yükseklik = int.Parse(Console.ReadLine());
         int alan = kenar*yükseklik;
        
        metot1.Ekran_Yazdirma("Paralelkenarın Alanı : ");
        metot1.Ekran_Yazdirma(alan);
     }
     public void ParalelKenar_Çevre()
     {
        metot1.Ekran_Yazdirma("Alt/Üst tabanın uzunluğunu(cm) giriniz : ");
         float altkenar = float.Parse(Console.ReadLine());

        metot1.Ekran_Yazdirma("Yan tabanlarını giriniz : ");
         float yankenar = float.Parse(Console.ReadLine());
        
         float cevre = (altkenar*2)+(yankenar*2);
        metot1.Ekran_Yazdirma("Paralelkenarın Çevresi");
        metot1.Ekran_Yazdirma(cevre);
     }
     public void Kare_Alan()
     {
        metot1.Ekran_Yazdirma("Karenin bir tane kenarının uzunluğunu(cm) giriniz : ");
         float kenar = float.Parse(Console.ReadLine());

         float alan = (kenar*kenar);
        metot1.Ekran_Yazdirma("Karenin Alanı : ");

        metot1.Ekran_Yazdirma(alan);
     }
     public void Kare_Cevre()
     {
        metot1.Ekran_Yazdirma("Karenin bir tane kenarının uzunluğunu(cm) giriniz : ");
         int kenar = int.Parse(Console.ReadLine()); 

         int cevre = kenar*4;
        metot1.Ekran_Yazdirma("Karenin Çevresi : ");

        metot1.Ekran_Yazdirma(cevre); 
     }
     public void Üçgen_Alan()
     {
        metot1.Ekran_Yazdirma("Taban uzunluğunu(cm) giriniz : ");
         int tabankenar = int.Parse(Console.ReadLine());

        metot1.Ekran_Yazdirma("Yükseklik uzunluğunu(cm) giriniz : "); 
         int yükseklik = int.Parse(Console.ReadLine());

         int alan = (yükseklik*tabankenar)/2;
         metot1.Ekran_Yazdirma("Üçgenin Alanı : ");

        metot1.Ekran_Yazdirma(alan); 
     }
     public void Üçgen_Çevresi()
     {
        metot1.Ekran_Yazdirma("Sırasıyla üç kenarını giriniz : ");
         int kenar1 = int.Parse(Console.ReadLine());
        metot1.Ekran_Yazdirma("İkinci Kenarı Giriniz :");
         int kenar2 = int.Parse(Console.ReadLine());
        metot1.Ekran_Yazdirma("Üçüncü Kenarı Giriniz :");
         int kenar3 = int.Parse(Console.ReadLine());

         int cevre = kenar1+kenar2+kenar3;
         metot1.Ekran_Yazdirma("Üçgenin Çevresi : ");
         metot1.Ekran_Yazdirma(cevre);
     }
     public void Silindir_Hacmi()
     {
        metot1.Ekran_Yazdirma("Silindirin Yarıçapını Giriniz : ");
         int yarıçap =int.Parse(Console.ReadLine());
        
        metot1.Ekran_Yazdirma("Silindirin Yükseliğini Giriniz : ");
        int yükseklik = int.Parse(Console.ReadLine());

         int pi = 3;

         int hacmi = (yarıçap*yarıçap)*yükseklik*pi;

         metot1.Ekran_Yazdirma("Silindirin hacmi : ");
         metot1.Ekran_Yazdirma(hacmi);
     }
    }
}