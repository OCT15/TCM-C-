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
    public partial class frmCons_Cli : Form
    {
        int var_x = 1;
        ClasseConexao cc;
        DataSet ds;
        public frmCons_Cli()
        {
            InitializeComponent();
        }
        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from cliente where id_cliente = {0}", txtID_Cli.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtNome.Text = txtSenha.Text =  txtEnd.Text = txtDate_nasc.Text = txtEnd.Text = txtTelefone.Text = txtCel.Text = txtCPF.Text = txtCEP.Text = txtIdade.Text = txtMail.Text = "";
            }
            else
            {
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
        private void frmCons_Cli_Load(object sender, EventArgs e)
        {
            txtID_Cli.Text = var_x + "";
            atualizarCampos();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

      /*  private void btnPesquisar_cli_Click(object sender, EventArgs e)
        {
            frmPesquisar cB = new frmPesquisar();
            cB.ShowDialog();*/
        }
    }
