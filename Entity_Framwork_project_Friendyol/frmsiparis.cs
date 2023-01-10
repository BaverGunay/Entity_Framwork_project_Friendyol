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
    public partial class frmsiparis : Form
    {
        public frmsiparis()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView2.DataSource = sipariscs.listele();

            comMusteri.DataSource = musterics.listmusteri();
            comMusteri.DisplayMember = "adSoyad";
            comMusteri.ValueMember = "musteriID";

            comUrun.DataSource = uruncs.listUrun();
            comUrun.DisplayMember = "urunAD";
            comUrun.ValueMember = "urunID";

        }
        int ID = 0;
        public void temizle()
        {
            ID = 0;
            comMusteri.Text = String.Empty;
            comUrun.Text = String.Empty;
            txtADET.Text = String.Empty;

        }
        private void frnsiparis_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonLIST_Click(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }
        private bool KONTROL_ET()
        {
            bool DON = true;

            if (comMusteri.Text == string.Empty)
            {
                MessageBox.Show("musteri BILGISI eksik!!!!!!");
                DON = false;

                return DON;
            }


            if (comUrun.Text == string.Empty)
            {
                MessageBox.Show("URUN BILGISI eksik!!!!!!");
                DON = false;

                return DON;
            }

            if (txtADET.Text == string.Empty)
            {
                MessageBox.Show("ADET BILGISI eksik!!!!!!");
                DON = false;

                return DON;
            }
            return DON;
        }
        private void btnSepetEkle_Click(object sender, EventArgs e)
        {
            if (KONTROL_ET())
            {

                urun urun = new urun();
                urun.urunID = Convert.ToInt32(comUrun.SelectedValue.ToString());

                string[] FIYAT = uruncs.fiyat_getir(urun).Split('.');




                string STOK = uruncs.ADET_GETIR(urun);
                int STOK_INT = Convert.ToInt32(STOK);
                int Adet_INT = Convert.ToInt32(txtADET.Text);

                if (STOK_INT < Adet_INT)
                {
                    MessageBox.Show("Stok miktarı: " + STOK_INT + "Stok Miktarı Yeterli Değil");
                    return;
                }


                dataGridView1.Rows.Add(true, comUrun.SelectedValue.ToString(), comUrun
                    .Text, FIYAT[0], txtADET.Text);
            }
        }

        private void buttonTMZL_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void buttonDETAYSIL_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            DialogResult giriskontrol = MessageBox.Show("Siparisi onaylayın....", "SIPARIS ISLEMI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (giriskontrol == DialogResult.Yes)
            {
                List<siparis> siparisLİST = new List<siparis>();/////////////
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells["SEC"].Value != null)
                    {
                        if ((Boolean)row.Cells["SEC"].Value == true)
                        {
                            if (row.Cells["URUN_ID"].Value != null && row.Cells["URUN_ID"].Value.ToString() != string.Empty) //bosluk kontrolu
                            {
                                siparis siparis = new siparis();

                                siparis.musteriID = Convert.ToInt32(comMusteri.SelectedValue.ToString());
                                siparis.urunID = Convert.ToInt32(row.Cells["URUN_ID"].Value.ToString());
                               
                                siparis.adet = Convert.ToInt32(row.Cells["ADET"].Value.ToString());
                                siparis.createdate = DateTime.Now;
                                siparis.is_flag = 1;
                                siparisLİST.Add(siparis);///birincisi tablo adı ///////////////////

                               
                            }

                        }
                    }
                }

                if (siparisLİST.Count > 0)
                {
                    sipariscs scs=new sipariscs();
                   
                    scs.insert(siparisLİST);
                }

                Listele();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
