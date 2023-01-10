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
    public partial class frmfirmaBilgisi : Form
    {
        public frmfirmaBilgisi()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView1.DataSource = firma_bilgisics.listele();
        }
        int ID = 0;
        public void temizle()
        {
            ID = 0;
            txtAD_SOYAD.Text = String.Empty;
            txtADRES.Text = String.Empty;
            txtTELEFON.Text = String.Empty;
            txtEMAİL.Text = String.Empty;
         
        }
        private bool kontrol_et()
        {
            bool don = true;


            if (txtAD_SOYAD.Text == string.Empty)
            {
                MessageBox.Show("adsoyad bilgisi eksik");
                don = false;

                return don;
            }
            if (txtADRES.Text == string.Empty)
            {
                MessageBox.Show("adres bilgisi eksik");
                don = false;
                return don;
            }
            if (txtTELEFON.Text == string.Empty)
            {
                MessageBox.Show("telefon bilgisi eksik");
                don = false;
                return don;
            }
            if (txtEMAİL.Text == string.Empty)
            {
                MessageBox.Show("adres bilgisi eksik");
                don = false;
                return don;
            }
           
            return don;
        }
        private void frmfirmaBilgisi_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void btnLİSTELE_Click(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                firma_Bilgisi firma_Bilgisi = new firma_Bilgisi();
                firma_Bilgisi.firmaID = ID;
                firma_Bilgisi.ad_soyad = txtAD_SOYAD.Text;
                firma_Bilgisi.adres = txtADRES.Text;
                firma_Bilgisi.telefon = txtTELEFON.Text;
                firma_Bilgisi.e_mail = txtEMAİL.Text;
                firma_Bilgisi.createdate = DateTime.Now;
                firma_Bilgisi.is_flag = 1;

                if (true)
                {
                    if (ID != 0)
                    {
                        DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (giriskontrol == DialogResult.Yes)
                        {
                            try
                            {
                                firma_bilgisics.update(firma_Bilgisi);
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
                            firma_bilgisics.insert(firma_Bilgisi);
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
        }
        private void btnSİL_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {
                    firma_Bilgisi firma_Bilgisi = new firma_Bilgisi();
                    firma_Bilgisi.firmaID = ID;

                    try
                    {
                        firma_bilgisics.delete(firma_Bilgisi);
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
            ID = (int)dataGridView1.CurrentRow.Cells["firmaID"].Value;
            txtAD_SOYAD.Text = dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
            txtADRES.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtTELEFON.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtEMAİL.Text = dataGridView1.CurrentRow.Cells["e_mail"].Value.ToString();
        }

        
    }
}
