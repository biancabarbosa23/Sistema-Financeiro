using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoEngenhariaFinanceiro
{
    class NovoTipo
    {
        Conexao objConexao = new Conexao();
        DataTable dt = new DataTable();
        string mensagem = "";

        public string cadastrar(string nome)
        {
            SqlCommand objcadastrar = new SqlCommand();
            objcadastrar.CommandText = "insert into Tipo (tipo) values (@nome)";

            objcadastrar.Parameters.AddWithValue("@nome", nome);

            try
            {
                objcadastrar.Connection = objConexao.conectar();
                objcadastrar.ExecuteNonQuery();
                objConexao.desconectar();

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }

            return mensagem;
        }

        public string excluir(string nome)
        {
            SqlCommand objExcluir = new SqlCommand();
            objExcluir.CommandText = "delete from Tipo where tipo= @nome";

            objExcluir.Parameters.AddWithValue("@nome", nome);

            try
            {
                objExcluir.Connection = objConexao.conectar();
                objExcluir.ExecuteNonQuery();
                objConexao.desconectar();


                
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }

            return mensagem;
        }

        public DataTable consultar()
        {

            string Consul = "select * from Tipo";

            dt.Clear();
            SqlDataAdapter dataAdp = new SqlDataAdapter(Consul, objConexao.conectar());
            dataAdp.Fill(dt);
            objConexao.desconectar();

            return dt;
        }

    }
}
