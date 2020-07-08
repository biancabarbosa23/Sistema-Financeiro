using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrabalhoEngenhariaFinanceiro
{
    class DarBaixaPagar
    {
        Conexao objConexao = new Conexao();
        string mensagem = "";

        public string darBaixa(string idTitulo, string dataPag, string valorPago, string comp_Valor)
        {
            SqlCommand objbaixa = new SqlCommand();
            objbaixa.CommandText = "update TituloPagar set dataPagamento = @dataPag ,valorPago = @valorPago, situacao = @situacao " +
                "where IdTitulo = @idTitulo";

            objbaixa.Parameters.AddWithValue("@dataPag", dataPag);
            objbaixa.Parameters.AddWithValue("@valorPago", valorPago);
            objbaixa.Parameters.AddWithValue("@idTitulo", idTitulo);

            if (comp_Valor == "MENOR")
            {
                objbaixa.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "EM ABERTO";
            }
            else
            {
                objbaixa.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "PAGO";
            }

            try
            {
                objbaixa.Connection = objConexao.conectar();
                objbaixa.ExecuteNonQuery();
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
            DataTable dt_p = new DataTable();

            string Consulta_p = "select f.nome, t.IdTitulo, t.descricao, t.dataEmissao, t.dataVenc," +
                  "t.valor, ti.tipo, t.situacao, t.valorPago, t.dataPagamento from TituloPagar t, Fornecedor f, Tipo ti " +
                  "where f.IdForn = t.idForn and ti.Id = t.tipo and situacao = 'EM ABERTO' order by t.dataVenc";

            dt_p.Clear();
            SqlDataAdapter dataAd = new SqlDataAdapter(Consulta_p, objConexao.conectar());
            dataAd.Fill(dt_p);
            objConexao.desconectar();

            return dt_p;
        }

        public string excluir(string idTitulo)
        {
            SqlCommand alterarP = new SqlCommand();

            alterarP.CommandText = "update TituloPagar " +
                "set dataPagamento = null, valorPago = null, situacao = @situacao" +
                " where IdTitulo = @idTitulo";

            alterarP.Parameters.AddWithValue("@idTitulo", idTitulo);
            alterarP.Parameters.Add("@situacao", SqlDbType.VarChar).Value = "EM ABERTO";

            try
            {
                alterarP.Connection = objConexao.conectar();
                alterarP.ExecuteNonQuery();
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
