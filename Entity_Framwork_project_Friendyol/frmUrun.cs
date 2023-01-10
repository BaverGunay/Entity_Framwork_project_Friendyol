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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        int ID = 0;
        public void temizle()
        {
            comKategoriID.Text=String.Empty;
            txtUrunAD.Text=String.Empty;
            comMarkaID.Text=String.Empty;
            txtFiyat.Text=String.Empty ;
            txtStok.Text=String.Empty;
            txtAçıklama.Text = String.Empty;
        }
        public void Listele()
        {
            dataGridView1.DataSource = uruncs.listele();

            comMarkaID.DataSource = markacs.listMarka();
            comMarkaID.DisplayMember = "markaAD";
            comMarkaID.ValueMember = "markaID";

            comKategoriID.DataSource = kategorics.listKategori();
            comKategoriID.DisplayMember = "kategoriAD";
            comKategoriID.ValueMember = "kategoriID";
        }
        private void listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private bool kontrol_et()
        {
            bool don = true;


            if (comKategoriID.Text == string.Empty)
            {
                MessageBox.Show("kategoriID bilgisi eksik");
                don = false;

                return don;
            }
            if (txtUrunAD.Text==string.Empty)
            {
                MessageBox.Show("urun adı bilgisi eksik");
                don = false;
                return don;
            }
            if (comMarkaID.Text==string.Empty)
            {
                MessageBox.Show("markaID bilgisi eksik");
                don=false;
                return don;
            }
            if (txtFiyat.Text==string.Empty)
            {
                MessageBox.Show("fiyat bilgisi eksik");
                don=false;
                return don;
            }
            if (txtStok.Text==String.Empty)
            {
                MessageBox.Show("stok bilgisi eksik");
                don = false;
                return don;
            }
            if (txtAçıklama.Text==String.Empty)
            {
                MessageBox.Show("açıklama bilgisi eksik");
            }
            return don;
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if (kontrol_et())
            {
                urun urun = new urun();
                urun.urunID = ID;
                urun.kategoriID =Convert.ToInt32( comKategoriID.SelectedValue);
                urun.urunAD = txtUrunAD.Text;
                urun.markaID = Convert.ToInt32(comMarkaID.SelectedValue);
                urun.fiyat =Convert.ToDecimal( txtFiyat.Text);
                urun.stok =Convert.ToInt32( txtStok.Text);
                urun.acıklama = txtAçıklama.Text;
                urun.createdate = DateTime.Now;
                urun.is_flag = 1;
                    
                if (true)
                {
                    if (ID != 0)
                    {
                        DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (giriskontrol == DialogResult.Yes)
                        {
                            try
                            {
                                uruncs.update(urun);
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
                            uruncs.insert(urun);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ID = (int)dataGridView1.CurrentRow.Cells["urunID"].Value;
            comKategoriID.SelectedValue = dataGridView1.CurrentRow.Cells["kategoriID"].Value;
            txtUrunAD.Text = dataGridView1.CurrentRow.Cells["urunAD"].Value.ToString();
            comMarkaID.SelectedValue = dataGridView1.CurrentRow.Cells["markaID"].Value;
            txtFiyat.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells["stok"].Value.ToString();
            txtAçıklama.Text = dataGridView1.CurrentRow.Cells["acıklama"].Value.ToString();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void sil_Click(object sender, EventArgs e)
        {

            if (ID != 0)
            {
                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {
                    urun urun = new urun();
                    urun.urunID = ID;

                    try
                    {
                        uruncs.delete(urun);
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
