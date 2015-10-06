using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmADM_Perm : Form
    {
        public frmADM_Perm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCons_Func_Click(object sender, EventArgs e)
        {
            frmCons_Func fCF = new frmCons_Func();
            fCF.Show();
            fCF.Location = new Point(448, 133);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmPesq_Func fPF = new frmPesq_Func();
            fPF.Show();
            fPF.Location = new Point(448, 133);
        }
    }
}
