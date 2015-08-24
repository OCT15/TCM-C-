using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csharp
{
    public partial class frmAdmpage : Form
    {
        public frmAdmpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimNao(" Você está prestes a deletar todo o programa, incluindo o banco de dados e histórico. Você tem certeza do que esta fazendo? ");
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimNao(" Você está prestes a deletar todos os pedidos futuros e agendados, deseja continuar? ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SimNao(" Você está prestes a deletar todo o histórico de eventos e fornecimentos, deseja continuar? ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimNao(string msg, string titulo = "Atenção")
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
    }
}
