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
            DateTime ag;
            DateTime.TryParse(txtDate_nasc.Text, out ag);
            TimeSpan t = DateTime.Now - ag;
            txtIdade.Text = Math.Floor(t.Days / 365d) + "";
            pr = new Persist();
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from cliente where id_cliente like '" + pr.getId()+"'");
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtNome.Text = txtSenha.Text = txtDate_nasc.Text = txtIdade.Text = txtMail.Text = txtTelefone.Text = txtCel.Text = txtEnd.Text = txtCPF.Text = txtRG_IE.Text = txtCEP.Text = "";
            }
            else
            {
                txtID_Cli.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf_cnpj"].ToString();
                txtRG_IE.Text = ds.Tables[0].Rows[0]["rg_ie"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
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
            if (txtNome.Text == "" || txtSenha.Text == "" || txtIdade.Text == "" || txtDate_nasc.Text == "" || txtTelefone.Text == "" || txtCel.Text == "" || txtEnd.Text == "" || txtCEP.Text == "" || txtMail.Text == "")
            {
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
