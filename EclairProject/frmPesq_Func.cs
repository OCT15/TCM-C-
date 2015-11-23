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
    public partial class frmPesq_Func : Form
    {
        Persist pr;
        ClasseConexao cc;
        DataSet ds;
        int var; 

        public frmPesq_Func()
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira algo no campo para pesquisar na lista de clientes");
                dataGridView1.DataSource = "";
            }
            else
            {
                cc = new ClasseConexao();
                ds = new DataSet();
<<<<<<< HEAD
                string sql = ("select Func.id_funcionario as ID, Func.nome as Nome, Func.senha as Senha, Func.dt_nascim as Nascimento, Func.endereco as Endereço, Func.telefone as Telefone, Func.celular as Celular, Func.cep as Cep, Func.cpf as CPF, Func.rg as RG, Func.email as Email from funcionario as Func where Func.id_funcionario like '" + textBox1.Text + "' or nome = '" + textBox1.Text + "' or senha = '" + textBox1.Text + "' or dt_nascim like '" + textBox1.Text + "' or endereco = '" + textBox1.Text + "' or telefone = '" + textBox1.Text + "' or celular = '" + textBox1.Text + "' or cep = '" + textBox1.Text + "' or cpf = '" + textBox1.Text + "' or rg = '" + textBox1.Text + "' or email = '" + textBox1.Text + "'");
=======
                string sql = ("select * from funcionario where id_funcionario like '" + textBox1.Text + "' or nome = '" + textBox1.Text + "' or senha = '" + textBox1.Text + "' or dt_nascim like '" + textBox1.Text + "' or endereco = '" + textBox1.Text + "' or telefone = '" + textBox1.Text + "' or celular = '" + textBox1.Text + "' or cep = '" + textBox1.Text + "' or cpf = '" + textBox1.Text + "' or rg = '" + textBox1.Text + "' or email = '" + textBox1.Text + "'");
>>>>>>> origin/master
                ds = cc.executarSQL(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            var = 1;

            do
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select nome from funcionario where id_funcionario = '" + var + "'");
                ds = cc.executarSQL(sql);
                if (ds.Tables[0].Rows.Count > 0) var++;
                else break;
            }
            while (true);

<<<<<<< HEAD
            frmInser_Func fIF = new frmInser_Func(var);
            fIF.Show();
            fIF.Location = new Point(448, 133);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
=======
            frmInser_Cli fIC = new frmInser_Cli(var);
            fIC.Show();
            fIC.Location = new Point(448, 133);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
>>>>>>> origin/master
        {
            pr = new Persist();
            int r = e.RowIndex, // e > argumentos de evento                     ^
            c = e.ColumnIndex;
<<<<<<< HEAD
            if (r < 0 || c < 0)
            {

            }
            else
            {
                string v1 = dataGridView1.Rows[r].Cells[0].Value.ToString();
                if (v1 == "") { }
                else
                {
                    pr.setId(v1);
                    this.Close();
                    frmMant_Func fMF = new frmMant_Func();
                    fMF.Location = new Point(443, 133);
                    fMF.ShowDialog();
                }
            }
        }

        private void frmPesq_Func_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Pesquisa de Funcionário...";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnProcurar_Click(sender, e);
            }
        }
=======
            string v1 = dataGridView1.Rows[r].Cells[0].Value.ToString();
            pr.setId(v1);
            frmMant_Func fT = new frmMant_Func();
            fT.Show();
            fT.Location = new Point(448, 133);
        }

>>>>>>> origin/master
    }
}
