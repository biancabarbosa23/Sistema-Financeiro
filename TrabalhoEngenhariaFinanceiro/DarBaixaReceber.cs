using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoEngenhariaFinanceiro
{
    class DarBaixaReceber
    {
        Conexao objConexao = new Conexao();
        string mensagem = "";

        public string darBaixa(string idTitulo, string dataPag, string valorPago, string comp_Valor)
        {
            SqlCommand objbaixaR = new SqlCommand();
            objbaixaR.CommandText = "update TituloReceber set dataPagamento = @dataPag ,valorPago = @valorPago, situacao = @situacao " +
                "where IdTitulo = @idTitulo";

            objbaixaR.Parameters.AddWithValue("@dataPag", dataPag);
            objbaixaR.Parameters.AddWithValue("@valorPago", valorPago);
            objbaixaR.Parameters.AddWithValue("@idTitulo", idTitulo);

            if (comp_Valor == "MENOR")
            {
                objbaixaR.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "EM ABERTO";
            }
            else
            {
                objbaixaR.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "PAGO";
            }

            try
            {
                objbaixaR.Connection = objConexao.conectar();
                objbaixaR.ExecuteNonQuery();
                objConexao.desconectar();

                this.mensagem = "Baixa efetuada com Sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }


            return mensagem;
        }

        public DataTable consultar()
        {
            DataTable dt_r = new DataTable();

            string Consulta_r = "select c.nome, t.IdTitulo, t.descricao, t.dataEmissao, t.dataVenc," +
                  "t.valor, ti.tipo, t.situacao, t.valorPago, t.dataPagamento from TituloReceber t, Cliente c, Tipo ti " +
                  "where c.IdCliente = t.idCliente and ti.Id = t.tipo and situacao = 'EM ABERTO' order by t.dataVenc";

            dt_r.Clear();
            SqlDataAdapter dataAdp = new SqlDataAdapter(Consulta_r, objConexao.conectar());
            dataAdp.Fill(dt_r);
            objConexao.desconectar();

            return dt_r;
        }


        public string excluir(string idTitulo)
        {
            SqlCommand alterarR = new SqlCommand();

            alterarR.CommandText = "update TituloReceber " +
                "set dataPagamento = null, valorPago = null, situacao = @situacao" +
                " where IdTitulo = @idTitulo";

            alterarR.Parameters.AddWithValue("@idTitulo", idTitulo);
            alterarR.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "EM ABERTO";

            try
            {
                alterarR.Connection = objConexao.conectar();
                alterarR.ExecuteNonQuery();
                objConexao.desconectar();
                this.mensagem = "Baixa excluida com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar ao Banco de Dados" + e;

            }


            return mensagem;
        }

    }
}
