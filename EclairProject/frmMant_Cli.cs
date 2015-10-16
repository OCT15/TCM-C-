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
    public partial class frmMant_Cli : Form
    {
        Persist pr;
        ClasseConexao cc;
        DataSet ds;
        public frmMant_Cli()
        {
            InitializeComponent();
        }

        private void frmTeste_Load(object sender, EventArgs e)
        {
            pr = new Persist();
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from cliente where id_cliente like '" + pr.getId()+"'");
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtNome.Text = txtSenha.Text = txtEnd.Text = txtDate_nasc.Text = txtEnd.Text = txtTelefone.Text = txtCel.Text = txtCPF.Text = txtCEP.Text = txtIdade.Text = txtMail.Text = "";
            }
            else
            {
                txtID_Cli.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtIdade.Enabled = true;
            txtDate_nasc.Enabled = true;
            txtTelefone.Enabled = true;
            txtCel.Enabled = true;
            txtEnd.Enabled = true;
            txtCPF.Enabled = true;
            txtCEP.Enabled = true;
            txtMail.Enabled = true;
            btnAlterar2.Visible = true;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo nome está vazio!");
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo senha está vazio!");
            }
            if (txtIdade.Text == "")
            {
                MessageBox.Show("O campo idade está vazio!");
            }
            if (txtDate_nasc.Text == "")
            {
                MessageBox.Show("O campo nascimento está vazio!");
            }
            if (txtTelefone.Text == "")
            {
                MessageBox.Show("O campo telefone está vazio!");
            }
            if (txtCel.Text == "")
            {
                MessageBox.Show("O campo celular está vazio!");
            }
            if (txtEnd.Text == "")
            {
                MessageBox.Show("O campo endereço está vazio!");
            }
            if (txtCPF.Text == "")
            {
                MessageBox.Show("O campo CPF está vazio!");
            }
            if (txtCEP.Text == "")
            {
                MessageBox.Show("O campo CEP está vazio!");
            }
            if (txtMail.Text == "")
            {
                MessageBox.Show("O campo email está vazio!");
            }

            DialogResult res = MessageBox.Show("Deseja alterar o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Format("UPDATE cliente SET nome = '{0}', senha = '{1}', idade = '{2}', dt_nascim = '{3}', endereco = '{4}', telefone = '{5}', celular = '{6}', cep = '{7}', cpf = '{8}', email = '{9}' where id_cliente = {10}",
                    txtNome.Text,
                    txtSenha.Text,
                    txtIdade.Text,
                    txtDate_nasc.Text,
                    txtEnd.Text,
                    txtTelefone.Text,
                    txtCel.Text,
                    txtCEP.Text,
                    txtCPF.Text,
                    txtMail.Text,
                    txtID_Cli.Text);
                cc = new ClasseConexao();
                cc.executarSQL(sql);
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtIdade.Enabled = false;
            txtDate_nasc.Enabled = false;
            txtTelefone.Enabled = false;
            txtCel.Enabled = false;
            txtEnd.Enabled = false;
            txtCPF.Enabled = false;
            txtCEP.Enabled = false;
            txtMail.Enabled = false;
            btnAlterar2.Visible = false;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Format("delete from cliente where id_cliente = {0}", txtID_Cli.Text);
                cc = new ClasseConexao();
                cc.executarSQL(sql);
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }
