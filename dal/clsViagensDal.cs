using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using dto;

namespace dal
{
    class clsViagensDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readerSql;


        public List<dto.clsVeiculoDto> obterListaTotal()
        {
            try
            {
                List<dto.clsVeiculoDto> lista = new List<dto.clsVeiculoDto>();
                dto.clsVeiculoDto item;



                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText = "select veiid, " +
                                          "       veinome " +
                                          "  from tblveiculos";
                _readerSql = _comandoSql.ExecuteReader();

                while (_readerSql.Read())
                {
                    item = new dto.clsVeiculoDto();
                    item.Codigo = Int32.Parse(_readerSql["veiid"].ToString());
                    item.Nome = _readerSql["veinome"].ToString();


                    /* Carregamento da lista de 
                     * combustíveis do veiculo*/


                    lista.Add(item);
                }


                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("DLL > " + ex.Message);
            }
        }

    }
}
