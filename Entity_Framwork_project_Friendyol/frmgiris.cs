using Entity_Framwork_project_Friendyol.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framwork_project_Friendyol
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        //public string adSoyad;  
        //public bool kontrol_et()
        //{
        //    FRİENDYOLEntities Entities =new  FRİENDYOLEntities();
        //    var login = Entities.musteri.Where(x=>x.adSoyad==txtKulanıcıAdı.Text && x.adSoyad==txtSifre.Text ).FirstOrDefault();
        //    if (login!=null)
        //    {
        //        if (login.is_Admin ==1)
        //        {
        //            main main=new main();
        //            main.Show();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            main1 main1 = new main1();
        //            main1.Show();
        //            this.Hide();
        //        }

        //        return true;
        //    }

        //    else 
        //    {
        //        MessageBox.Show("girişi kontrol edin");
        //        return false;
        //    }
        //}
        public string adSoyad;
        private void btnGiris_Click(object sender, EventArgs e)
        {


      
        //public bool kontrol_et()
        //{
            FRİENDYOLEntities Entities = new FRİENDYOLEntities();
            var login = Entities.musteri.Where(x => x.adSoyad == txtKulanıcıAdı.Text && x.adSoyad == txtSifre.Text).FirstOrDefault();
            if (login != null)
            {
                if (login.is_Admin == 1)
                {
                    main main = new main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    main1 main1 = new main1();
                    main1.Show();
                    this.Hide();
                }

                //return true;
            }

            else
            {
                MessageBox.Show("girişi kontrol edin");
                //return false;
            }

        //}


        //frmgiris frmgiris = new frmgiris();
        //adSoyad = login.adSoyad;
        //adSoyad = login.adSoyad;
        //main1 main1 = new main1();
        //    main1.Show();
        //    this.Hide();
    }







}
}
