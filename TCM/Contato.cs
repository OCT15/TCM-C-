using System.Windows.Forms;

namespace csharp
{
    class Contato
    {
        #region Propiedades
        /// <summary>
        /// Nome do Contato
        /// </summary>
        public string Nome;

        /// <summary>
        /// Endereço do contato
        /// </summary>
        public string Endereco;
        
        /// <summary>
        /// Telefone do contato
        /// </summary>
        public string Telefone;

        /// <summary>
        /// Contato vazio(para comparação)
        /// </summary>
        public static Contato Empty = new Contato("", "", "");
        #endregion

        #region Construtores
        /// <summary>
        /// Novo contato
        /// </summary>
        /// <param name="nom">Nome do contato</param>
        /// <param name="end">Endereço do contato</param>
        /// <param name="tel">Telefone do contato</param>
        public Contato(string nom, string end, string tel)
        {
            // Passa os parâmetros para as propiedades do contato.
            Nome = nom; Endereco = end; Telefone = tel;
        }
        /// <summary>
        /// Novo contato vazio(pode ser cadastrado depois)
        /// </summary>
        public Contato() {}
        #endregion

        #region Métodos
        /// <summary>
        /// Cadastra uma pessoa neste Contato
        /// </summary>
        /// <param name="nom">Nome da pessoa</param>
        /// <param name="end">Endereço da pessoa</param>
        /// <param name="tel">Telefone da pessoa</param>
        public void cadastrar(string nom, string end, string tel)
        {
            // Passa os parâmetros para as propiedades do contato.
            Nome = nom; Endereco = end; Telefone = tel;
        }

        public void mostrar()
        {
            MessageBox.Show(ToString(), "Contato", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public override string ToString()
        {
            return string.Format("Nome: {0}\nTelefone:{1}\nEndereço:{2}", Nome, Telefone, Endereco);
        }
        #endregion
    }
}
