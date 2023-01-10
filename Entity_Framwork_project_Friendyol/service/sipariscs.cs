using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class sipariscs
    {
        FRİENDYOLEntities Entities = new FRİENDYOLEntities();
        public  void insert(List<siparis> siparisler)
        {
            foreach (var item in siparisler)
            {
              Entities.siparis.Add(item);
              var urun=Entities.urun.Where(u => u.urunID == item.urunID).FirstOrDefault();
              urun.stok -= item.adet;
            }
           

            
            
            Entities.SaveChanges();
        }
        public static void update(siparis siparis)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniUrun = Entities.siparis.Where(x => x.siparisID == siparis.siparisID)
                .FirstOrDefault();
            if (yeniUrun != null)
            {
                yeniUrun.siparisID = siparis.siparisID;
                yeniUrun.urunID = siparis.urunID;
                yeniUrun.musteriID = siparis.musteriID;
                yeniUrun.adet = siparis.adet;
                Entities.SaveChanges();
            }
        }
        public static void delete(siparis siparis)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniUrun = Entities.siparis.Where(x => x.siparisID == siparis.siparisID)
                .FirstOrDefault();
            if (yeniUrun != null)
            {
                yeniUrun.is_flag = 0;
                Entities.SaveChanges();

            }
        }
        public static List<view_siparis> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<view_siparis> siparis_list = Entities.view_siparis.ToList();
            return siparis_list;
        }
        public static List<siparisList> listSiparis()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<siparisList> yeniSiparis = Entities.siparis.Select(x => new siparisList()
            {
                siparisID = x.siparisID.ToString(),
                urunID = x.urunID.ToString(),
                musteriID = x.musteriID.ToString(),
                adet = x.adet.ToString()
               
            }).ToList();
            return yeniSiparis;

        }
        public class siparisList
        {
            public string siparisID { get; set; }
            public string urunID { get; set; }
            public string musteriID { get; set; }
            public string adet { get; set; }
           

        }
    }
}
