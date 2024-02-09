using System;


namespace Görev1_LibraryProject
{
    public class Kitap
    {

        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        public int KopyaSayisi { get; set; }
        public int OduncAlinanKopyalar { get; set; }

        public Kitap(string baslik, string yazar, string isbn, int kopyaSayisi)
        {
            Baslik = baslik;
            Yazar = yazar;
            ISBN = isbn;
            KopyaSayisi = kopyaSayisi;
        }

        public bool OduncAlinabilirMi()
        {
            return KopyaSayisi - OduncAlinanKopyalar > 0;
        }

        public void KitabiOduncAl()
        {
            if (KopyaSayisi - OduncAlinanKopyalar > 0)
            {
                OduncAlinanKopyalar++;
                Console.WriteLine("Kitap ödünç alındı.");
            }
            else
            {
                Console.WriteLine("bu kitaptan yok.");
            }
        }

        public void KitabiIadeEt()
        {
            if (OduncAlinanKopyalar > 0)
            {
                OduncAlinanKopyalar--;
                Console.WriteLine("Kitap iade edildi.");
            }
            else
            {
                Console.WriteLine("Bu kitap zaten var.");
            }
        }


    }
}
