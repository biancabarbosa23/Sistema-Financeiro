using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
using iTextSharp.text.html;

namespace TrabalhoEngenhariaFinanceiro
{
    class ConsultaComplexa
    {
        Conexao objConexao = new Conexao();
        DataTable dt_Receber = new DataTable();
        DataTable dt_Pagar = new DataTable();

        string mensagemP = "", mensagemR = "";

        public DataTable ConsultarPagar(string nome, string dataInicio, string dataFinal , string pago, string parcial, string aberto)
        {
            string consulta = null;

            string padrao = "select t.IdTitulo , f.nome , t.descricao, t.dataEmissao, t.dataVenc, ti.tipo, t.Valor," +
                " t.situacao, t.valorPago from TituloPagar t, Fornecedor f, Tipo ti where f.IdForn = t.idForn and t.tipo = ti.Id ";

            consulta = padrao;

            if (nome != null)
            {
                string consul_Nome = "and f.nome like '" + nome + "%' ";
                consulta = consulta + consul_Nome;
            }
            if(dataInicio != null && dataFinal == null )
            {
                string consul_DataInicio = "and t.dataVenc = '" + dataInicio +"' ";
                consulta = consulta + consul_DataInicio;
                
            }
            if(dataFinal != null  && dataInicio != null)
            {
                string consul_DataFinal = "and t.dataVenc between '" + dataInicio + "' and '" + dataFinal + "' ";
                consulta = consulta + consul_DataFinal;
            }
            if (pago != null && parcial == null && aberto == null)
            {
                string consul_Pago = "and t.situacao = 'PAGO' ";
                consulta = consulta + consul_Pago;
            }
            if(parcial != null && aberto == null && pago == null)
            {
                string consul_Parcial = "and t.situacao = 'EM ABERTO' and t.valorPago is not null ";
                consulta = consulta + consul_Parcial;

            }
            if(aberto != null && parcial == null & pago == null)
            {
                string consul_Aberto = "and t.situacao = 'EM ABERTO' and t.valorPago is null ";
                consulta = consulta + consul_Aberto;
            }
            


            SqlDataAdapter dataAdp = new SqlDataAdapter(consulta, objConexao.conectar());
            dt_Pagar.Clear();
            dataAdp.Fill(dt_Pagar);
            objConexao.desconectar();

            return dt_Pagar;
        }

        public DataTable ConsultarReceber(string nomeCliente, string dataInicioR , string dataFinalR, string pagoR, string parcialR, string abertoR)
        {
            string consulta = null;

            string padrao = "select t.IdTitulo , c.nome , t.descricao, t.dataEmissao, t.dataVenc, ti.tipo, t.Valor," +
                " t.situacao, t.valorPago from TituloReceber t, Cliente c, Tipo ti where c.IdCliente = t.idCliente and t.tipo = ti.Id ";

            consulta = padrao;

            if (nomeCliente != null)
            {
                string consul_Nome = "and c.nome like '" + nomeCliente + "%' ";
                consulta = consulta + consul_Nome;
            }
            if (dataInicioR != null && dataFinalR == null)
            {
                string consul_DataInicio = "and t.dataVenc = '" + dataInicioR + "' ";
                consulta = consulta + consul_DataInicio;

            }
            if (dataFinalR != null && dataInicioR != null)
            {
                string consul_DataFinal = "and t.dataVenc between '" + dataInicioR + "' and '" + dataFinalR + "' ";
                consulta = consulta + consul_DataFinal;
            }
            if (pagoR != null && parcialR == null && abertoR == null)
            {
                string consul_Pago = "and t.situacao = 'PAGO' ";
                consulta = consulta + consul_Pago;
            }
            if (parcialR != null && abertoR == null && pagoR == null)
            {
                string consul_Parcial = "and t.situacao = 'EM ABERTO' and t.valorPago is not null ";
                consulta = consulta + consul_Parcial;

            }
            if (abertoR != null && parcialR == null & pagoR == null)
            {
                string consul_Aberto = "and t.situacao = 'EM ABERTO' and t.valorPago is null ";
                consulta = consulta + consul_Aberto;
            }



            SqlDataAdapter dataAdp = new SqlDataAdapter(consulta, objConexao.conectar());
            dt_Receber.Clear();
            dataAdp.Fill(dt_Receber);
            objConexao.desconectar();

            return dt_Receber;
        }

