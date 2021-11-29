using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOP_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Classlar.Urun u1 = new Classlar.Urun()
                {
                    UrunAdi = "Ekmek",
                    UrunId = 1000,
                    UrunKategorisi = UrunKategorileri.Gıda

                };
                Classlar.Urun u2 = new Classlar.Urun()
                {
                    UrunAdi = "Şarj Aleti",
                    UrunId = 1001,
                    UrunKategorisi = UrunKategorileri.Elektronik

                };
                Classlar.Urun u3 = new Classlar.Urun()
                {
                    UrunAdi = "Süt",
                    UrunId = 1002,
                    UrunKategorisi = UrunKategorileri.Gıda

                };
                Classlar.Urun u4 = new Classlar.Urun()
                {
                    UrunAdi = "Şampuan",
                    UrunId = 1003,
                    UrunKategorisi = UrunKategorileri.Temizlik

                };

                Classlar.Musteri m = new Classlar.Musteri
                {
                    MusteriId = 1,
                    Cinsiyeti = Cinsiyetler.Erkek,
                    DogumTarihi = new DateTime(1978,11,29),
                    MusteriAdi = "Faik",
                    MusteriSoyadi = "Turan"
                    
                };

                Classlar.UrunSepeti musterisepeti = new Classlar.UrunSepeti
                {
                    MusteriId = m.MusteriId,
                    SepetId= 1
                };

                musterisepeti.UrunlerListesi.Add(u1);
                musterisepeti.UrunlerListesi.Add(u2);
                musterisepeti.UrunlerListesi.Add(u3);
                musterisepeti.UrunlerListesi.Add(u4);

                m.MusterininUrunSepeti = musterisepeti;//Önce sepeti ve sepete eklenecek ürünleri yukarıda aldım sonra o sepeti müşterime atadım.

                m.MusteriBilgileriYazdir();
                m.MusterininSepetiniYazdir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            Console.ReadKey();
        }
    }
}
