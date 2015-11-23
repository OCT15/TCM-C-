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
    public partial class frmInser_Evento : Form
    {
        ClasseConexao cc;
        int id;
        public frmInser_Evento(int var)
        {
            InitializeComponent();

            id = var;

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtData.Text == "" || txtInicio.Text == "" || txtAcrescimo.Text == "")
            {
                MessageBox.Show("Por favor insira todos os dados requeridos", "Atenção!");
            }
            else
            {
                DialogResult res = MessageBox.Show("Deseja inserir os campos selecionados?", "Aviso", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    cc = new ClasseConexao();
                    string sql = string.Format("insert into evento values ({0},'{1}','{2}','{3}')",
                        txtID_Evento.Text,
                        txtData.Text,
                        txtInicio.Text,
                        txtAcrescimo.Text);
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
            }
        }

        private void frmInser_Evento_Load(object sender, EventArgs e)
        {
            txtID_Evento.Text = id.ToString();
            txtID_Evento.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtData.Text = 
            txtInicio.Text =
            txtAcrescimo.Text = "";
        }
    }
}
