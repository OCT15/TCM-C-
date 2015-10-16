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
    public partial class Aulableh : Form
    {
        ClasseConexao cc;
        DataSet ds;
        public Aulableh()
        {
            InitializeComponent();
        }
        private void fagundes()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            ds = cc.executarSQL("select * from funcionario");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void mariana()
        {
            //permite personalizar o grid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //altera o nome das colunas
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "usuario";
            dataGridView1.Columns[2].HeaderText = "telefone";
            dataGridView1.Columns[3].HeaderText = "rg";
            dataGridView1.Columns[4].HeaderText = "cpf";
            //grid.Columns[3].HeaderText = "PREÇO UNITÁRIO";
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 80;
            //formata a coluna para moeda (currency)
            //grid.Columns[3].DefaultCellStyle.Format = "c";
            //ao clicar, seleciona a linha inteira
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            dataGridView1.MultiSelect = false;
            // exibe vazio no lugar de null
            //dataGridView1.DefaultCellStyle.NullValue = "";
            //Expande a célula automáticamente
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //alinha à direita os campos moeda
            //grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        string v1 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string v2 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string sql = "insert into contatos (nome,telefone) values ('" + v1 + "','" + v2 + "')";
                        cc = new ClasseConexao();
                        ds = new DataSet();
                        ds = cc.executarSQL(sql);
                    }
                }
                fagundes();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao inserir"+erro.ToString());
            }
        }

        private void Aulableh_Load(object sender, EventArgs e)
        {
            fagundes();
            mariana();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = dataGridView1.Rows.Count - 2;
            string v1 = dataGridView1.Rows[max].Cells[1].Value.ToString();
            string v2 = dataGridView1.Rows[max].Cells[2].Value.ToString();
            string sql = "inser into contatos(nome,telefone) values ('" + v1 + "', '" + v2 + "')";
            cc = new ClasseConexao();
            ds = new DataSet();
            ds = cc.executarSQL(sql);
                fagundes();
        }
    }
}
