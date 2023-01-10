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
    public partial class frmyeniurun : Form
    {
        public frmyeniurun()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void Listele()
        {
            dataGridView1.DataSource = uruncs.listele();
        }
        private void frmyeniurun_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
