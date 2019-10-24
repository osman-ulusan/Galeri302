namespace Galeri302.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Galeri302.Models.G302Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Galeri302.Models.G302Context db)
        {
            if (!db.Sehirler.Any()) // Sadece þehirler tablosu boþ ise ekler
            {
                db.Sehirler.Add(new Models.yCity() { Sehir = "1	Adana" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "2	Adýyaman" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "3	Afyonkarahisar" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "4	Aðrý" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "5	Amasya" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "6	Ankara" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "7	Antalya" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "8	Artvin" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "9	Aydýn" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "10 Balýkesir" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "11 Bilecik" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "12 Bingöl" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "13 Bitlis" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "14 Bolu" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "15 Burdur" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "16 Bursa" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "17 Çanakkale" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "18 Çankýrý" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "19 Çorum" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "20 Denizli" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "21 Diyarbakýr" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "22 Edirne" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "23 Elazýð" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "24 Erzincan" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "25 Erzurum" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "26 Eskiþehir" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "27 Gaziantep" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "28 Giresun" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "29 Gümüþhane" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "30 Hakkâri" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "31 Hatay" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "32 Isparta" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "33 Ýçel(Mersin)" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "34 Ýstanbul" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "35 Ýzmir" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "36 Kars" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "37 Kastamonu" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "38 Kayseri" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "39 Kýrklareli" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "40 Kýrþehir" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "41 Kocaeli" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "42 Konya" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "43 Kütahya" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "44 Malatya" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "45 Manisa" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "46 Kahramanmaraþ" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "47 Mardin" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "48 Muðla" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "49 Muþ" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "50 Nevþehir" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "51 Niðde" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "52 Ordu" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "53 Rize" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "54 Sakarya" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "55 Samsun" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "56 Siirt" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "57 Sinop" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "58 Sivas" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "59 Tekirdað" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "60 Tokat" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "61 Trabzon" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "62 Tunceli" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "63 Þanlýurfa" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "64 Uþak" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "65 Van" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "66 Yozgat" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "67 Zonguldak" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "68 Aksaray" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "69 Bayburt" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "70 Karaman" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "71 Kýrýkkale" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "72 Batman" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "73 Þýrnak" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "74 Bartýn" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "75 Ardahan" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "76 Iðdýr" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "77 Yalova" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "78 Karabük" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "79 Kilis" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "80 Osmaniye" });
                db.Sehirler.Add(new Models.yCity() { Sehir = "81 Düzce" });

                db.SaveChanges();
            }

        }
    }
}
