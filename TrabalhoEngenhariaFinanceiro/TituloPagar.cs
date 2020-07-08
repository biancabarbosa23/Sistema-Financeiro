using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoEngenhariaFinanceiro
{
    public class TituloPagar
    {
       
            Conexao objConexao = new Conexao();
            DataTable dt = new DataTable();        
            public String mensagem ="";
        

        public String cadastrarPagar(string idForn, string descricao, 
                                        string dataEmissao , string dataVenc, string valor, string tipo)
        {
            SqlCommand cadastrar = new SqlCommand();

            cadastrar.CommandText = "insert into TituloPagar (idForn,descricao, dataEmissao, dataVenc,valor, tipo, situacao, dataPagamento, valorPago) " +
                "values (@idForn , @descricao, @dataEmissao, @dataVenc, @valor, @tipo, @situacao, null, null)";

            cadastrar.Parameters.AddWithValue("@idForn", idForn);
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
                

                this.mensagem = "Título cadastrado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }

            return mensagem;
           
        }

        

        public string excluirPagar(string id_Titulo)
        {
            SqlCommand excluir = new SqlCommand();

            excluir.CommandText = "delete from TituloPagar where IdTitulo = @id_Titulo";

            excluir.Parameters.AddWithValue("@id_Titulo", id_Titulo);

            try
            {
                excluir.Connection = objConexao.conectar();
                excluir.ExecuteNonQuery();
                objConexao.desconectar();
                this.mensagem = "Titulo excluido com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }

            return mensagem;

        }

        public string alterarPagar(string idTitulo, string idForn, string descricao,
                                        string dataEmissao, string dataVenc, string valor, string tipo)
        {
            SqlCommand alterar = new SqlCommand();

            alterar.CommandText = "update TituloPagar " +
                "set idForn = @idForn,descricao = @descricao, dataEmissao = @dataEmissao," +
                " dataVenc = @dataVenc ,valor = @valor, tipo = @tipo" +
                " where IdTitulo = @idTitulo";

            alterar.Parameters.AddWithValue("@idForn", idForn);
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
                this.mensagem = "Titulo alterado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }


            return mensagem;
        }

        public DataTable consultarPagar()
        {

            string Consul = "select t.IdTitulo, t.idForn, t.descricao, t.dataEmissao, t.dataVenc," +
                  "t.valor, ti.tipo, f.nome, t.dataPagamento, t.valorPago, t.situacao from TituloPagar t, Fornecedor f, Tipo ti " +
                  "where f.IdForn = t.idForn and ti.Id = t.tipo";

                dt.Clear();
                SqlDataAdapter dataAdp = new SqlDataAdapter(Consul, objConexao.conectar());
                dataAdp.Fill(dt);
                objConexao.desconectar();

                return dt;
        }

    }
}
