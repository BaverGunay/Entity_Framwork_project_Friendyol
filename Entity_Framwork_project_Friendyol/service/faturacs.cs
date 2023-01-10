using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork_project_Friendyol.service
{
    public class faturacs
    {
        public static void insert(fatura fatura)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            Entities.fatura.Add(fatura);
            Entities.SaveChanges();
        }
        public static void update(fatura fatura)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniFatura = Entities.fatura.Where(x => x.faturaID == fatura.faturaID)
                .FirstOrDefault();
            if (yeniFatura != null)
            {
                yeniFatura.faturaID = fatura.faturaID;
                yeniFatura.musteriID = fatura.musteriID;
                yeniFatura.siparisID= fatura.siparisID;
                yeniFatura.firmaID = fatura.firmaID;
                Entities.SaveChanges();
            }

        }
        public static void delete(fatura fatura)
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var yeniFatura = Entities.fatura.Where(x => x.faturaID == fatura.faturaID)
              .FirstOrDefault();
            if (yeniFatura != null)
            {
                yeniFatura.is_flag = 0;
                Entities.SaveChanges();
            }
        }
        public static List<wiew_fatura> listele()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<wiew_fatura> fatura_list = Entities.wiew_fatura.ToList();
            return fatura_list;
        }
        public static List<FaturaList> listKategori()
        {
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            List<FaturaList> yeniUrun = Entities.fatura.Select(x => new FaturaList()
            {
                faturaID = x.faturaID,
                musteriID = x.musteriID.ToString(),
                siparisID=x.siparisID.ToString(),
                firmaID=x.firmaID.ToString()
            }).ToList();
            return yeniUrun;

        }
        public class FaturaList
        {
            public int faturaID { get; set; }
            public string musteriID { get; set; }
            public string siparisID { get; set; }
            public string firmaID { get; set; }
        }
    }
}
