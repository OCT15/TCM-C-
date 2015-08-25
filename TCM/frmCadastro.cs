using System;
using System.Windows.Forms;

namespace csharp
{
    public partial class frmCadastro : Form
    {
        /// <summary>
        /// ID Atual
        /// </summary>
        private int pos = 0;
        private int lPos = 0;

        private ContatosArray cts = new ContatosArray();

        public frmCadastro()
        {
            InitializeComponent();
            atualizarCampos();
        }

        private void btnCadas_Click(object sender, EventArgs e)
        {
            // Se ele estiver tentando cadastrar um ID maior do que o próximo do que foi cadastrado, então não deixar.
            if(lPos+1 < pos)
            {
                Erro(string.Format("ID Muito Alto, Utilize {0} ao invés.\nDebug:\n\tpos: {1}\n\tlPos:{2}", lPos+1, pos, lPos));
                return;
            }
            try
            {
                cts.cadastrar(txtName.Text, txtEnd.Text, txtTel.Text, pos);
                lPos = pos;
                pos++;
                atualizarCampos();
            }
            catch(Exception err)
            {
                Erro("Limite de cadastros atingido.... ou:\n" + err.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pos - 1 < 0) return;
            pos--;
            atualizarCampos();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            pos++;
            atualizarCampos();
        }

        private void atualizarCampos()
        {
            Contato curContato = cts.get(pos);
            txtName.Text = curContato.Nome;
            txtTel.Text = curContato.Telefone;
            txtEnd.Text = curContato.Endereco;
            txtID.Text = pos + ""; // Converte o ID para uma string;
        }

        private void Erro(string msg, string titulo="Erro")
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}