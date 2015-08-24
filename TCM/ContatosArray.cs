using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp
{
    class ContatosArray
    {
        String[] nome = new String[10];
        String[] endereco = new String[10];
        String[] telefone = new String[10];

        public void cadastra(String name, String ender, String telef, int pos)
        {
            nome[pos] = name;
            endereco[pos] = ender;
            telefone[pos] = telef;


        }
        public void mostrar(int pos)
        {
            MessageBox.Show("Nome: " + nome[pos] + "\n" + "Endereço: " + endereco[pos] + "\n" + "Telefone: " + telefone[pos]);
        }

    }
}
