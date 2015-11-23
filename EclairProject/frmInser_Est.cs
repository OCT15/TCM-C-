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
    public partial class frmInser_Est : Form
    {
        ClasseConexao cc;
        int id;
        public frmInser_Est(int var)
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

        private void frmInser_Est_Load(object sender, EventArgs e)
        {
            txtID_Produto.Text = id.ToString();
            txtID_Produto.Enabled = false;
            txtTipo.Text = " consumivel/perecivel ";
            txtPreço.Text = "0.00";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtPreço.Text == "" || txtQuant.Text == "" || txtTipo.Text == "") { MessageBox.Show("Insira valores em todas as tabelas"); }
            else
            {
                DialogResult res = MessageBox.Show("Deseja inserir os campos selecionados?", "Aviso", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    txtPreço.Text = txtPreço.Text.Replace(",", ".");
                    if (txtTipo.Text == "consumivel" || txtTipo.Text == "perecivel")
                    {
                        string sql = string.Format("insert into produto values ({0},'{1}','{2}','{3}','{4}')",
                        txtID_Produto.Text,
                        txtNome.Text,
                        txtPreço.Text,
                        txtQuant.Text,
                        txtTipo.Text);
                        cc = new ClasseConexao();
                        cc.executarSQL(sql);
                        MessageBox.Show("Operação Sucedida!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tipo de produto incompativel!");
                        txtTipo.Text = "";
                    }
                    
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtPreço.Text = txtQuant.Text = txtTipo.Text = "";
        }

        private void txtTipo_Click(object sender, EventArgs e)
        {
            txtTipo.Text = "";
        }

        private void txtPreço_Click(object sender, EventArgs e)
        {
            txtPreço.Text = "";
        }
    }
}
