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
    public partial class frmInser_Forn : Form
    {
        int var_per = 1;
        int var_con = 1;
        ClasseConexao cc;
        DataSet ds;
        public frmInser_Forn()
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "" || txtEmpresa.Text == "" || txtSite.Text == "" || txtMail.Text == "" || txtTel.Text == "" || txtCel.Text == "" || txtEnd.Text == "" || txtCEP.Text == "" || txtCNPJ.Text == "" || txtRepre.Text == "" || (radioButton1.Checked || radioButton2.Checked == false))
            {
                MessageBox.Show("Campo vazio identificado!");
            }
            else
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                if (radioButton1.Checked)
                {
                    string sql1 = string.Format("insert into fornecedor_perecivel values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}')",
                        txtID_Forn.Text,
                        txtProduto.Text,
                        txtEmpresa.Text,
                        txtEnd.Text,
                        txtTel.Text,
                        txtCel.Text,
                        txtCNPJ.Text,
                        txtCEP.Text,
                        txtMail.Text,
                        txtSite.Text,
                        txtRepre.Text);
                }
                if (radioButton2.Checked)
                {
                    string sql1 = string.Format("insert into fornecedor_consumivel values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}')",
                        txtID_Forn.Text,
                        txtProduto.Text,
                        txtEmpresa.Text,
                        txtEnd.Text,
                        txtTel.Text,
                        txtCel.Text,
                        txtCNPJ.Text,
                        txtCEP.Text,
                        txtMail.Text,
                        txtSite.Text,
                        txtRepre.Text);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID_Forn.Text =
            txtProduto.Text =
            txtEmpresa.Text =
            txtEnd.Text =
            txtTel.Text =
            txtCel.Text =
            txtCNPJ.Text =
            txtCEP.Text =
            txtMail.Text =
            txtSite.Text= 
            txtRepre.Text = "";
        }

        private void txtSite_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsSite(txtSite.Text))
            {
                ptbSite.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Formato de site incorreto");
                ptbSite.BackColor = Color.Red;
                txtSite.Text = "";
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsEmail(txtMail.Text))
            {
                ptbMail.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Formato de email incorreto");
                ptbMail.BackColor = Color.Red;
                txtMail.Text = "";
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsTel(txtTel.Text))
            {
                ptbTelefone.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Telefone incorreto");
                ptbTelefone.BackColor = Color.Red;
                txtTel.Text = "";
            }
        }

        private void txtCel_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsTel(txtCel.Text))
            {
                ptbCel.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Celular incorreto");
                ptbCel.BackColor = Color.Red;
                txtCel.Text = "";
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsCnpj(txtCNPJ.Text))
            {
                ptbCNPJ.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("CNPJ incorreto");
                ptbCNPJ.BackColor = Color.Red;
                txtCNPJ.Text = "";
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsCep(txtCEP.Text))
            {
                ptbCEP.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("CEP incorreto");
                ptbCEP.BackColor = Color.Red;
                txtCEP.Text = "";
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            txtID_Forn.Text = var_per.ToString();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            txtID_Forn.Text = var_con.ToString();
        }

        private void frmInser_Forn_Load(object sender, EventArgs e)
        {
            do
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select empresa from fornecedor_perecivel where id_fornecedor_perecivel = '" + var_per + "'");
                ds = cc.executarSQL(sql);
                if (ds.Tables[0].Rows.Count > 0) var_per++;
                else break;
            }
            while (true);
            do
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select empresa from fornecedor_consumivel where id_fornecedor_consumivel = '" + var_con + "'");
                ds = cc.executarSQL(sql);
                if (ds.Tables[0].Rows.Count > 0) var_con++;
                else break;
            }
            while (true);
        }
    }
}
