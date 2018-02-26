using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Conexao_database
{
    public class ProdutoDAL
    {
        /// <summary>
        /// Método público que busca todos os produtos do banco de dados
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet BuscaTodosProdutos()
        {
            //conectando com o banco de dados
            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexaoBD"].ToString()))
            {
                //preparando o select
                StringBuilder strSelect = new StringBuilder();
                strSelect.Append("SELECT Descricao, Valores FROM Produtos ORDER BY Descricao");

                try
                {
                    //abrindo a conexao com o banco de dados
                    connection.Open();

                    //é necessário fazer um sql adapter passando os parametros (select e conexao)
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(strSelect.ToString(), connection);

                    //instanciando o dataset
                    DataSet dtSet = new DataSet();

                    //preenchendo o dataset com os dados do adapter
                    adapter.Fill(dtSet);

                    //return todos os dados dentro do dataset
                    return dtSet;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    //sempre fecha a conexao com o banco de dados
                    connection.Close();
                }
            }
        }
    }
}
