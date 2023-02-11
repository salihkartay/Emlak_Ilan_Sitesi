using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Emlak.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var sehir = new List<Sehir>()
            {
                new Sehir() {SehirAd="İSTANBUL"},
                new Sehir() {SehirAd="ANKARA"},
                new Sehir() {SehirAd="İZMİR"},
                new Sehir() {SehirAd="ELAZIĞ"}
            };
            foreach (var item in sehir)
            {
                context.Sehirs.Add(item);
            }
            context.SaveChanges();

            var semt = new List<Semt>()
            {
                new Semt(){SemtAd="KAĞITHANE", SehirId=1},
                new Semt(){SemtAd="KEÇİÖREN", SehirId=2},
                new Semt(){SemtAd="BORNOVA", SehirId=3},
                new Semt(){SemtAd="MERKEZ", SehirId=4}
            };
            foreach (var item in semt)
            {
                context.Semts.Add(item); 
            }
            context.SaveChanges();

            var mahalle = new List<Mahalle>()
            { 
                new Mahalle(){MahalleAd="ÇAĞLAYAN",SemtId=1},
                new Mahalle(){MahalleAd="İZZETPAŞA",SemtId=2},
                new Mahalle(){MahalleAd="TALATPAŞA",SemtId=3},
                new Mahalle(){MahalleAd="ÜNİVERSİTE",SemtId=4}
            };
            foreach (var item in mahalle)
            {
                context.Mahalles.Add(item);
            }
            context.SaveChanges();

            var durum = new List<Durum>()
            {
                new Durum() {DurumAd="KİRALIK"},
                new Durum() {DurumAd="SATILIK"}
            };
            foreach (var item in durum)
            {
                context.Durums.Add(item);
            }
            context.SaveChanges();

            var tip = new List<Tip>()
            {
                new Tip() {TipAd="EV", DurumId=1},
                new Tip() {TipAd="DÜKKAN", DurumId=1},
                new Tip() {TipAd="EV", DurumId=2},
                new Tip() {TipAd="DÜKKAN", DurumId=2}
            };
            foreach (var item in tip)
            {
                context.Tips.Add(item);
            }
            context.SaveChanges();

            var ilan = new List<Ilan>()
            {
                new Ilan() {Açıklama = "Dublex",Adres="Kooperatif Sk.",OdaSayisi=7,BanyoSayisi=3,Kredi=true,Fiyat=1500,MahalleId=4,SemtId=4,SehirId=4,DurumId=1,TipId=1,Alan=250,Telefon="4241111111",Kat="5. kat", UserName="Salih"},
                new Ilan() {Açıklama = "Metroya Yakın",Adres="Atatürk Cd.",OdaSayisi=4,BanyoSayisi=1,Kredi=false,Fiyat=1500,MahalleId=9,SemtId=7,SehirId=1,DurumId=2,TipId=4,Alan=110,Telefon="2121111111",Kat="5. kat", UserName="Hakan"}
            };
            foreach (var item in ilan)
            {
                context.Ilans.Add(item);
            }
            context.SaveChanges();

            var resim = new List<Resim>()
            {
                new Resim() {ResimAd="1.jpg", IlanId=1 },
                new Resim() {ResimAd="2.jpg", IlanId=1 },
                new Resim() {ResimAd="3.jpg", IlanId=2 },
            };
            foreach (var item in resim)
            {
                context.Resims.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}