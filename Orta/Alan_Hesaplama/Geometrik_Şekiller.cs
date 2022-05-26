using System;


namespace Alan_Hesaplama 
{
    public class Geometrik_Şekiller
    {
        Konsol_İslemleri metot1 = new Konsol_İslemleri();   
        Matematik metot2 = new Matematik();
        public void ParalelKenar()
        {
            metot1.Ekran_Yazdirma("ParalelKenar İşlemleri");
            metot1.Ekran_Yazdirma("************");
            metot1.Ekran_Yazdirma("Alan hesaplamak için 1,Çevre hesaplamak 2'yi tuşlayın :  ");

            int değergirisi = int.Parse(Console.ReadLine());

            switch (değergirisi)
            {
                case 1 :
                metot2.ParalelKenar_Alan();
                    break;
                case 2 : 
                metot2.ParalelKenar_Çevre();
                    break;
                default:
                metot1.Ekran_Yazdirma("Lütfen Geçerli bir değer giriniz!!");
                    break;
            }
        }
        public void Kare()
        {
            metot1.Ekran_Yazdirma("Kare İşlemleri");
            metot1.Ekran_Yazdirma("************");
            metot1.Ekran_Yazdirma("Alan hesaplamak için 1,Çevre hesaplamak 2'ti tuşlayın :  ");

            int değergirisi = int.Parse(Console.ReadLine());

            switch (değergirisi)
            {
                case 1 :
                metot2.Kare_Alan();
                    break; 
                case 2 :
                metot2.Kare_Cevre();
                    break;    
                default:
                metot1.Ekran_Yazdirma("Lütfen Geçerli bir değer giriniz!!");
                    break;
            }
        }
        public void Üçgen()
        {
            metot1.Ekran_Yazdirma("Üçgen İşlemleri");
            metot1.Ekran_Yazdirma("************");
            metot1.Ekran_Yazdirma("Alan hesaplamak için 1,Çevre hesaplamak 2'ti tuşlayın :  ");

            int değergirisi = int.Parse(Console.ReadLine());

            switch (değergirisi)
            {
                case 1 : 
                metot2.Üçgen_Alan();
                    break;
                case 2 : 
                metot2.Üçgen_Çevresi();
                    break;    
                default:
                metot1.Ekran_Yazdirma("Lütfen Geçerli bir değer giriniz!!");
                    break;
            }
        }
        public void Silindir()
        {
            metot1.Ekran_Yazdirma("Silindir İşlemleri");
            metot1.Ekran_Yazdirma("************");

            metot1.Ekran_Yazdirma("Silindirin Alanını Hesaplamak için herhangibi tuşa basınız :  ");
            Console.ReadLine();

            metot2.Silindir_Hacmi();
        }


    }
}