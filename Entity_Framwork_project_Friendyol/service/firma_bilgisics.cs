using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class firma_bilgisics
    {
        public static void insert(firma_Bilgisi firma_Bilgisi)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            Entities.firma_Bilgisi.Add(firma_Bilgisi);
            Entities.SaveChanges();
        }
        public static void update(firma_Bilgisi firma_Bilgisi)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yenifirmaBilgisi = Entities.firma_Bilgisi.Where(x => x.firmaID == firma_Bilgisi.firmaID)
                .FirstOrDefault();
            if (firma_Bilgisi != null)
            {
                yenifirmaBilgisi.firmaID = firma_Bilgisi.firmaID;
                yenifirmaBilgisi.ad_soyad = firma_Bilgisi.ad_soyad;
                yenifirmaBilgisi.adres= firma_Bilgisi.adres;
                yenifirmaBilgisi.telefon= firma_Bilgisi.telefon;
                yenifirmaBilgisi.e_mail=firma_Bilgisi.e_mail;
                Entities.SaveChanges();
            }

        }
        public static void delete(firma_Bilgisi firma_Bilgisi)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var firmaBilgisi = Entities.firma_Bilgisi.Where(x => x.firmaID == firma_Bilgisi.firmaID)
              .FirstOrDefault();
            if (firmaBilgisi != null)
            {
                firmaBilgisi.is_flag = 0;
                Entities.SaveChanges();
            }
        }
        public static List<view_firma_Bilgisi> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<view_firma_Bilgisi> firmaBilgisi_list = Entities.view_firma_Bilgisi.ToList();
            return firmaBilgisi_list;
        }
        public static List<FirmaBilgisiList>listFirmaBilgisi()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<FirmaBilgisiList> yeniFirma = Entities.firma_Bilgisi.Select(x => new FirmaBilgisiList()
            {
                firmaID = x.firmaID,
                adSoyad = x.ad_soyad,
                adres=x.adres,
                telefon=x.telefon,
                e_mail=x.e_mail
            }).ToList();
            return yeniFirma;

        }
        public class FirmaBilgisiList
        {
            public int firmaID { get; set; }
            public string adSoyad { get; set; }
            public string adres { get; set; }
            public string telefon { get; set; }
            public string e_mail { get; set; }
        }
    }
}
