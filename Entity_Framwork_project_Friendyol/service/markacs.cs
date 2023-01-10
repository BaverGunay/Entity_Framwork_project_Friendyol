using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class markacs
    {
       
        public static void insert(marka marka)
        {
            FRİENDYOLEntities Entities =new FRİENDYOLEntities();
            Entities.marka.Add(marka);
            Entities.SaveChanges();
        }
        public static void update(marka marka)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniMarka = Entities.marka.Where(x=>x.markaID==marka.markaID)
                .FirstOrDefault();
            if (yeniMarka!= null)
            {
                yeniMarka.markaID = marka.markaID;
                yeniMarka.markaAD = marka.markaAD;
                Entities.SaveChanges();
            }
        }
        public static void delete(marka marka)
        {
            FRİENDYOLEntities entities = new FRİENDYOLEntities();
            var yeniMarka = entities.marka.Where(x => x.markaID == marka.markaID)
                .FirstOrDefault();
            if (yeniMarka!=null)
            {
                yeniMarka.is_flag = 0;
                entities.SaveChanges();
            }
        }
        public static List<view_marka> listele()
        {
            FRİENDYOLEntities entities = new FRİENDYOLEntities();
            List<view_marka> marka_list = entities.view_marka.ToList();
            return marka_list;
        }
        public static List<MarkaList> listMarka()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<MarkaList> yeniUrun = Entities.marka.Select(x => new MarkaList()
            {
                markaID = x.markaID,
                markaAD = x.markaAD
            }).ToList();
            return yeniUrun;

        }
        public class MarkaList
        {
            public int markaID { get; set; }
            public string markaAD { get; set; }
        }
    }
}
