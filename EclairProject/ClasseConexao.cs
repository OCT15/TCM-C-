using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclairProject
{
    class ClasseConexao
    {
        private SqlConnection conexao = new SqlConnection();
        private SqlConnection conectar()
        {
            try
            {
                String strConexao = "Password =pfjd10; Persist Security Info=True; User ID=sa; Initial Catalog=eclair; Data Source=" + Environment.MachineName;
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("[SQL Connect Error]" + ex.Message);
                desconectar();
                return null;
            }
        }
        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch            { }
        }
        public DataSet executarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("[SQL Error] " + e.Message + "\nSQL:" + comando_sql);
                return null;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
