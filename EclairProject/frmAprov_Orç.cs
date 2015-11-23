using System;
using System.Data;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmAprov_Orç : Form
    {
        private int id_orcamentods;
        private int id_clienteds;
        private string nomeds;
        private string lugards;
        private string enderecods;
        private int convidadosds;
        private string temads;
        private string emailds;
        private DateTime datads;
        private DateTime horads;
        private double valords;
        private string funcionariods;
        private string aprovação;
        private int id_lugards;
        private int id_funcionariods;
        private int id_permissaods;
        private int qtd_pratosds;
        private string acrecimos;

        private DateTime dt = DateTime.Now;
        private ClasseConexao cc;
        private DataSet ds;

        public frmAprov_Orç()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = "select Orc.id_orcamento as ID, Cli.id_cliente as Cliente, Cli.nome as Nome,Lug.nome_lugar as Lugar, Lug.endereco as Endereço, Orc.num_convidados as NúmeroConvidados, Orc.tema as Tema, Orc.email_cliente as Email, Orc.dt_orcamento as DataEvento, Orc.hr_inicio as HoraInicio, Orc.valor_orcamento as Valor, Orc.acrescimos from orcamento AS Orc, lugar AS Lug, cliente AS Cli where Orc.id_orcamento = '" + txtOrça.Text + "' AND Lug.id_lugar=Orc.id_lugar AND Cli.id_cliente = Orc.id_cliente";
            ds = cc.executarSQL(sql);
            dataGridView1.DataSource = ds.Tables[0];

            string id_orcamento = ds.Tables[0].Rows[0]["ID"].ToString();
            id_orcamentods = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            id_clienteds = int.Parse(ds.Tables[0].Rows[0]["Cliente"].ToString());
            nomeds = ds.Tables[0].Rows[0]["Nome"].ToString();
            lugards = ds.Tables[0].Rows[0]["Lugar"].ToString();
            enderecods = ds.Tables[0].Rows[0]["Endereço"].ToString();
            convidadosds = int.Parse(ds.Tables[0].Rows[0]["NúmeroConvidados"].ToString());
            temads = ds.Tables[0].Rows[0]["Tema"].ToString();
            emailds = ds.Tables[0].Rows[0]["Email"].ToString();
            datads = DateTime.Parse(ds.Tables[0].Rows[0]["DataEvento"].ToString());
            horads = DateTime.Parse(ds.Tables[0].Rows[0]["HoraInicio"].ToString());
            valords = double.Parse(ds.Tables[0].Rows[0]["Valor"].ToString());
            acrecimos = ds.Tables[0].Rows[0]["acrescimos"].ToString();

            cc = new ClasseConexao();
            ds = new DataSet();
            string sql3 = "select id_lugar from lugar where nome_lugar = '" + lugards + "'";
            ds = cc.executarSQL(sql3);
            id_lugards = int.Parse(ds.Tables[0].Rows[0]["id_lugar"].ToString());

            cc = new ClasseConexao();
            ds = new DataSet();
            string sql2 = "select Pra_Evt.id_produto as ID, Prod.nm_produto as Nome, Prod.preco as Preço, Pra_Evt.qtd_produto as Quantidade FROM produto AS Prod, pratos_evento AS Pra_Evt WHERE Pra_Evt.id_orcamento =" + id_orcamento + " AND Prod.id_produto = Pra_Evt.id_produto ";
            ds = cc.executarSQL(sql2);
            dataGridView2.DataSource = ds.Tables[0];
            button2.Enabled = true;
            qtd_pratosds = ds.Tables[0].Rows.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNome.Visible == false)
            {
                txtNome.Visible = txtData.Visible = true;
                btnNext.Visible = false;
                btnAprovar.Visible = true;
                txtData.Text = dt.ToString();
                txtNome.Text = "Insira seu Nome..";
            }
            else
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = "select id_funcionario,id_permissao from funcionario where nome = '" + txtNome.Text + "'";
                ds = cc.executarSQL(sql);
                if (ds == null || ds.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("Nome do funcionário incorreto");
                    txtNome.Text = "";
                }
                else
                {
                    id_funcionariods = int.Parse(ds.Tables[0].Rows[0]["id_funcionario"].ToString());
                    id_permissaods = int.Parse(ds.Tables[0].Rows[0]["id_permissao"].ToString());

                    funcionariods = txtNome.Text;
                    DateTime var = DateTime.Parse(txtData.Text);
                    aprovação = var.ToShortDateString();

                    cc = new ClasseConexao();
                    ds = cc.executarSQL("SELECT (MAX(id_evento) + 1) AS novo_id FROM evento");
                    string id_evento = ds.Tables[0].Rows[0]["novo_id"].ToString().Trim();
                    if (id_evento == "") id_evento = "1";
                    cc = new ClasseConexao();
                    string sql2 = string.Format("INSERT INTO evento VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, '{7}', {8}, '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')",
                           id_evento,
                           id_lugards,
                           id_clienteds,
                           id_permissaods,
                           id_funcionariods,
                           valords.ToString().Replace(',', '.'),
                           convidadosds,
                           datads,
                           qtd_pratosds,
                           lugards,
                           temads,
                           emailds,
                           aprovação,
                           horads,
                           acrecimos);
                    cc.executarSQL(sql2);

                    cc = new ClasseConexao();
                    string sqlproduto = string.Format("UPDATE pratos_evento SET id_evento = {1}, id_orcamento = NULL WHERE id_orcamento = {0}",
                           id_orcamentods,
                           id_evento);
                    cc.executarSQL(sqlproduto);

                    MessageBox.Show("Operação Concluída!");
                }
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

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }
    }
}