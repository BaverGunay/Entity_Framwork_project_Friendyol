using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framwork_project_Friendyol.service
{
    public class uruncs
    {
        public static void insert(urun urun)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            Entities.urun.Add(urun);
            Entities.SaveChanges();
        }
        public static void update(urun urun)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniUrun = Entities.urun.Where(x => x.urunID == urun.urunID)
                .FirstOrDefault();
            if (yeniUrun != null)
            {
                yeniUrun.urunID = urun.urunID;
                yeniUrun.urunAD = urun.urunAD;
                yeniUrun.markaID = urun.markaID;
                yeniUrun.fiyat = urun.fiyat;
                yeniUrun.stok = urun.stok;
                yeniUrun.acıklama = urun.acıklama;
                Entities.SaveChanges();
            }
        }
        public static void delete(urun urun)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniUrun = Entities.urun.Where(x => x.urunID == urun.urunID)
                .FirstOrDefault();
            if (yeniUrun != null)
            {
                yeniUrun.is_flag = 0;
                Entities.SaveChanges();

            }
        }
        public static List<view_urun> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<view_urun> urun_list = Entities.view_urun.ToList();
            return urun_list;
        }

        public static string fiyat_getir(urun urun)
        {


            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var YeniUrun = Entities.urun.Where(x => x.urunID == urun.urunID).FirstOrDefault();
            return YeniUrun.fiyat.ToString();

        }



        public static string ADET_GETIR(urun urun)
        {

            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var YeniUrun = Entities.urun.Where(x => x.urunID == urun.urunID).FirstOrDefault();
            return YeniUrun.stok.ToString();

        }

        public static List<urunList> listUrun()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<urunList> yeniUrun = Entities.urun.Select(x => new urunList()
            {
                urunID = x.urunID.ToString(),
               kategoriID  = x.kategoriID.ToString(),
               urunAD=x.urunAD.ToString(),
               markaID=x.markaID.ToString(),
               fiyat=x.fiyat.ToString(),
               stok=x.stok.ToString(),
               acıklama=x.acıklama.ToString()
            }).ToList();
            return yeniUrun;

        }
        public class urunList
        {
            public string urunID { get; set; }
            public string kategoriID { get; set; }
            public string urunAD { get; set; }
            public string markaID { get; set; }
            public string fiyat { get; set; }
            public string stok { get; set; }
            public string acıklama { get; set; }

        }
    }
}


    


