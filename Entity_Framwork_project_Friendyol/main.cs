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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        frmkategori frmkategori;
        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmkategori == null || frmkategori.IsDisposed)
            {
                frmkategori = new frmkategori();
                frmkategori.MdiParent = this; //formun içinde açılcak
            }
            frmkategori.Show();
        }
        frmUrun frmUrun;
        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUrun==null||frmUrun.IsDisposed)
            {
                frmUrun = new frmUrun();
                frmUrun.MdiParent = this;
            }
            frmUrun.Show();
        }
        frmMarka frmMarka;
        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMarka == null || frmMarka.IsDisposed)
            {
                frmMarka = new frmMarka();
                frmMarka.MdiParent = this;
            }
            frmMarka.Show();
        }
        frmmusteri frmmusteri;
        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmusteri == null || frmmusteri.IsDisposed)
            {
                frmmusteri = new frmmusteri();
                frmmusteri.MdiParent = this;
            }
            frmmusteri.Show();
        }
        frmsiparis frmsiparis;
        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsiparis == null || frmsiparis.IsDisposed)
            {
                frmsiparis = new frmsiparis();
                frmsiparis.MdiParent = this;
            }
            frmsiparis.Show();
        }
        frmyorum frmyorum;
        private void yorumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmyorum == null || frmyorum.IsDisposed)
            {
                frmyorum = new frmyorum();
                frmyorum.MdiParent = this;
            }
            frmyorum.Show();
        }
        frmkargo frmkargo;
        private void kargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmkargo == null || frmkargo.IsDisposed)
            {
                frmkargo = new frmkargo();
                frmkargo.MdiParent = this;
            }
            frmkargo.Show();
        }
        frmfatura frmfatura;
        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmfatura == null || frmfatura.IsDisposed)
            {
                frmfatura = new frmfatura();
                frmfatura.MdiParent = this;
            }
            frmfatura.Show();
        }
        frmfirmaBilgisi frmfirmaBilgisi;
        private void firmaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmfirmaBilgisi == null || frmkargo.IsDisposed)
            {
                frmfirmaBilgisi = new frmfirmaBilgisi();
                frmfirmaBilgisi.MdiParent = this;
            }
            frmfirmaBilgisi.Show();
        }
    }
}
