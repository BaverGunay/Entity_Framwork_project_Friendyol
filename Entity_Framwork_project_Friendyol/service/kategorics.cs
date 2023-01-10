using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class kategorics
    {
        public static void insert(kategori kategori)
        {
            FRİENDYOLEntities Entities=new FRİENDYOLEntities();
            Entities.kategori.Add(kategori);
            Entities.SaveChanges();
        }
        public static void update(kategori kategori)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniKategori = Entities.kategori.Where(x=>x.kategoriID==kategori.kategoriID)
                .FirstOrDefault();
            if (yeniKategori!=null)
            {
                yeniKategori.kategoriID = kategori.kategoriID;
                yeniKategori.kategoriAD=kategori.kategoriAD;
                Entities.SaveChanges();
            }

        }
        public static void delete(kategori kategori)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniKategori = Entities.kategori.Where(x => x.kategoriID == kategori.kategoriID)
              .FirstOrDefault();
            if (yeniKategori!=null)
            {
                yeniKategori.is_flag = 0;
                Entities.SaveChanges();
            }
        }
        public static List<view_kategori> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<view_kategori> kategori_list=Entities.view_kategori.ToList();
            return kategori_list;
        }
        public static List<CategoryList> listKategori()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<CategoryList> yeniUrun = Entities.kategori.Select(x => new CategoryList()
            {
                kategoriID=x.kategoriID,
                kategoriAD=x.kategoriAD
            }).ToList();
            return yeniUrun;

        }
        public class CategoryList
        {
            public int kategoriID { get; set; }
            public string kategoriAD { get; set; }
        }
    }
}
