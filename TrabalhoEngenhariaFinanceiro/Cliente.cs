using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoEngenhariaFinanceiro
{
    class Cliente
    {

        Conexao objConexao = new Conexao();
        DataTable nomeCli = new DataTable();


        public DataTable buscarNomeCli(string nome)
        {

            string consul = "select * from Cliente where nome like '" + nome + "%'";

            SqlDataAdapter dataAdp = new SqlDataAdapter(consul, objConexao.conectar());
            nomeCli.Clear();
            dataAdp.Fill(nomeCli);
            objConexao.desconectar();

            return nomeCli;
        }
    }
}
