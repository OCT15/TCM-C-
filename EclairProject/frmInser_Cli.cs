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
    public partial class frmInser_Cli : Form
    {
        DataSet ds;
        ClasseConexao cc;
        int x, y;
        int id;
        public frmInser_Cli(int var)
        {
            InitializeComponent();

          id = var;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (txtCPF.Text.Replace(".","").Replace ("-", "") == "")
                {
                    MessageBox.Show("Por favor insira seu CPF","Atenção!");
                }
                if (txtRG.Text == "")
                {
                    MessageBox.Show("Por favor insira seu RG", "Atenção!");
                }
                else
                {
                    x = 1;
                }
            }
            else
            {
                if (txtCNPJ.Text == "")
                {
                    MessageBox.Show("Por favor insira seu CNPJ", "Atenção!");
                }
                if (txtIE.Text == "")
                {
                    MessageBox.Show("Por favor insira seu IE", "Atenção!");
                }
                else
                {
                    y = 1;
                }
            }
            if (txtNome.Text == "" || txtSenha.Text == "" || txtIdade.Text == "" || txtDate_nasc.Text == "" || txtTelefone.Text == "" || txtCel.Text == "" || txtEnd.Text == "" || txtCEP.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Por favor insira todos os dados requeridos", "Atenção!");
            }
            else
            {
                if (x == 1 || y == 1)
                {
                    if (radioButton1.Checked)
                    {
                        string sqlrB1 = ("select id_cliente from cliente where cpf_cnpj ='" + txtCPF.Text + "'");
                        cc = new ClasseConexao();
                        ds = new DataSet();
                        ds = cc.executarSQL(sqlrB1);
                    }
                    if (radioButton2.Checked)
                    {
                        string sqlrB2 = ("select id_cliente from cliente where cpf_cnpj ='" + txtCNPJ.Text + "'");
                        cc = new ClasseConexao();
                        ds = new DataSet();
                        ds = cc.executarSQL(sqlrB2);
                    }

                    if (ds.Tables[0].Rows.Count < 1)
                    {
                        DialogResult res = MessageBox.Show("Deseja inserir os campos selecionados?", "Aviso", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            string sql = string.Format("insert into cliente values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                txtID_Cli.Text,
                                txtNome.Text,
                                txtSenha.Text,
                                txtDate_nasc.Text,
                                txtEnd.Text,
                                txtTelefone.Text,
                                txtCel.Text,
                                txtCEP.Text,
                                radioButton2.Checked ? txtCNPJ.Text : txtCPF.Text,
                                radioButton2.Checked ? txtIE.Text : txtRG.Text,
                                txtMail.Text);
                            cc = new ClasseConexao();
                            cc.executarSQL(sql);
                            MessageBox.Show("Operação Sucedida!");
                            txtNome.Text =
txtSenha.Text =
txtEnd.Text =
txtDate_nasc.Text =
txtEnd.Text = txtTelefone.Text =
txtCel.Text =
txtCPF.Text =
txtCEP.Text =
txtIE.Text =
txtCNPJ.Text =
txtIdade.Text =
txtMail.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Operação Cancelada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo CPF ou o campo CNPJ já estão sendo utilizados");
                        string a = "";
                        foreach (int field in ds.Tables[0].Rows)
                        {
                            a += field + "\n";
                        }
                        a += ds.Tables[0].Rows.Count;
                        MessageBox.Show(a);
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = 
            txtSenha.Text = 
            txtEnd.Text = 
            txtDate_nasc.Text =
            txtEnd.Text = txtTelefone.Text = 
            txtCel.Text = 
            txtCPF.Text = 
            txtCEP.Text = 
            txtIE.Text =
            txtCNPJ.Text =
            txtIdade.Text = 
            txtMail.Text = "";
        }

        private void frmInser_Cli_Load(object sender, EventArgs e)
        {
            txtID_Cli.Text = id.ToString();
            txtID_Cli.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (ClasseValida.IsCpf(txtCPF.Text))
                {
                    ptbCPF.BackColor = Color.MediumTurquoise;
                }
                else
                {
                    MessageBox.Show("CPF inválido");
                    ptbCPF.BackColor = Color.Red;
                    txtCPF.Text = "";
                }
            }
        }

        private void txtDate_nasc_Leave(object sender, EventArgs e)
        {
            if(ClasseValida.Data(txtDate_nasc.Text))
            {
                ptbData.BackColor = Color.MediumTurquoise;
                DateTime ag;
                DateTime.TryParse(txtDate_nasc.Text, out ag);
                TimeSpan t = DateTime.Now - ag;
                txtIdade.Text = Math.Floor(t.Days / 365d) + "";
                if (int.Parse(txtIdade.Text) < 18)
                {
                    MessageBox.Show("Você não tem a idade mínima permitida ou a data está incorreta", "Atenção");
                    txtIdade.Text = txtDate_nasc.Text = "";
                    ptbData.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Data inválida");
                ptbData.BackColor = Color.Red;
                txtCPF.Text = "";
            }
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }

        private void frmInser_Cli_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            lblCPF_CNPJ.Text = "CPF";
            lblRG_IE.Text = "RG";
            txtCNPJ.Visible = false;
            txtCPF.Visible = true;
            txtRG.Visible = true;
            txtIE.Visible = false;
            txtCNPJ.Text = "";
            txtIE.Text = "";
            
            ptbCPF.BackColor = Color.Transparent;
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lblCPF_CNPJ.Text = "CNPJ";
            lblRG_IE.Text = "IE";
            txtCPF.Visible = false;
            txtCNPJ.Visible = true;
            txtRG.Visible = false;
            txtIE.Visible = true;
            txtCPF.Text = "";
            txtRG.Text = "";

            ptbCPF.BackColor = Color.Transparent;
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (ClasseValida.IsCnpj(txtCNPJ.Text))
                {
                    ptbCPF.BackColor = Color.MediumTurquoise;
                }
                else
                {
                    MessageBox.Show("CNPJ inválido");
                    ptbCPF.BackColor = Color.Red;
                    txtCPF.Text = "";
                }
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
                MessageBox.Show("Email inválido");
                ptbMail.BackColor = Color.Red;
                txtMail.Text = "";
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsTel(txtTelefone.Text))
            {
                ptbTelefone.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Telefone inválido");
                ptbTelefone.BackColor = Color.Red;
                txtTelefone.Text = "";
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
                MessageBox.Show("Telefone inválido");
                ptbCel.BackColor = Color.Red;
                txtCel.Text = "";
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
                MessageBox.Show("CEP inválido");
                ptbCEP.BackColor = Color.Red;
                txtCEP.Text = "";
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsIE(txtRG.Text))
            {
                ptbRG.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("RG inválido");
                ptbRG.BackColor = Color.Red;
                txtRG.Text = "";
            }
        }

        private void txtIE_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsIE(txtIE.Text))
            {
                ptbRG.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("IE inválido");
                ptbRG.BackColor = Color.Red;
                txtRG.Text = "";
            }
        }


        }
    }
