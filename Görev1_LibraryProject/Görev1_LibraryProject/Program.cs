using System;


namespace Görev1_LibraryProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();


            while (true)
            {
                Console.WriteLine("\n*****   Kütüphane Yönetim Sistemi  ****\n\n");
                Console.WriteLine("1. Yeni Kitap Ekle");
                Console.WriteLine("2. Tüm Kitapları Görüntüle");
                Console.WriteLine("3. Kitap Ara");
                Console.WriteLine("4. Kitap Ödünç Al");
                Console.WriteLine("5. Kitap İade Et");
                Console.WriteLine("6. Geciken Kitapları Görüntüle");
                Console.WriteLine("7. Çıkış\n");

                Console.Write("Seçiminiz: \n");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        KitapEkle();
                        break;


                    case "2":
                        kutuphane.TumKitaplariGoruntule();
                        break;


                    case "3":
                        Console.Write("Aranacak Kelime: ");
                        string anahtarKelime = Console.ReadLine();
                        kutuphane.KitapArama(anahtarKelime);
                        break;


                    case "4":
                        Console.Write("Ödünç almak istediğiniz kitabın ISBN'si: ");
                        string oduncAlmaISBN = Console.ReadLine();
                        kutuphane.KitapOduncAl(oduncAlmaISBN);
                        break;


                    case "5":
                        Console.Write("İade etmek istediğiniz kitabın ISBN'si: ");
                        string iadeISBN = Console.ReadLine();
                        kutuphane.KitapIadeEt(iadeISBN);
                        break;


                    case "6":
                        kutuphane.SonTarihiGecmisKitabGoruntuleme();
                        break;


                    case "7":
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;


                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;

                }

            }


            void KitapEkle()
            {
                Console.Write("Kitabın Başlığı: ");
                string baslik = Console.ReadLine();

                Console.Write("Yazarın Adı: ");
                string yazar = Console.ReadLine();

                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Kopya Sayısı: ");
                string kopya = Console.ReadLine();
                int kopyaSayisi = int.Parse(kopya);

                kutuphane.KitapEkleme(new Kitap(baslik, yazar, isbn, kopyaSayisi));
            }
            Console.ReadLine();

        }
    }
}
