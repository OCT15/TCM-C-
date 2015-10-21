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
    public partial class frmCons_Estq : Form
    {
                int var_x = 1;
        ClasseConexao cc;
        DataSet ds;
        public frmCons_Estq()
        {
            InitializeComponent();
        }
        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from produto where id_produto = {0}", txtID_Produto.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtID_Produto.Text = --var_x + "";
            }
            else
            {
                txtNome.Text = ds.Tables[0].Rows[0]["nm_produto"].ToString();
                txtPreço.Text = ds.Tables[0].Rows[0]["preço"].ToString();
                txtQuant.Text = ds.Tables[0].Rows[0]["quantidade"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["tipo_produto"].ToString();
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

        private void frmCons_Estq_Load(object sender, EventArgs e)
        {
            txtID_Produto.Text = var_x + "";
            atualizarCampos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_Produto.Text = --var_x + "";
            atualizarCampos();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            txtID_Produto.Text = ++var_x + "";
            atualizarCampos();

        }

    }
}
