using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Zinciri_Otomasyonu
{
    public class Sube
    {
        public int SubeKodu { get; set; }

        public string SubeAdi { get; set; }

        public Adres SubeAdresi { get; set; } = new Adres();

        public List<Tedarikci> Tedarikciler { get; set; } = new List<Tedarikci>();

        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public void TedarikciEkle(Tedarikci tedarikci)
        {
            this.Tedarikciler.Add(tedarikci);
        }

        public List<Tedarikci> TedarikciListele()
        {
            return Tedarikciler;
        }

        public void calisanlariSil(Calisan calisan)
        {
            Calisanlar.Remove(calisan);
        }

        public void CalisanEkle(Calisan calisan)
        {
            this.Calisanlar.Add(calisan);
            calisan.CalisanAdresiniKontrolEt();
            if (calisan.CalisanAdresiniKontrolEt() == false)
            {
                calisanlariSil(calisan);
                MessageBox.Show("Adres Bilgileri Boş Geçildiği için Kayıt silindi!!");
            }
        }

        public List<Calisan> CalisanListele()
        {            
            return Calisanlar;
        }

        public void UrunEkle (Urun urun)
        {
            this.Urunler.Add(urun);
        }

        public List<Urun> UrunListele()
        {
            return Urunler;
        }

        public Sube()
        {
            Calisan calisan1 = new Calisan
            {
                CalisanKodu = 5101,
                CalisanAdi = "Ahmet",
                CalisanSoyadi = "YILMAZ",
                CalisanUnvani = "Müdür",
                CalisanSubeKodu = 1,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan1.CalisanAdresi.Il = "BİTLİS";
            calisan1.CalisanAdresi.Ilce = "Tatvan";
            calisan1.CalisanAdresi.Mahalle = "Hidayet Mah.";
            calisan1.CalisanAdresi.Cadde = "Seymen Cad.";
            calisan1.IseBaslamaTarihi = new DateTime(2020, 05, 06);
            calisan1.IzinliGunDurumu = "Salı";
            
            calisan1.Maas = 5.000M;
            CalisanEkle(calisan1);

            Calisan calisan2 = new Calisan
            {
                CalisanKodu = 5102,
                CalisanAdi = "Taner",
                CalisanSoyadi = "ASLAN",
                CalisanUnvani = "Müdür Yardımcısı",
                CalisanSubeKodu = 1,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan2.CalisanAdresi.Il = "BİTLİS";
            calisan2.CalisanAdresi.Ilce = "Mutki";
            calisan2.CalisanAdresi.Mahalle = "Esberk Mah.";
            calisan2.CalisanAdresi.Cadde = "Sevgi Cad.";
            calisan2.IseBaslamaTarihi = new DateTime(2020, 01, 15);
            calisan2.IzinliGunDurumu = "Perşembe";
          
            calisan2.Maas = 4.000M;
            CalisanEkle(calisan2);

            Calisan calisan3 = new Calisan
            {
                CalisanKodu = 5103,
                CalisanAdi = "Mustafa",
                CalisanSoyadi = "ERBAŞ",
                CalisanUnvani = "Kasiyer",
                CalisanSubeKodu = 1,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan3.CalisanAdresi.Il = "BİTLİS";
            calisan3.CalisanAdresi.Ilce = "Tatvan";
            calisan3.CalisanAdresi.Mahalle = "Sahil Mah.";
            calisan3.CalisanAdresi.Cadde = "İşletme Cad.";
            calisan3.IseBaslamaTarihi = new DateTime(2020, 02, 12);
            calisan3.IzinliGunDurumu = "Cuma";
          
            calisan3.Maas = 3.000M;
            CalisanEkle(calisan3);

            Calisan calisan4 = new Calisan
            {
                CalisanKodu = 5104,
                CalisanAdi = "İsmail",
                CalisanSoyadi = "BULUT",
                CalisanUnvani = "Müdür",
                CalisanSubeKodu = 2,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan4.CalisanAdresi.Il = "BİTLİS";
            calisan4.CalisanAdresi.Ilce = "Tatvan";
            calisan4.CalisanAdresi.Mahalle = "Fatih Mah.";
            calisan4.CalisanAdresi.Cadde = "Kartal Cad.";
            calisan4.IseBaslamaTarihi = new DateTime(2020, 03, 20);
            calisan4.IzinliGunDurumu = "Pazartesi";
        
            calisan4.Maas = 5.000M;
            CalisanEkle(calisan4);

            Calisan calisan5 = new Calisan
            {
                CalisanKodu = 5105,
                CalisanAdi = "Muhammed",
                CalisanSoyadi = "AYAZ",
                CalisanUnvani = "Müdür yardımcısı",
                CalisanSubeKodu = 2,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan5.CalisanAdresi.Il = "BİTLİS";
            calisan5.CalisanAdresi.Ilce = "Hizan";
            calisan5.CalisanAdresi.Mahalle = "Kahraman Mah.";
            calisan5.CalisanAdresi.Cadde = "Cezayir Cad.";
            calisan5.IseBaslamaTarihi = new DateTime(2020, 02, 25);
            calisan5.IzinliGunDurumu = "Çarşamba";
          
            calisan5.Maas = 4.000M;
            CalisanEkle(calisan5);

            Calisan calisan6 = new Calisan
            {
                CalisanKodu = 5106,
                CalisanAdi = "Musa",
                CalisanSoyadi = "IŞIKLI",
                CalisanUnvani = "Kasiyer",
                CalisanSubeKodu = 2,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan6.CalisanAdresi.Il = "BİTLİS";
            calisan6.CalisanAdresi.Ilce = "Güroymak";
            calisan6.CalisanAdresi.Mahalle = "Erentepe Mah.";
            calisan6.CalisanAdresi.Cadde = "Kurtuluş Cad.";
            calisan6.IseBaslamaTarihi = new DateTime(2020, 06, 04);
            calisan6.IzinliGunDurumu = "Salı";
          
            calisan6.Maas = 3.000M;
            CalisanEkle(calisan6);

            Calisan calisan7 = new Calisan
            {
                CalisanKodu = 5107,
                CalisanAdi = "Berken",
                CalisanSoyadi = "AVCI",
                CalisanUnvani = "Müdür",
                CalisanSubeKodu = 3,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan7.CalisanAdresi.Il = "BİTLİS";
            calisan7.CalisanAdresi.Ilce = "Ahlat";
            calisan7.CalisanAdresi.Mahalle = "Erkizan Mah.";
            calisan7.CalisanAdresi.Cadde = "Selçuklu Cad.";
            calisan7.IseBaslamaTarihi = new DateTime(2020, 05, 27);
            calisan7.IzinliGunDurumu = "Perşembe";
            
            calisan7.Maas = 5.000M;
            CalisanEkle(calisan7);

            Calisan calisan8 = new Calisan
            {
                CalisanKodu = 5108,
                CalisanAdi = "Ömer",
                CalisanSoyadi = "ŞAFAK",
                CalisanUnvani = "Müdür Yardımcısı",
                CalisanSubeKodu = 3,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan8.CalisanAdresi.Il = "BİTLİS";
            calisan8.CalisanAdresi.Ilce = "Ahlat";
            calisan8.CalisanAdresi.Mahalle = "Tepecik Mah.";
            calisan8.CalisanAdresi.Cadde = "Çetin Emeç Cad.";
            calisan8.IseBaslamaTarihi = new DateTime(2020, 04, 19);
            calisan8.IzinliGunDurumu = "Çarşamba";
            
            calisan8.Maas = 4.000M;
            CalisanEkle(calisan8);

            Calisan calisan9 = new Calisan
            {
                CalisanKodu = 5109,
                CalisanAdi = "Nevzat",
                CalisanSoyadi = "EKİN",
                CalisanUnvani = "Kasiyer",
                CalisanSubeKodu = 3,
                CalisanSubeAdi = "BünSer Market"
            };
            calisan9.CalisanAdresi.Il = "BİTLİS";
            calisan9.CalisanAdresi.Ilce = "Yenişehir";
            calisan9.CalisanAdresi.Mahalle = "Alangör Mah.";
            calisan9.CalisanAdresi.Cadde = "Bağlar Cad.";
            calisan9.IseBaslamaTarihi = new DateTime(2020, 02, 20);
            calisan9.IzinliGunDurumu = "Pazartesi";
       
            calisan9.Maas = 3.000M;
            CalisanEkle(calisan9);

            Tedarikci tedarikci1 = new Tedarikci
            {
                TedarikciAdi = "Ali",
                TedarikciSoyadi = "Şimşek",
                TedarikciKodu = 1,
                TedarikciTuru = "Temizlik"
            };
            tedarikci1.TedarikciAdresi.Il = "BİTLİS";
            tedarikci1.TedarikciAdresi.Ilce = "Adilcevaz";
            tedarikci1.TedarikciAdresi.Mahalle = "Adil Mah.";
            tedarikci1.TedarikciAdresi.Cadde = "İstikrar Cad.";
            TedarikciEkle(tedarikci1);

            Tedarikci tedarikci2 = new Tedarikci
            {
                TedarikciAdi = "Mehmet",
                TedarikciSoyadi = "Yaman",
                TedarikciKodu = 2,
                TedarikciTuru = "Gıda"
            };
            tedarikci2.TedarikciAdresi.Il = "İSTANBUL";
            tedarikci2.TedarikciAdresi.Ilce = "Bağcılar";
            tedarikci2.TedarikciAdresi.Mahalle = "Yavuz Selim Mah.";
            tedarikci2.TedarikciAdresi.Cadde = "Ana Cad.";
            TedarikciEkle(tedarikci2);

            Tedarikci tedarikci3 = new Tedarikci
            {
                TedarikciAdi = "Eşref",
                TedarikciSoyadi = "Demir",
                TedarikciKodu = 3,
                TedarikciTuru = "Haftalık Kampanya"
            };
            tedarikci3.TedarikciAdresi.Il = "BATMAN";
            tedarikci3.TedarikciAdresi.Ilce = "Kozluk";
            tedarikci3.TedarikciAdresi.Mahalle = "Komando Mah.";
            tedarikci3.TedarikciAdresi.Cadde = "Çetin Emeç Cad.";
            TedarikciEkle(tedarikci3);

            Temizlik temizlik1 = new Temizlik
            {
                UrunKodu = 110,
                StokAdeti = 75,
                UrunGrubu = "Temizlik Ürünü",
                UrunAdi = "Deterjan",
                UrunFiyati = 34.99,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 1,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 1
            };
            UrunEkle(temizlik1);

            Temizlik temizlik2 = new Temizlik
            {
                UrunKodu = 111,
                StokAdeti = 43,
                UrunGrubu = "Temizlik Ürünü",
                UrunAdi = "Cif Ultra",
                UrunFiyati = 15.75,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 2,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 1
            };
            UrunEkle(temizlik2);

            Gida gida1 = new Gida
            {
                UrunKodu = 112,
                StokAdeti = 38,
                UrunGrubu = "Gıda Ürünü",
                UrunAdi = "Bitkisel Macun",
                UrunFiyati = 107.10,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 3,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 2
            };
            UrunEkle(gida1);

            Gida gida2 = new Gida
            {
                UrunKodu = 113,
                StokAdeti = 35,
                UrunGrubu = "Gıda Ürünü",
                UrunAdi = "Arifoğlu Zencefil",
                UrunFiyati = 21.99,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 1,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 2
            };
            UrunEkle(gida2);

            Kampanya kampanya1 = new Kampanya
            {
                UrunKodu = 114,
                StokAdeti = 50,
                UrunGrubu = "Haftalık Kampanya Ürünü",
                UrunAdi = "64 GB USB Bellek",
                UrunFiyati = 59.90,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 2,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 3
            };
            UrunEkle(kampanya1);

            Kampanya kampanya2 = new Kampanya
            {
                UrunKodu = 115,
                StokAdeti = 40,
                UrunGrubu = "Haftalık Kampanya Ürünü",
                UrunAdi = "Logitech Mouse",
                UrunFiyati = 89.90,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 3,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 3
            };
            UrunEkle(kampanya2);
        }
    }
}
