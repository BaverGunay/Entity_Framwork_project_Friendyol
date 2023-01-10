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
    public partial class frmfatura : Form
    {
        public frmfatura()
        {
            InitializeComponent();
        }
        int ID = 0;
        public void temizle()
        {
            ID = 0;
            comMUSTERID.Text = String.Empty;
            comSIPARISID.Text = String.Empty;
            comFIRMAID.Text = String.Empty;
          
        }
        public void Listele()
        {
            dataGridView1.DataSource = faturacs.listele();

            comMUSTERID.DataSource = musterics.listmusteri();
            comMUSTERID.DisplayMember = "musteriAD";
            comMUSTERID.ValueMember = "musteriID";

            comSIPARISID.DataSource = sipariscs.listSiparis();
            comSIPARISID.DisplayMember = "siparisID";
            comSIPARISID.ValueMember = "siparisID";


            comFIRMAID.DataSource = firma_bilgisics.listFirmaBilgisi();
            comFIRMAID.DisplayMember = "ad_soyad";
            comFIRMAID.ValueMember = "firmaID";
        }
        private bool kontrol_et()
        {
            bool don = true;


            if (comMUSTERID.Text == string.Empty)
            {
                MessageBox.Show("musteriID bilgisi eksik");
                don = false;

                return don;
            }
            if (comSIPARISID.Text == string.Empty)
            {
                MessageBox.Show("siparisID bilgisi eksik");
                don = false;
                return don;
            }
            if (comFIRMAID.Text == string.Empty)
            {
                MessageBox.Show("firmaID bilgisi eksik");
                don = false;
                return don;
            }
            
            return don;
        }
        private void frmfatura_Load(object sender, EventArgs e)
        {
            Listele();
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
                fatura fatura = new fatura();
                fatura.faturaID = ID;
                fatura.musteriID = Convert.ToInt32(comMUSTERID.SelectedValue);
                fatura.siparisID = Convert.ToInt32(comSIPARISID.SelectedValue);
                fatura.firmaID = Convert.ToInt32(comFIRMAID.SelectedValue);
                fatura.createdate = DateTime.Now;
                fatura.is_flag = 1;

                if (true)
                {
                    if (ID != 0)
                    {
                        DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (giriskontrol == DialogResult.Yes)
                        {
                            try
                            {
                                faturacs.update(fatura);
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
                            faturacs.insert(fatura);
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
                    fatura fatura = new fatura();
                    fatura.faturaID = ID;

                    try
                    {
                        faturacs.delete(fatura);
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

            ID = (int)dataGridView1.CurrentRow.Cells["faturaID"].Value;
            comMUSTERID.SelectedValue = dataGridView1.CurrentRow.Cells["musteriID"].Value;
            comSIPARISID.SelectedValue = dataGridView1.CurrentRow.Cells["siparisID"].Value;
            comFIRMAID.SelectedValue = dataGridView1.CurrentRow.Cells["firmaID"].Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
