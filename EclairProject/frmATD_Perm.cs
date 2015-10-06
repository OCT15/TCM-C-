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
    public partial class frmATD_Perm : Form
    {
        public frmATD_Perm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCons_Cli_Click(object sender, EventArgs e)
        {
            frmCons_Cli fCC = new frmCons_Cli();
            fCC.Show();
            fCC.Location = new Point(448, 133);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesq_Cli fPC = new frmPesq_Cli();
            fPC.Show();
            fPC.Location = new Point(448, 133);
        }
    }
}
