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
        ClasseConexao cc;
        DataSet ds;
        int x, y;
        int id;
        public frmInser_Cli(int var)
        {
            InitializeComponent();

          id = var;


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtCPF.Text);
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
                if (x == 1 && y == 1)
                {
                    DialogResult res = MessageBox.Show("Deseja inserir os campos selecionados?", "Aviso", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        string sql = string.Format("insert into cliente values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                            txtID_Cli.Text,
                            txtNome.Text,
                            txtSenha.Text,
                            txtDate_nasc.Text,
                            txtEnd.Text,
                            txtTelefone.Text,
                            txtCel.Text,
                            txtCEP.Text,
                            //txtCPF.Text,
                            txtMail.Text);

                        string sql_1 = string.Format("insert into cliente values({0}, {1})",
                            txtCPF,
                            txtRG);
                        string sql_2 = string.Format("insert into cliente values({0}, {1})",
                            txtCNPJ,
                            txtIE);
                        if (radioButton1.Checked)
                        {
                            cc = new ClasseConexao();
                            cc.executarSQL(sql_1);
                        }
                        else
                        {
                            cc = new ClasseConexao();
                            cc.executarSQL(sql_2);
                        }
                        cc = new ClasseConexao();
                        cc.executarSQL(sql);
                    }
                    else
                    {
                        MessageBox.Show("Operação Cancelada");
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
                ptbData.BackColor = Color.Green;
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

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsIE(txtIE.Text))
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
