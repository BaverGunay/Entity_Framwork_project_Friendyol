using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class musterics
    {
        public static void insert(musteri musteri)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            Entities.musteri.Add(musteri);
            Entities.SaveChanges();
        }
        public static void update(musteri musteri)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniMusteri = Entities.musteri.Where(x => x.musteriID == musteri.musteriID)
                .FirstOrDefault();
            if (yeniMusteri != null)
            {
                yeniMusteri.musteriID = musteri.musteriID;
                yeniMusteri.adSoyad = musteri.adSoyad;
                yeniMusteri.ulke = musteri.ulke;
                yeniMusteri.sehir = musteri.sehir;
                yeniMusteri.adres = musteri.adres;
                yeniMusteri.telefon = musteri.telefon;
                yeniMusteri.e_mail = musteri.e_mail;
                yeniMusteri.is_Admin=musteri.is_Admin;
                Entities.SaveChanges();
            }
        }
        public static void delete(musteri musteri)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniMusteri = Entities.musteri.Where(x => x.musteriID == musteri.musteriID)
                .FirstOrDefault();
            if (yeniMusteri != null)
            {
                yeniMusteri.is_flag = 0;
                Entities.SaveChanges();

            }
        }
        public static List<view_musteri> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<view_musteri> musteri_list = Entities.view_musteri.ToList();
            return musteri_list;
        }

        public static List<musteriList> listmusteri()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<musteriList> yeniMusteri = Entities.musteri.Select(x => new musteriList()
            {
                musteriID = x.musteriID.ToString(),
                adSoyad = x.adSoyad.ToString(),
                ulke = x.ulke.ToString(),
                sehir = x.sehir.ToString(),
                adres = x.adres.ToString(),
                telefon = x.telefon.ToString(),
                e_mail = x.e_mail.ToString(),
                is_Admin=x.is_Admin.ToString()
            }).ToList();
            return yeniMusteri;

        }
        public class musteriList
        {
            public string musteriID { get; set; }
            public string adSoyad { get; set; }
            public string ulke { get; set; }
            public string sehir { get; set; }
            public string adres { get; set; }
            public string telefon { get; set; }
            public string e_mail { get; set; }
            public string is_Admin { get; set; }

        }
    }
}
