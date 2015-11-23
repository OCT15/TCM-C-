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
    public partial class frmCons_Forn_Perc : Form
    {
        int var_x = 1;
        ClasseConexao cc;
        DataSet ds;
        public frmCons_Forn_Perc()
        {
            InitializeComponent();
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

        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = "select Frn.*,Prd.nm_produto from fornecedor_perecivel AS Frn, produto AS Prd where Frn.id_fornecedor_perecivel = '"+txtID_Forn.Text+"' AND Prd.id_produto = Frn.id_produto";
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtID_Forn.Text = --var_x + "";
            }
            else
            {
                txtProduto.Text = ds.Tables[0].Rows[0]["nm_produto"].ToString();
                txtEmpresa.Text = ds.Tables[0].Rows[0]["empresa"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtTel.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtCNPJ.Text = ds.Tables[0].Rows[0]["cnpj"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtSite.Text = ds.Tables[0].Rows[0]["website"].ToString();
                txtRepre.Text = ds.Tables[0].Rows[0]["representante"].ToString();
            }
        }

        private void frmCons_Forn_Perc_Load(object sender, EventArgs e)
        {
            txtID_Forn.Text = var_x + "";
            atualizarCampos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_Forn.Text = --var_x + "";
            atualizarCampos();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            txtID_Forn.Text = ++var_x + "";
            atualizarCampos();
        }
    }
}

