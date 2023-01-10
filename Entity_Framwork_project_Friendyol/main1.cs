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
    public partial class main1 : Form
    {
        public main1()
        {
            InitializeComponent();
        }
        frmyeniurun frmyeniurun = new frmyeniurun();
        private void ürünleriİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmyeniurun == null || frmyeniurun.IsDisposed)
            {
                frmyeniurun = new frmyeniurun();
                frmyeniurun.MdiParent = this;
            }
            frmyeniurun.Show();
        }
        frmsiparis frmsiparis =new frmsiparis();
        private void siparişeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsiparis == null || frmsiparis.IsDisposed)
            {
                frmsiparis = new frmsiparis();
                frmsiparis.MdiParent = this;
            }
            frmsiparis.Show();
        }
        frmyenimarka frmyenimarka=new frmyenimarka();
        private void markalarıİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmyenimarka == null || frmyenimarka.IsDisposed)
            {
                frmyenimarka = new frmyenimarka();
                frmyenimarka.MdiParent = this;
            }
            frmyenimarka.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
