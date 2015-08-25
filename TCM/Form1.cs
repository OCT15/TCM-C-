using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp
{
    
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        public void formMain_Load(object sender, EventArgs e)
        {
            frmLogin fg = new frmLogin(btnAdm);
            fg.ShowDialog(); /* .Show não trava a tela; .ShowDialog trava a tela até o form ( fg em questão ) ser fechado */
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin fg = new frmLogin(btnAdm);
            fg.ShowDialog(); /* .Show não trava a tela; .ShowDialog trava a tela até o form ( fg em questão ) ser fechado */
        }

        private void criarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cd = new frmCadastro();
            cd.Show();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            frmAdmpage ap = new frmAdmpage();
            ap.Show();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
