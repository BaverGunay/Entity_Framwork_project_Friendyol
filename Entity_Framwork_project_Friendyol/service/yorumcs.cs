using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class yorumcs
    {
        public static void insert(yorumlar yorumlar)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            Entities.yorumlar.Add(yorumlar);
            Entities.SaveChanges();
        }
        public static void update(yorumlar yorumlar)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniYorum = Entities.yorumlar.Where(x => x.yorumID == yorumlar.yorumID)
                .FirstOrDefault();
            if (yeniYorum != null)
            {
                yeniYorum.yorumID = yorumlar.yorumID;
                yeniYorum.siparisID = yorumlar.siparisID;
                yeniYorum.yorum = yorumlar.yorum;
                Entities.SaveChanges();
            }

        }
        public static void delete(yorumlar yorumlar)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniYorum = Entities.yorumlar.Where(x => x.yorumID == yorumlar.yorumID)
              .FirstOrDefault();
            if (yeniYorum != null)
            {
                yeniYorum.is_flag = 0;
                Entities.SaveChanges();
            }
        }
        public static List<view_yorumlar> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<view_yorumlar> yorumlar_list = Entities.view_yorumlar.ToList();
            return yorumlar_list;
        }
        public static List<yorumlarList> listYorumlar()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<yorumlarList> yeniYorum = Entities.yorumlar.Select(x => new yorumlarList()
            {
                yorumID = x.yorumID,
                siparisID = x.siparisID.ToString(),
                yorum=x.yorum
            }).ToList();
            return yeniYorum;

        }
        public class yorumlarList
        {
            public int yorumID { get; set; }
            public string siparisID { get; set; }
            public string yorum { get; set; }
        }
    }
}
