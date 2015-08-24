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
    public partial class frmCadastro : Form
    {

        int pos = 0;
        int m = 0;
        ContatosArray cts = new ContatosArray();
        int posicao;

        public frmCadastro()
        {
            InitializeComponent();

        }



        private void btnCadas_Click(object sender, EventArgs e)
        {
            try
            {
                cts.cadastra(txtName.Text, txtEnd.Text, txtTel.Text, pos);
                txtName.Text = "";
                txtEnd.Text = "";
                txtTel.Text = "";
                pos++;
            }
            catch
            {
                MessageBox.Show("Fora do range da matriz.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                cts.mostrar(m);
                m++;
            }
            catch
            {
                MessageBox.Show("Fora do range da matriz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