        public string relatorioReceber()
        {
            Document doc = new Document(PageSize.A4.Rotate());
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();


            string caminho = @"C:\Users\Bianc\Desktop\Fatec\4° semestre\ESIII\Relatórios\TítuloaReceber" + "Relatorio.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            doc.AddHeader("Header", DateTime.Now.ToString());

            string dados = "";

            Paragraph cabecalho = new Paragraph(dados,
            new Font(Font.NORMAL, 10));
            cabecalho.Alignment = Element.ALIGN_RIGHT;
            cabecalho.Add(DateTime.Now.ToString());
            doc.Add(cabecalho);

            Paragraph pular = new Paragraph(dados,
            new Font(Font.NORMAL, 14));
            pular.Alignment = Element.ALIGN_CENTER;
            pular.Add("        ");
            doc.Add(pular);

            Paragraph paragrafo = new Paragraph(dados,
            new Font(Font.NORMAL, 16, Font.BOLD));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Relatório de Titulo A Receber");
            doc.Add(paragrafo);

            Paragraph risco = new Paragraph(dados,
            new Font(Font.NORMAL, 3));
            pular.Alignment = Element.ALIGN_CENTER;
            pular.Add("   ");
            doc.Add(pular);


            int cols = dt_Receber.Columns.Count;
            int rows = dt_Receber.Rows.Count;


            PdfPTable pdfTable = new PdfPTable(cols);

            PdfPCell celulaCodigo = new PdfPCell(new Phrase("Codigo", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaCodigo.BackgroundColor = new BaseColor(135, 206, 235);
            celulaCodigo.BorderColor = BaseColor.WHITE;
            PdfPCell celulaNome = new PdfPCell(new Phrase("Nome", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaNome.BorderColor = BaseColor.WHITE;
            celulaNome.BackgroundColor = new BaseColor(173, 216, 230);
            PdfPCell celulaDescr = new PdfPCell(new Phrase("Descricao", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaDescr.BackgroundColor = new BaseColor(135, 206, 235);
            celulaDescr.BorderColor = BaseColor.WHITE;
            PdfPCell celulaDataEmissao = new PdfPCell(new Phrase("Data Emissão", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaDataEmissao.BackgroundColor = new BaseColor(173, 216, 230);
            celulaDataEmissao.BorderColor = BaseColor.WHITE;
            PdfPCell celulaDataVen = new PdfPCell(new Phrase("Data Vencimento", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaDataVen.BackgroundColor = new BaseColor(135, 206, 235);
            celulaDataVen.BorderColor = BaseColor.WHITE;
            PdfPCell celulaTipo = new PdfPCell(new Phrase("Tipo", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaTipo.BackgroundColor = new BaseColor(173, 216, 230);
            celulaTipo.BorderColor = BaseColor.WHITE;
            PdfPCell celulaValor = new PdfPCell(new Phrase("Valor", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaValor.BackgroundColor = new BaseColor(135, 206, 235);
            celulaValor.BorderColor = BaseColor.WHITE;
            PdfPCell celulaSitu = new PdfPCell(new Phrase("Situação", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaSitu.BackgroundColor = new BaseColor(173, 216, 230);
            celulaSitu.BorderColor = BaseColor.WHITE;
            PdfPCell celulaValorP = new PdfPCell(new Phrase("Valor Pago", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaValorP.BackgroundColor = new BaseColor(135, 206, 235);
            celulaValorP.BorderColor = BaseColor.WHITE;

            pdfTable.AddCell(celulaCodigo);
            pdfTable.AddCell(celulaNome);
            pdfTable.AddCell(celulaDescr);
            pdfTable.AddCell(celulaDataEmissao);
            pdfTable.AddCell(celulaDataVen);
            pdfTable.AddCell(celulaTipo);
            pdfTable.AddCell(celulaValor);
            pdfTable.AddCell(celulaSitu);
            pdfTable.AddCell(celulaValorP);

            decimal soma = 0;

            for (int k = 0; k < rows; k++) { 
                for (int j = 0; j < cols; j++)
                {
                    PdfPCell cellRows = new PdfPCell();
                    Font RowFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    if (j == 3 || j==4)
                    {
                        string date = DateTime.Parse(dt_Receber.Rows[k][j].ToString()).ToString("dd/MM/yyyy");
                        Chunk chunkRows = new Chunk(date.ToString(), RowFont);
                        cellRows.Phrase = new Phrase(chunkRows);
                    }
                    else
                    {
                        Chunk chunkRows = new Chunk(dt_Receber.Rows[k][j].ToString(), RowFont);
                        cellRows.Phrase = new Phrase(chunkRows);
                    }

                    int par = j % 2;
                    if(par == 0)
                    {
                        cellRows.BackgroundColor = new BaseColor(135, 206, 235);
                    }
                    else
                    {
                        cellRows.BackgroundColor = new BaseColor(173, 216, 230);
                    }

                    cellRows.BorderColor = BaseColor.WHITE;

                    if (j== 6)
                    {
                        soma = soma + decimal.Parse(dt_Receber.Rows[k][j].ToString());
                    }
                    
                    pdfTable.AddCell(cellRows);
                }
            }
           

            doc.Add(pdfTable);

            Paragraph valor = new Paragraph(dados,
            new Font(Font.NORMAL, 14, Font.BOLD));
            valor.Alignment = Element.ALIGN_RIGHT;
            valor.Add("TOTAL: R$ " + soma.ToString());
            doc.Add(valor);


            doc.Close();

            mensagemR = "Relatorio Titulo a Receber foi gerado com sucesso";

            return mensagemR;
        }

        public string relatorioPagar()
        {
            Document doc = new Document(PageSize.A4.Rotate());
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();


            string caminho = @"C:\Users\Bianc\Desktop\Fatec\4° semestre\ESIII\Relatórios\TítuloaPagar" + "Relatorio.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            doc.AddHeader("Header", DateTime.Now.ToString());

            string dados = "";

            Paragraph cabecalho = new Paragraph(dados,
            new Font(Font.NORMAL, 10));
            cabecalho.Alignment = Element.ALIGN_RIGHT;
            cabecalho.Add(DateTime.Now.ToString());
            doc.Add(cabecalho);

            Paragraph pular = new Paragraph(dados,
            new Font(Font.NORMAL, 14));
            pular.Alignment = Element.ALIGN_CENTER;
            pular.Add("        ");
            doc.Add(pular);

            Paragraph paragrafo = new Paragraph(dados,
            new Font(Font.NORMAL, 16, Font.BOLD));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Relatório de Titulo A Pagar");
            doc.Add(paragrafo);

            Paragraph risco = new Paragraph(dados,
            new Font(Font.NORMAL, 3));
            pular.Alignment = Element.ALIGN_CENTER;
            pular.Add("   ");
            doc.Add(pular);


            int cols = dt_Pagar.Columns.Count;
            int rows = dt_Pagar.Rows.Count;


            PdfPTable pdfTable = new PdfPTable(cols);

            PdfPCell celulaCodigo = new PdfPCell(new Phrase("Codigo", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaCodigo.BackgroundColor = new BaseColor(135, 206, 235);
            celulaCodigo.BorderColor = BaseColor.WHITE;
            PdfPCell celulaNome = new PdfPCell(new Phrase("Fornecedor", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaNome.BorderColor = BaseColor.WHITE;
            celulaNome.BackgroundColor = new BaseColor(173, 216, 230);
            PdfPCell celulaDescr = new PdfPCell(new Phrase("Descricao", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaDescr.BackgroundColor = new BaseColor(135, 206, 235);
            celulaDescr.BorderColor = BaseColor.WHITE;
            PdfPCell celulaDataEmissao = new PdfPCell(new Phrase("Data Emissão", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaDataEmissao.BackgroundColor = new BaseColor(173, 216, 230);
            celulaDataEmissao.BorderColor = BaseColor.WHITE;
            PdfPCell celulaDataVen = new PdfPCell(new Phrase("Data Vencimento", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaDataVen.BackgroundColor = new BaseColor(135, 206, 235);
            celulaDataVen.BorderColor = BaseColor.WHITE;
            PdfPCell celulaTipo = new PdfPCell(new Phrase("Tipo", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaTipo.BackgroundColor = new BaseColor(173, 216, 230);
            celulaTipo.BorderColor = BaseColor.WHITE;
            PdfPCell celulaValor = new PdfPCell(new Phrase("Valor", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaValor.BackgroundColor = new BaseColor(135, 206, 235);
            celulaValor.BorderColor = BaseColor.WHITE;
            PdfPCell celulaSitu = new PdfPCell(new Phrase("Situação", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaSitu.BackgroundColor = new BaseColor(173, 216, 230);
            celulaSitu.BorderColor = BaseColor.WHITE;
            PdfPCell celulaValorP = new PdfPCell(new Phrase("Valor Pago", new Font(Font.NORMAL, 11, Font.BOLD)));
            celulaValorP.BackgroundColor = new BaseColor(135, 206, 235);
            celulaValorP.BorderColor = BaseColor.WHITE;

            pdfTable.AddCell(celulaCodigo);
            pdfTable.AddCell(celulaNome);
            pdfTable.AddCell(celulaDescr);
            pdfTable.AddCell(celulaDataEmissao);
            pdfTable.AddCell(celulaDataVen);
            pdfTable.AddCell(celulaTipo);
            pdfTable.AddCell(celulaValor);
            pdfTable.AddCell(celulaSitu);
            pdfTable.AddCell(celulaValorP);

            decimal soma = 0;

            for (int k = 0; k < rows; k++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PdfPCell cellRows = new PdfPCell();
                    Font RowFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    if (j == 3 || j == 4)
                    {
                        string date = DateTime.Parse(dt_Pagar.Rows[k][j].ToString()).ToString("dd/MM/yyyy");
                        Chunk chunkRows = new Chunk(date.ToString(), RowFont);
                        cellRows.Phrase = new Phrase(chunkRows);
                    }
                    else
                    {
                        Chunk chunkRows = new Chunk(dt_Pagar.Rows[k][j].ToString(), RowFont);
                        cellRows.Phrase = new Phrase(chunkRows);
                    }

                    int par = j % 2;
                    if (par == 0)
                    {
                        cellRows.BackgroundColor = new BaseColor(135, 206, 235);
                    }
                    else
                    {
                        cellRows.BackgroundColor = new BaseColor(173, 216, 230);
                    }

                    cellRows.BorderColor = BaseColor.WHITE;

                    if (j == 6)
                    {
                        soma = soma + decimal.Parse(dt_Pagar.Rows[k][j].ToString());
                    }

                    pdfTable.AddCell(cellRows);
                }
            }


            doc.Add(pdfTable);

            Paragraph valor = new Paragraph(dados,
            new Font(Font.NORMAL, 14, Font.BOLD));
            valor.Alignment = Element.ALIGN_RIGHT;
            valor.Add("TOTAL: R$ " + soma.ToString());
            doc.Add(valor);


            doc.Close();

            mensagemP = "Relatorio Titulo a Pagar foi gerado com sucesso";

            return mensagemP;
        }

    }
}
