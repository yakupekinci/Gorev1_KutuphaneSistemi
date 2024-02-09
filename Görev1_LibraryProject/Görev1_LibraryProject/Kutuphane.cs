using System;
using System.Collections.Generic;
using System.Linq;


namespace Görev1_LibraryProject
{
    class Kutuphane
    {
        List<Kitap> kitaplar = new List<Kitap>();


        public Kutuphane()
        {
            kitaplar = new List<Kitap>();
            Kitap book1 = new Kitap("Marslı", "Andy Wier", "123456", 3);
            Kitap book2 = new Kitap("Dünyanın Merkezine Yolculuk", "Julse Verne 2", "234567", 5);
            Kitap book3 = new Kitap("Artemis", "Andy Wier", "345678", 2);
            kitaplar.Add(book1);
            kitaplar.Add(book2);
            kitaplar.Add(book3);

        }
        public void KitapEkleme(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine("Yeni kitap  eklendi.");

        }
        public void TumKitaplariGoruntule()
        {
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine($"Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}, ISBN: {kitap.ISBN}, Kopya Sayısı: {kitap.KopyaSayisi}, Ödünç Alınan Kopyalar: {kitap.OduncAlinanKopyalar}\n");
                Console.WriteLine("__________________________________________________________________________________________________________________\n");
            }
        }
        public void KitapArama(string anahtarKelime)
        {

            var bulunanKitaplar = kitaplar.Where(k => k.Baslik.Contains(anahtarKelime) || k.Yazar.Contains(anahtarKelime)).ToList();

            if (bulunanKitaplar.Count == 0)
            {
                Console.WriteLine("kitap bulunamadı.");
            }

            else
            {
                foreach (var kitap in bulunanKitaplar)
                {
                    Console.WriteLine($"Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}, ISBN: {kitap.ISBN}, Kopya Sayısı: {kitap.KopyaSayisi}, Ödünç Alınan Kopyalar: {kitap.OduncAlinanKopyalar}\n");
                    
                }
            }
        }
        public void KitapOduncAl(string isbn)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.ISBN == isbn);

            if (kitap == null)
            {
                Console.WriteLine("kitap bulunamadı.");
                return;
            }

            if (kitap.OduncAlinabilirMi())
            {
                kitap.KitabiOduncAl();
            }
            else
            {
                Console.WriteLine("bu kitaptan yok.");
            }
        }

        public void KitapIadeEt(string isbn)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.ISBN == isbn);

            if (kitap == null)
            {
                Console.WriteLine("  kitap bulunamadı.");
                return;
            }

            kitap.KitabiIadeEt();
        }

        public void SonTarihiGecmisKitabGoruntuleme()
        {
            var gecikenKitaplar = kitaplar.Where(k => k.OduncAlinanKopyalar > 0 && k.OduncAlinanKopyalar < k.KopyaSayisi).ToList();


            foreach (var kitap in gecikenKitaplar)
            {
                Console.WriteLine($"Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}, ISBN: {kitap.ISBN}, Kopya Sayısı: {kitap.KopyaSayisi}, Ödünç Alınan Kopyalar: {kitap.OduncAlinanKopyalar}\n");
            }


        }


    }
}
