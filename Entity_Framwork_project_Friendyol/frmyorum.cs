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
    public partial class frmyorum : Form
    {
        public frmyorum()
        {
            InitializeComponent();
        }

        int ID = 0;
        public void temizle()
        {
            comSiparisID.Text = string.Empty;
            comYorum.Text = string.Empty;
            ID = 0;

        }
        private void Listele()
        {
            dataGridView1.DataSource = yorumcs.listele();

            comSiparisID.DataSource=sipariscs.listSiparis();
            comSiparisID.DisplayMember = "siparisID";
            comSiparisID.ValueMember = "siparisID";


        }
        private bool kontrol_et()
        {
            bool DON = true;


            if (comSiparisID.Text == string.Empty)
            {
                MessageBox.Show("siparisID bilgisi eksik");
                DON = false;

                return DON;
            }
            if (comYorum.Text == string.Empty)
            {
                MessageBox.Show("yorum bilgisi eksik");
                DON = false;

                return DON;
            }

            return DON;
        }

        private void frmyorum_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void LİSTELE_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void EKLE_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                yorumlar yorumlar = new yorumlar();
                yorumlar.yorumID = ID;
                yorumlar.siparisID =Convert.ToInt32( comSiparisID.SelectedValue);
                yorumlar.yorum = comYorum.Text;
                yorumlar.createdate = DateTime.Now;
                yorumlar.is_flag = 1;


                if (ID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            yorumcs.update(yorumlar);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("HATA : " + ex);
                        }

                    }
                }
                else
                {
                    try
                    {
                        yorumcs.insert(yorumlar);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("HATA : " + ex);
                    }
                }
                temizle();
                Listele();
            }
        }

        private void SİL_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {
                    yorumlar yorumlar = new yorumlar();
                    yorumlar.yorumID = ID;

                    try
                    {
                        yorumcs.delete(yorumlar);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HATA: " + ex);

                    }
                    temizle();
                    Listele();
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            ID = (int)dataGridView1.CurrentRow.Cells["yorumID"].Value;
            comSiparisID.SelectedValue = dataGridView1.CurrentRow.Cells["siparisID"].Value;
            comYorum.Text = dataGridView1.CurrentRow.Cells["yorum"].Value.ToString();

        }
    }
}
