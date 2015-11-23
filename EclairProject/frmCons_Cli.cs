#region (Imports)

using System;
using System.Data;
using System.Windows.Forms;

#endregion (Imports)

namespace EclairProject
{
    public partial class frmCons_Cli : Form
    {
        #region (Variables)

        private int var_x = 1;
        private ClasseConexao cc;
        private DataSet ds;

        #endregion (Variables)

        public frmCons_Cli()
        {
            InitializeComponent();
        }

        #region (Methods)

        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from cliente where id_cliente = {0}", txtID_Cli.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
<<<<<<< HEAD
                txtID_Cli.Text = --var_x + "";
=======
                txtNome.Text = txtSenha.Text =  txtEnd.Text = txtDate_nasc.Text = txtEnd.Text = txtTelefone.Text = txtCel.Text = txtCPF_CNPJ.Text = txtRG_IE.Text = txtCEP.Text = txtIdade.Text = txtMail.Text = "";
>>>>>>> origin/master
            }
            else
            {
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtCPF_CNPJ.Text = ds.Tables[0].Rows[0]["cpf_cnpj"].ToString();
                DateTime ag;
                DateTime.TryParse(ds.Tables[0].Rows[0]["dt_nascim"].ToString(), out ag);
                TimeSpan t = DateTime.Now - ag;

                txtDate_nasc.Text = ag.ToShortDateString();
                txtIdade.Text = Math.Floor(t.Days / 365d) + "";
                if (txtCPF_CNPJ.Text.Length > 15)
                {
                    lblCPF_CNPJ.Text = "CNPJ";
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                else
                {
                    lblCPF_CNPJ.Text = "CPF";
                    radioButton2.Checked = false;
                    radioButton1.Checked = true;
                }
                txtRG_IE.Text = ds.Tables[0].Rows[0]["rg_ie"].ToString();
                if (txtRG_IE.Text.Length > 12)
                {
                    lblRG_IE.Text = "IE";
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                else
                {
                    lblRG_IE.Text = "RG";
                    radioButton2.Checked = false;
                    radioButton1.Checked = true;
                }
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                if (txtCPF_CNPJ.Text.Length > 15 && txtRG_IE.Text.Length < 13 || txtCPF_CNPJ.Text.Length < 16 && txtRG_IE.Text.Length > 12)
                {
                    MessageBox.Show("Ocorreu um erro entre a designação de Pessoa Física ou Jurídica.\nPor favor reveja o cadastro em questão");
                }
            }
        }

        private void frmCons_Cli_Load(object sender, EventArgs e)
        {
            if (txtCPF_CNPJ.Text.Length > 15 && txtRG_IE.Text.Length < 13 || txtCPF_CNPJ.Text.Length < 16 && txtRG_IE.Text.Length > 12)
            {
                MessageBox.Show("Ocorreu um erro entre a designação de Pessoa Física ou Jurídica.\nPor favor reveja o cadastro em questão");
            }
            txtID_Cli.Text = var_x + "";
            atualizarCampos();
            if (txtCPF_CNPJ.Text.Length > 15)
            {
                lblCPF_CNPJ.Text = "CNPJ";
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            else
            {
                lblCPF_CNPJ.Text = "CPF";
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
            if (txtRG_IE.Text.Length > 12)
            {
                lblRG_IE.Text = "IE";
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            else
            {
                lblRG_IE.Text = "RG";
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_Cli.Text = --var_x + "";
            atualizarCampos();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            txtID_Cli.Text = ++var_x + "";
            atualizarCampos();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
<<<<<<< HEAD
=======
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
>>>>>>> origin/master
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }
    }
}

#endregion (Methods)
