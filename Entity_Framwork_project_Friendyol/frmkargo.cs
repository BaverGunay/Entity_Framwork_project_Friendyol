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
    public partial class frmkargo : Form
    {
        public frmkargo()
        {
            InitializeComponent();
        }
        int ID = 0;
        public void temizle()
        {
            txtKargoAD.Text = string.Empty;
            txtKargoTel.Text = string.Empty;
            ID = 0;

        }
        private void Listele()
        {
            dataGridView1.DataSource = kargocs.listele();
        }
        private bool kontrol_et()
        {
            bool DON = true;


            if (txtKargoAD.Text == string.Empty)
            {
                MessageBox.Show("AD bilgisi eksik");
                DON = false;

                return DON;
            }
            if (txtKargoTel.Text == string.Empty)
            {
                MessageBox.Show("telefon bilgisi eksik");
                DON = false;

                return DON;
            }

            return DON;
        }
        private void frmkargo_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void LİSTELE_Click(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void EKLE_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                kargo kargo = new kargo();
                kargo.kargoID = ID;
                kargo.kargoAD = txtKargoAD.Text;
                kargo.kargoTEL = txtKargoTel.Text;
                kargo.createdate = DateTime.Now;
                kargo.is_flag = 1;


                if (ID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            kargocs.update(kargo);
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
                        kargocs.insert(kargo);
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
                    kargo kargo = new kargo();
                    kargo.kargoID = ID;

                    try
                    {
                        kargocs.delete(kargo);
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
            ID = (int)dataGridView1.CurrentRow.Cells["kargoID"].Value;
            txtKargoAD.Text = dataGridView1.CurrentRow.Cells["kargoAD"].Value.ToString();
            txtKargoTel.Text = dataGridView1.CurrentRow.Cells["kargoTel"].Value.ToString();

        }
    }
}
