using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoEngenhariaFinanceiro
{
    class TituloReceber
    {
        Conexao objConexao = new Conexao();
        DataTable dt = new DataTable();
        public String mensagem = "";

        public String cadastrarReceber(string idCliente, string descricao,
                                        string dataEmissao, string dataVenc, string valor, string tipo)
        {
            SqlCommand cadastrar = new SqlCommand();

            cadastrar.CommandText = "insert into TituloReceber (idCliente,descricao, dataEmissao, dataVenc,valor, tipo, situacao, dataPagamento, valorPago ) " +
                "values (@idCliente , @descricao, @dataEmissao, @dataVenc, @valor, @tipo, @situacao, null, null)";

            cadastrar.Parameters.AddWithValue("@idCliente", idCliente);
            cadastrar.Parameters.AddWithValue("@descricao", descricao);
            cadastrar.Parameters.AddWithValue("@dataEmissao", dataEmissao);
            cadastrar.Parameters.AddWithValue("@dataVenc", dataVenc);
            cadastrar.Parameters.AddWithValue("@valor", valor);
            cadastrar.Parameters.AddWithValue("@tipo", tipo);
            cadastrar.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "EM ABERTO";

            try
            {
                cadastrar.Connection = objConexao.conectar();
                cadastrar.ExecuteNonQuery();
                objConexao.desconectar();


                this.mensagem = "Título A Receber cadastrado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }

            return mensagem;

        }



        public string excluirReceber(string id_Titulo)
        {
            SqlCommand excluir = new SqlCommand();

            excluir.CommandText = "delete from TituloReceber where IdTitulo = @id_Titulo";

            excluir.Parameters.AddWithValue("@id_Titulo", id_Titulo);

            try
            {
                excluir.Connection = objConexao.conectar();
                excluir.ExecuteNonQuery();
                objConexao.desconectar();
                this.mensagem = "Titulo a Receber excluido com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }

            return mensagem;

        }

        public string alterarReceber(string idTitulo, string idCliente, string descricao,
                                        string dataEmissao, string dataVenc, string valor, string tipo)
        {
            SqlCommand alterar = new SqlCommand();

            alterar.CommandText = "update TituloReceber " +
                "set idCliente = @idCliente,descricao = @descricao, dataEmissao = @dataEmissao," +
                " dataVenc = @dataVenc ,valor = @valor, tipo = @tipo where IdTitulo = @idTitulo";

            alterar.Parameters.AddWithValue("@idCliente", idCliente);
            alterar.Parameters.AddWithValue("@descricao", descricao);
            alterar.Parameters.AddWithValue("@dataEmissao", dataEmissao);
            alterar.Parameters.AddWithValue("@dataVenc", dataVenc);
            alterar.Parameters.AddWithValue("@valor", valor);
            alterar.Parameters.AddWithValue("@tipo", tipo);
            alterar.Parameters.AddWithValue("@idTitulo", idTitulo);
            

            try
            {
                alterar.Connection = objConexao.conectar();
                alterar.ExecuteNonQuery();
                objConexao.desconectar();
                this.mensagem = "Titulo a Receber alterado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }


            return mensagem;
        }

        public DataTable consultarReceber()
        {

            string Consul = "select t.IdTitulo, t.idCliente, t.descricao, t.dataEmissao, t.dataVenc," +
                  "t.valor, ti.tipo, c.nome, t.dataPagamento, t.valorPago, t.situacao from TituloReceber t, Cliente c , Tipo ti " +
                  "where c.IdCliente = t.idCliente and t.tipo = ti.Id";

            dt.Clear();
            SqlDataAdapter dataAdp = new SqlDataAdapter(Consul, objConexao.conectar());
            dataAdp.Fill(dt);
            objConexao.desconectar();

            return dt;
        }

    }
}
