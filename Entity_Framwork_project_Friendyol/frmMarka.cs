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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        int ID = 0;
        public  void Listele()
        {
           dataGridView1.DataSource = markacs.listele();
        }
        public  void temizle()
        {
            ID = 0;
            txtMarkaAD.Text = String.Empty;
        }
        private void listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private bool kontrol_et()
        {
            bool DON = true;


            if (txtMarkaAD.Text == string.Empty)
            {
                MessageBox.Show("AD bilgisi eksik");
                DON = false;

                return DON;
            }

            return DON;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                marka marka= new marka();
                marka.markaID = ID;
                marka.markaAD= txtMarkaAD.Text;
                marka.createdate = DateTime.Now;
                marka.is_flag = 1;


                if (ID!=0)
                {

                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            markacs.update(marka);
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
                        markacs.insert(marka);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            ID = (int)dataGridView1.CurrentRow.Cells["markaID"].Value;
            txtMarkaAD.Text = dataGridView1.CurrentRow.Cells["markaAD"].Value.ToString();

        }

        private void sil_Click(object sender, EventArgs e)
        {

            if (ID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {
                    marka marka = new marka();
                    marka.markaID = ID;

                    try
                    {
                        markacs.delete(marka);
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
    }
}
