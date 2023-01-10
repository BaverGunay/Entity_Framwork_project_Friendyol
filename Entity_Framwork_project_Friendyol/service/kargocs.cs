using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class kargocs
    {
        public static void insert(kargo kargo)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            Entities.kargo.Add(kargo);
            Entities.SaveChanges();
        }
        public static void update(kargo kargo)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniKargo = Entities.kargo.Where(x => x.kargoID == kargo.kargoID)
                .FirstOrDefault();
            if (yeniKargo != null)
            {
                yeniKargo.kargoID = kargo.kargoID;
                yeniKargo.kargoAD = kargo.kargoAD;
                yeniKargo.kargoTEL=kargo.kargoTEL;
                Entities.SaveChanges();
            }
        }
        public static void delete(kargo kargo)
        {
            FRİENDYOLEntities entities = new FRİENDYOLEntities();
            var yeniKargo = entities.kargo.Where(x => x.kargoID == kargo.kargoID)
                .FirstOrDefault();
            if (yeniKargo != null)
            {
                yeniKargo.is_flag = 0;
                entities.SaveChanges();
            }
        }
        public static List<view_kargo> listele()
        {
            FRİENDYOLEntities entities = new FRİENDYOLEntities();
            List<view_kargo> kargo_list = entities.view_kargo.ToList();
            return kargo_list;
        }
        public static List<KargoList> listMarka()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<KargoList> yeniKargo = Entities.kargo.Select(x => new KargoList()
            {
                kargoID = x.kargoID,
                kargoAD = x.kargoAD,
                telefon=x.kargoTEL
            }).ToList();
            return yeniKargo;

        }
        public class KargoList
        {
            public int kargoID { get; set; }
            public string kargoAD { get; set; }
            public string telefon { get; set; }
            
        }
    }
}
