using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;

namespace dal
{
    public class conexao
    {
        private static String _stringConexao =
             "Data Source=DESKTOP-0JKSDB7\\SQLEXPRESS; " +
            "Initial Catalog=pimfrotas; " +
            "Integrated Security=true;   ";
        private static SqlConnection _conexao;
        private static SqlCommand _comandoSql;
        private static SqlDataAdapter _adaptadorSql;
        private static DataTable _tabela;


        public static void executarSql(String sql)
        {
            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = sql;
            _comandoSql.ExecuteNonQuery();

            _conexao.Close();

        }
        public static void executarSql(SqlCommand comandoSql)
        {
            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            comandoSql.Connection = _conexao;
            comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }

        public static Int32 obterProximoCodigoVeiculo()
        {

            Int32 prox = 0;
            
            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "select isnull ( (max(veiid) + 1), 1) as proximo from tblveiculos";

            prox = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

            _conexao.Close();
            return prox;


        }


        public static Int32 obterProximoCodigoViagem()
        {

            Int32 prox = 0;

            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "select isnull ( (max(viaid) + 1), 1) as proximo from tblviagens";

            prox = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

            _conexao.Close();
            return prox;


        }



        public static Int32 obterProximoCodigoEspecie()
        {

            Int32 prox = 0;

            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "select isnull ( (max(espid) + 1), 1) as proximo from tblespecies";

            prox = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

            _conexao.Close();
            return prox;


        }

        public static Int32 obterProximoCodigoAnimal()
        {

            Int32 prox = 0;

            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "select isnull ( (max(aniid) + 1), 1) as proximo from tblanimais";

            prox = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

            _conexao.Close();
            return prox;


        }

        public static Int32 obterProximoCodigoMotorista()
        {

            Int32 prox = 0;

            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "select isnull ( (max(motid) + 1), 1) as proximo from tblmotoristas";

            prox = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

            _conexao.Close();
            return prox;


        }

        public static Int32 obterProximoCodigoCliente()
        {

            Int32 prox = 0;

            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "select isnull ( (max(cliid) + 1), 1) as proximo from tblclientes";

            prox = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

            _conexao.Close();
            return prox;


        }


        public static DataTable obterDados(String sql)
        {
            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = sql;

            _tabela = new DataTable();

            _adaptadorSql = new SqlDataAdapter(_comandoSql);
            _adaptadorSql.Fill(_tabela);

            _conexao.Close();

            return _tabela;



        }

       
    }

}

