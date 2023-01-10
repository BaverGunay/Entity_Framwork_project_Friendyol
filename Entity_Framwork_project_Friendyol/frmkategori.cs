using Entity_Framwork_project_Friendyol.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framwork_project_Friendyol
{
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }


        int ID = 0;
        public void temizle()
        {
            txtkategoriAD.Text = string.Empty;
            ID = 0;

        }
        private void Listele()
        {
            dataGridView1.DataSource = kategorics.listele();
        }
        private bool kontrol_et()
        {
            bool DON = true;


            if (txtkategoriAD.Text == string.Empty)
            {
                MessageBox.Show("AD bilgisi eksik");
                DON = false;

                return DON;
            }

            return DON;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();


        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                kategori kategori = new kategori();
                kategori.kategoriID = ID;
                kategori.kategoriAD = txtkategoriAD.Text;
                kategori.createdate = DateTime.Now;
                kategori.is_flag = 1;


                if (ID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            kategorics.update(kategori);
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
                        kategorics.insert(kategori);
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
            ID = (int)dataGridView1.CurrentRow.Cells["kategoriID"].Value;
            txtkategoriAD.Text = dataGridView1.CurrentRow.Cells["kategoriAD"].Value.ToString();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {
                    kategori kategori = new kategori();
                   kategori.kategoriID = ID;

                    try
                    {
                        kategorics.delete(kategori);
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
            private void frmkategori_Load(object sender, EventArgs e)
            {
                Listele();
            }
    } 
} 

