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
    public partial class frmyenimarka : Form
    {
        public frmyenimarka()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            dataGridView1.DataSource = markacs.listele();
        }
        private void frmyenimarka_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
