using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoEngenhariaFinanceiro
{
    class Fornecedor
    {
        Conexao objConexao = new Conexao();
        DataTable nomeForn = new DataTable();
       

        public DataTable buscarNomeForn(string nome)
        {

            string consul = "select * from Fornecedor where nome like '" + nome + "%'";

            SqlDataAdapter dataAdp = new SqlDataAdapter(consul, objConexao.conectar());
            nomeForn.Clear();
            dataAdp.Fill(nomeForn);
            objConexao.desconectar();

            return nomeForn;
        }


    }
}
