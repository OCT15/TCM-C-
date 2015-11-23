using System;
using System.Data;
using System.Data.SqlClient;

namespace EclairProject
{
    internal class ClasseConexao
    {
        private SqlConnection conexao = new SqlConnection();

        private SqlConnection conectar()
        {
            try
            {
                String strConexao = "Password =12345; Persist Security Info=True; User ID=sa; Initial Catalog=eclair; Data Source=" + Environment.MachineName + "\\SQLEXPRESS";
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
            catch { }
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
            catch (Exception e)
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