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
    public partial class frmmusteri : Form
    {
        public frmmusteri()
        {
            InitializeComponent();
        }
        public  void Listele()
        {
            dataGridView1.DataSource = musterics.listele();
        }
        int ID = 0;
        public void temizle()
        {
            ID = 0;
            txtAdSoyad.Text = String.Empty;
            txtEmail.Text=String.Empty;
            txtTelefon.Text = String.Empty;
            richTextBoxADRES.Text = String.Empty;
            comSehir.Text = String.Empty;
            comUlke.Text = String.Empty;

        }

        private void frmmusteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }
        private bool kontrol_et()
        {
            bool don = true;


            if (txtAdSoyad.Text == string.Empty)
            {
                MessageBox.Show("adsoyad bilgisi eksik");
                don = false;

                return don;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Email bilgisi eksik");
                don = false;
                return don;
            }
            if (txtTelefon.Text == string.Empty)
            {
                MessageBox.Show("telefon bilgisi eksik");
                don = false;
                return don;
            }
            if (richTextBoxADRES.Text == string.Empty)
            {
                MessageBox.Show("adres bilgisi eksik");
                don = false;
                return don;
            }
            if (comSehir.Text == String.Empty)
            {
                MessageBox.Show("şehir bilgisi eksik");
                don = false;
                return don;
            }
            if (comUlke.Text == String.Empty)
            {
                MessageBox.Show("ÜLKE bilgisi eksik");
            }
            return don;
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                musteri musteri = new musteri();
                musteri.musteriID = ID;
                musteri.adSoyad = txtAdSoyad.Text;
                musteri.ulke = comUlke.Text;
                musteri.sehir = comSehir.Text;
                musteri.adres = richTextBoxADRES.Text;
                musteri.telefon = txtTelefon.Text;
                musteri.e_mail = txtEmail.Text;

                musteri.createdate = DateTime.Now;
                musteri.is_flag = 1;
                if (checkBox1.Checked==true)
                {
                    musteri.is_Admin = 1;
                }
                else
                {
                    musteri.is_Admin = 0;
                }

                if (true)
                {
                    if (ID != 0)
                    {
                        DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (giriskontrol == DialogResult.Yes)
                        {
                            try
                            {
                                musterics.update(musteri);
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
                            musterics.insert(musteri);
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

        private void sil_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {
                    musteri musteri = new musteri();
                    musteri.musteriID = ID;

                    try
                    {
                        musterics.delete(musteri);
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
            ID = (int)dataGridView1.CurrentRow.Cells["musteriID"].Value;
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adSoyad"].Value.ToString();
            comUlke.SelectedValue = dataGridView1.CurrentRow.Cells["ulke"].Value;
            comSehir.SelectedValue = dataGridView1.CurrentRow.Cells["sehir"].Value;
            richTextBoxADRES.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["e_mail"].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
