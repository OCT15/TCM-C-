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
<<<<<<< HEAD
                txtNome.Text = txtSenha.Text = txtDate_nascView.Text = txtIdade.Text = txtMail.Text = txtTelefoneView.Text = txtCelView.Text = txtEnd.Text = txtCPF_CNPJView.Text = txtRG_IEView.Text = txtCEPView.Text = "";
=======
                txtNome.Text = txtSenha.Text = txtDate_nasc.Text = txtIdade.Text = txtMail.Text = txtTelefone.Text = txtCel.Text = txtEnd.Text = txtCPF.Text = txtRG_IE.Text = txtCEP.Text = "";
>>>>>>> origin/master
            }
            else
            {
                txtID_Cli.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
<<<<<<< HEAD
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtTelefoneView.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCelView.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtCPF_CNPJView.Text = ds.Tables[0].Rows[0]["cpf_cnpj"].ToString();
                txtRG_IEView.Text = ds.Tables[0].Rows[0]["rg_ie"].ToString();
                txtCEPView.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                DateTime ag;
                DateTime.TryParse(ds.Tables[0].Rows[0]["dt_nascim"].ToString(), out ag);
                TimeSpan t = DateTime.Now - ag;

                txtDate_nascView.Text = ag.ToShortDateString();
                txtIdade.Text = Math.Floor(t.Days / 365d) + "";
                
                if (txtCPF_CNPJView.Text.Length > 17)
                {
                    lblCPF.Text = "CNPJ";
                }
                else
                {
                    lblCPF.Text = "CPF";
                }
                if (txtRG_IEView.Text.Length > 14)
                {
                    lblRG_IE.Text = "IE";
                }
                else
                {
                    lblRG_IE.Text = "RG";
                }
=======
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf_cnpj"].ToString();
                txtRG_IE.Text = ds.Tables[0].Rows[0]["rg_ie"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
>>>>>>> origin/master
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
<<<<<<< HEAD
            txtDate_nasc.Visible = true;
            txtTelefone.Visible = true;
            txtCPF.Visible = true;
            txtRG.Visible = true;
            txtCel.Visible = true;
=======
            txtDate_nasc.Enabled = true;
            txtTelefone.Enabled = true;
            txtCel.Enabled = true;
>>>>>>> origin/master
            txtEnd.Enabled = true;
            txtCEPView.Enabled = true;
            txtMail.Enabled = true;
            btnAlterar2.Visible = true;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtNome.Text == "" || txtSenha.Text == "" || txtDate_nascView.Text == "" || txtMail.Text == "" || txtTelefoneView.Text == "" || txtCelView.Text == "" || txtEnd.Text == "" || txtCPF_CNPJView.Text == "" || txtRG_IEView.Text == "" || txtCEPView.Text == "")
            {
                MessageBox.Show("Campos vazios detectados");
=======
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
>>>>>>> origin/master
            }
            else
            {
                DialogResult res = MessageBox.Show("Deseja alterar o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string sql = string.Format("UPDATE cliente SET nome = '{0}', senha = '{1}', dt_nascim = '{2}', endereco = '{3}', telefone = '{4}', celular = '{5}', cep = '{6}', cpf_cnpj = '{7}', rg_ie = '{8}', email = '{9}' where id_cliente = {10}",
                        txtNome.Text,
                        txtSenha.Text,
                        txtDate_nascView.Text,
                        txtEnd.Text,
                        txtTelefoneView.Text,
                        txtCelView.Text,
                        txtCEPView.Text,
                        txtCPF_CNPJView.Text,
                        txtRG_IEView.Text,
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
                txtDate_nascView.Enabled = false;
                txtTelefoneView.Enabled = false;
                txtCelView.Enabled = false;
                txtEnd.Enabled = false;
                txtCEPView.Enabled = false;
                txtMail.Enabled = false;
                btnAlterar2.Visible = false;
                btnExcluir.Enabled = true;
            }
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

<<<<<<< HEAD
        private void txtDate_nasc_Leave(object sender, EventArgs e)
        {
            DateTime ag;
            DateTime.TryParse(txtDate_nascView.Text, out ag);
            TimeSpan t = DateTime.Now - ag;
            txtIdade.Text = Math.Floor(t.Days / 365d) + "";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            txtCPF.Visible = true;
            txtRG.Visible = true;
            txtCNPJ.Text = "";
            txtCNPJ.Visible = false;
            txtIE.Text = "";
            txtIE.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            txtCNPJ.Visible = true;
            txtIE.Visible = true;
            txtCPF.Text = "";
            txtCPF.Visible = false;
            txtRG.Text = "";
            txtRG.Visible = false;
        }
=======
>>>>>>> origin/master
        }
    }
