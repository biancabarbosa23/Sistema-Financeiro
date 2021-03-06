﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEngenhariaFinanceiro
{
    public partial class CadastroTituloPagar : Form
    {
        TituloPagar tituloPagar = new TituloPagar();
        NovoTipo novoTipo = new NovoTipo();
        DarBaixaPagar darBaixaPagar = new DarBaixaPagar();
        DataTable dt = new DataTable();

        decimal totalPago = 0;
        int localizacao, novo=0, alterar=0, baixa=0; 

        public CadastroTituloPagar()
        {
            InitializeComponent();
            localizacao = tituloPagar.consultarPagar().Rows.Count - 1;
        }

        private void limpar()
        {
            tb_IdTitulo.Clear();
            tb_IdForn.Clear();
            tb_NomeForn.Clear();
            tb_Descr.Clear();
            tb_DataEmissao.Clear();
            tb_DataVenc.Clear();
            tb_Valor.Clear();
            cb_Tipo.Text = null;
            tb_ValorPago.Clear();
            tb_DataPag.Clear();
        }

        private void ativarEnable()
        {
            tb_Descr.Enabled = true;
            tb_DataEmissao.Enabled = true;
            tb_DataVenc.Enabled = true;
            tb_Valor.Enabled = true;
            cb_Tipo.Enabled = true;
            btn_BuscarForn.Enabled = true;
        }

        private void desativarEnable()
        {
            tb_Descr.Enabled = false;
            tb_DataEmissao.Enabled = false;
            tb_DataVenc.Enabled = false;
            tb_Valor.Enabled = false;
            cb_Tipo.Enabled = false;
            btn_BuscarForn.Enabled = false;
        }

        private void desabilitarValorRestante()
        {
            lbl_ValorRestante.Visible = false;
            lbl_ValorRestanteLbl.Visible = false;
            lbl_ValorRestante.Text = null;
        }

        private void puxarDados(DataTable dt)
        {
            tb_IdTitulo.Text = dt.Rows[localizacao]["IdTitulo"].ToString();
            tb_IdForn.Text = dt.Rows[localizacao]["idForn"].ToString();
            tb_NomeForn.Text = dt.Rows[localizacao]["nome"].ToString();
            tb_Descr.Text = dt.Rows[localizacao]["descricao"].ToString();
            tb_DataEmissao.Text = dt.Rows[localizacao]["dataEmissao"].ToString();
            tb_DataVenc.Text = dt.Rows[localizacao]["dataVenc"].ToString();
            tb_Valor.Text = dt.Rows[localizacao]["valor"].ToString();
            cb_Tipo.Text = dt.Rows[localizacao]["tipo"].ToString();
            if (dt.Rows[localizacao]["situacao"].ToString() == "PAGO")
            {
                visivelBaixas();
                btn_Baixa.Enabled = false;
                tb_ValorPago.Text = dt.Rows[localizacao]["valorPago"].ToString();
                tb_DataPag.Text = dt.Rows[localizacao]["dataPagamento"].ToString();
                btn_ExcluirBaixa.Enabled = true;
                desabilitarValorRestante();

            }
            else if(dt.Rows[localizacao]["situacao"].ToString() == "EM ABERTO" && dt.Rows[localizacao]["valorPago"].ToString() != "")
            {
                visivelBaixas();
                btn_Baixa.Enabled = true;
                tb_ValorPago.Text = dt.Rows[localizacao]["valorPago"].ToString();
                tb_DataPag.Text = dt.Rows[localizacao]["dataPagamento"].ToString();
                btn_ExcluirBaixa.Enabled = true;
                lbl_ValorRestanteLbl.Visible = true;
                lbl_ValorRestante.Visible = true;
                lbl_ValorRestante.Text = (decimal.Parse(dt.Rows[localizacao]["valor"].ToString()) -
                                            decimal.Parse(dt.Rows[localizacao]["valorPago"].ToString())).ToString();

            }
            else 
            {
                invisivelBaixas();
                btn_Baixa.Enabled = true;
                btn_ExcluirBaixa.Enabled = false;
                desabilitarValorRestante();
            }
        }

        private void hablititarBaixas()
        {
            tb_DataPag.Enabled = true;
            tb_ValorPago.Enabled = true;
        }
        
        private void desabilitarBaixas()
        {
            tb_DataPag.Enabled = false;
            tb_ValorPago.Enabled = false;   
        }

        private void visivelBaixas()
        {
            lb_DataPag.Visible = true;
            lb_ValorPago.Visible = true;
            tb_ValorPago.Visible = true;
            tb_DataPag.Visible = true;
        }

        private void invisivelBaixas()
        {
            lb_DataPag.Visible = false;
            lb_ValorPago.Visible = false;
            tb_ValorPago.Visible = false;
            tb_DataPag.Visible = false;
            desabilitarValorRestante();
        }

        private void enableNavegacao()
        {
            btn_Alterar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            DateTime date1 = DateTime.ParseExact(tb_DataEmissao.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(tb_DataVenc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dataEmissao = date1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            string dataVenc = date2.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

            if (date1 < date2)
            {
                //SALVAR NOVO REGISTRO
                if (novo == 1)
                {

                    MessageBox.Show("" + tituloPagar.cadastrarPagar(tb_IdForn.Text, tb_Descr.Text,
                                                                     dataEmissao, dataVenc,
                                                                    tb_Valor.Text.Replace(',', '.'), cb_Tipo.SelectedValue.ToString()));
                    int id = tituloPagar.consultarPagar().Rows.Count - 1;
                    tb_IdTitulo.Text = tituloPagar.consultarPagar().Rows[id]["IdTitulo"].ToString();
                    novo = 0;

                }

                //ALTERAR REGISTRO
                else if (alterar == 1)
                {
                    MessageBox.Show("" + tituloPagar.alterarPagar(tb_IdTitulo.Text, tb_IdForn.Text,
                                    tb_Descr.Text, dataEmissao, dataVenc, tb_Valor.Text.Replace(',', '.'), cb_Tipo.SelectedValue.ToString()));
                    alterar = 0;

                    if (dt.Rows[localizacao]["situacao"].ToString() == "PAGO")
                    {
                        btn_ExcluirBaixa.Enabled = true;
                    }

                }


                //DAR BAIXA
                else if (baixa == 1)
                {
                    DateTime date3 = DateTime.ParseExact(tb_DataPag.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dataPag = date3.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

                     totalPago = totalPago + decimal.Parse(tb_ValorPago.Text);

                    if (totalPago < decimal.Parse(tb_Valor.Text))
                    {
                        lbl_ValorRestante.Visible = true;
                        lbl_ValorRestanteLbl.Visible = true;
                        lbl_ValorRestante.Text = (decimal.Parse(tb_Valor.Text) -  totalPago).ToString();
                        MessageBox.Show("" + darBaixaPagar.darBaixa(tb_IdTitulo.Text, dataPag, totalPago.ToString().Replace(',', '.'),"MENOR"));
                        btn_Baixa.Enabled = true;
                        
                    }
                    else if(totalPago > decimal.Parse(tb_Valor.Text))
                    {
                        if (MessageBox.Show("Tem certeza que deseja pagar um valor mais alto?", "Confirmação",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                        {
                            MessageBox.Show("" + darBaixaPagar.darBaixa(tb_IdTitulo.Text, dataPag, totalPago.ToString().Replace(',', '.'), "MAIOR"));
                            desabilitarValorRestante();
                        }
                        else
                        {
                            totalPago = totalPago - decimal.Parse(tb_ValorPago.Text);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("" + darBaixaPagar.darBaixa(tb_IdTitulo.Text, dataPag, totalPago.ToString().Replace(',', '.'), "MAIOR"));
                        desabilitarValorRestante();
                    }
                    

                    baixa = 0;
                    tb_ValorPago.Text = totalPago.ToString();
                    totalPago = 0;
                    btn_ExcluirBaixa.Enabled = true;

                }

                desativarEnable();
                desabilitarBaixas();
                btn_BuscarForn.Enabled = false;

            }
            else
            {
                MessageBox.Show("Data de Vencimento menor que Data de Emissão", "Validação",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            } 
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            novo = 1;
            alterar = 0;
            baixa = 0;
            limpar();
            invisivelBaixas();
            ativarEnable();
            desabilitarBaixas();
            btn_Baixa.Enabled = false;
            btn_ExcluirBaixa.Enabled = false;
            btn_Salvar.Enabled = true;
            btn_Excluir.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_BuscarForn.Enabled = true;
        }

        private void btn_Primeiro_Click(object sender, EventArgs e)
        {
            desativarEnable();
            desabilitarBaixas();
            enableNavegacao();

            dt = tituloPagar.consultarPagar();

            if (dt.Rows.Count > 0)
            {
                localizacao = 0;
                puxarDados(dt);
            }
        }

        private void bt_Anterior_Click(object sender, EventArgs e)
        {
            desativarEnable();
            desabilitarBaixas();
            enableNavegacao();

            dt = tituloPagar.consultarPagar();

            if (localizacao == dt.Rows.Count - 1 || localizacao != 0)
            {
                localizacao--;
                puxarDados(dt);
            }
        }

        private void bt_Proximo_Click(object sender, EventArgs e)
        {

            desativarEnable();
            desabilitarBaixas();
            enableNavegacao();

            dt = tituloPagar.consultarPagar();

            if (localizacao < dt.Rows.Count - 1)
            {
                localizacao++;
                puxarDados(dt);
            }
        }

        private void btn_Ultimo_Click(object sender, EventArgs e)
        {
            desativarEnable();
            desabilitarBaixas();
            enableNavegacao();

            dt = tituloPagar.consultarPagar();
            localizacao = dt.Rows.Count - 1;
            puxarDados(dt);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            alterar = 1;
            novo = 0;
            baixa = 0;
            ativarEnable();
            btn_Baixa.Enabled = false;
            btn_Salvar.Enabled = true;
            btn_BuscarForn.Enabled = true;
            btn_ExcluirBaixa.Enabled = false;

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            novo = 0;
            alterar = 0;
            baixa = 0;
            btn_Salvar.Enabled = false;
            desativarEnable();
            desabilitarBaixas();
            btn_BuscarForn.Enabled = false;

            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                MessageBox.Show("" + tituloPagar.excluirPagar(tb_IdTitulo.Text));
                limpar();
            }

        }


        private void btn_Sair_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void btn_NovoTipo_Click(object sender, EventArgs e)
        {
            Tipo formTipo = new Tipo();
            formTipo.Show();
        }

        private void btn_Baixa_Click(object sender, EventArgs e)
        {
            baixa = 1;
            novo = 0;
            alterar = 0;
            if (tb_ValorPago.Visible == true)
            {
                totalPago = decimal.Parse(tb_ValorPago.Text);
            }
            visivelBaixas();
            hablititarBaixas();
            tb_ValorPago.Clear();
            tb_DataPag.Text = DateTime.Now.ToShortDateString();
            btn_Baixa.Enabled = false;
            btn_Salvar.Enabled = true;
        }

        private void cb_Tipo_MouseClick(object sender, MouseEventArgs e)
        {
            cb_Tipo.DataSource = novoTipo.consultar();
            cb_Tipo.DisplayMember = "tipo";
            cb_Tipo.ValueMember = "Id";
        }

        private void btn_ExcluirBaixa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir?","Confirmação",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                darBaixaPagar.excluir(tb_IdTitulo.Text);
                tb_ValorPago.Clear();
                tb_DataPag.Clear();
                totalPago = 0;
                invisivelBaixas();
                btn_Baixa.Enabled = true;
                btn_ExcluirBaixa.Enabled = false;
            }
        }

        private void CadastroTituloPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoFinanceiroDataSet.Tipo'. Você pode movê-la ou removê-la conforme necessário.
            //this.tipoTableAdapter.Fill(this.bancoFinanceiroDataSet.Tipo);
            cb_Tipo.DataSource = novoTipo.consultar();
            cb_Tipo.DisplayMember = "tipo";
            cb_Tipo.ValueMember = "Id";

        }

        private void btn_BuscarForn_Click(object sender, EventArgs e)
        {
             BuscaFornecedor buscaFornecedor = new BuscaFornecedor(this);
             buscaFornecedor.Show();
        }

    }
}
