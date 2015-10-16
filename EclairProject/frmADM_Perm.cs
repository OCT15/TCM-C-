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
            if (Application.OpenForms.OfType<frmCons_Func>().Count() > 0)
            {

            }
            else
            {
                frmCons_Func fCF = new frmCons_Func();
                fCF.Location = new Point(443, 133);
                fCF.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesq_Func>().Count() > 0)
            {

            }
            else
            {
                frmPesq_Func fPF = new frmPesq_Func();
                fPF.Location = new Point(443, 133);
                fPF.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }
    }
}
