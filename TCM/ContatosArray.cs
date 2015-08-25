using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace csharp
{
    class ContatosArray
    {
        /// <summary>
        /// Lista de contatos.
        /// </summary>
        private List<Contato> contatos = new List<Contato>();

        /// <summary>
        /// Cadastra um novo contato
        /// </summary>
        /// <param name="name">Nome do contato</param>
        /// <param name="ender">Endereço do contato</param>
        /// <param name="telef">Telefone do contato</param>
        public void cadastrar(String name, String ender, String telef, int pos)
        {
            // Cria um novo Contato e o adiciona a List na posição pos.
            contatos.Insert(pos, new Contato(name, ender, telef));
        }

        /// <summary>
        ///  Mostrar o cadastro em um MessageBox
        /// </summary>
        /// <param name="pos"></param>
        public void mostrar(int pos)
        {
            Contato ret = contatos.ElementAtOrDefault(pos);
            if (ret != null)
            {
                ret.mostrar();
            }
            else
            {
                MessageBox.Show("Nenhum contato encontrado na posição " + pos + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Contato get(int pos)
        {
            // Pega o elemento na posição pos (se não existir retorna null)
            Contato ret = contatos.ElementAtOrDefault(pos);

            // Se for null, retorna um Contato vazio, senão retorna o contato registrado
            return (ret != null ? ret : Contato.Empty);
        }
    }
}