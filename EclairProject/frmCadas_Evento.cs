using System;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmCadas_Evento : Form
    {
        public frmCadas_Evento()
        {
            InitializeComponent();
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