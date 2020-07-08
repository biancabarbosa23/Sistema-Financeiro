using System;
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
    public partial class ValoresBaixa : Form
    {
        string form, id, valor;
        decimal totalPago;

        DarBaixaPagar darBaixaPagar = new DarBaixaPagar();
        DarBaixaReceber darBaixaReceber = new DarBaixaReceber();
        DarBaixa darBaixa = new DarBaixa();

        public ValoresBaixa(string form, string id, string valor, decimal totalPago, DarBaixa darBaixa)
        {
            InitializeComponent();
            this.form = form;
            this.id = id;
            this.valor = valor;
            this.darBaixa = darBaixa;
            this.totalPago = totalPago;
            
        }

        private void ValoresBaixa_Load(object sender, EventArgs e)
        {
            tb_DataPag.Text = DateTime.Now.ToShortDateString();
            tb_ValorPago.Text = (decimal.Parse(valor) - totalPago).ToString();

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DarBaixa_Click(object sender, EventArgs e)
        {
            DateTime date3 = DateTime.ParseExact(tb_DataPag.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dataPag = date3.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

            totalPago = totalPago + decimal.Parse(tb_ValorPago.Text);

            if (totalPago < decimal.Parse(valor))
            {
                if (form == "R")
                {
                    darBaixaReceber.darBaixa(id, dataPag, totalPago.ToString().Replace(',', '.'), "MENOR");
                    darBaixa.atualizarTitulo("R");
                    totalPago = 0;

                }
                else if (form == "P")
                {
                    darBaixaPagar.darBaixa(id, dataPag, totalPago.ToString().Replace(',', '.'), "MENOR");
                    darBaixa.atualizarTitulo("P");
                    totalPago = 0;

                }
            }
            else if(totalPago > decimal.Parse(valor))
            {
                if (MessageBox.Show("Tem certeza que deseja pagar um valor mais alto?", "Confirmação",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    if (form == "R")
                    {
                        darBaixaReceber.darBaixa(id, dataPag, totalPago.ToString().Replace(',', '.'), "MAIOR");
                        darBaixa.atualizarTitulo("R");
                        totalPago = 0;
                    }
                    else
                    {
                        darBaixaPagar.darBaixa(id, dataPag, totalPago.ToString().Replace(',', '.'), "MAIOR");
                        darBaixa.atualizarTitulo("P");
                        totalPago = 0;
                    }
                }
                else
                {
                    totalPago = totalPago - decimal.Parse(tb_ValorPago.Text);
                    return;
                }
            }
            else
            {
                if (form == "R")
                {
                    darBaixaReceber.darBaixa(id, dataPag, totalPago.ToString().Replace(',', '.'), "MAIOR");
                    darBaixa.atualizarTitulo("R");
                    totalPago = 0;
                }
                else
                {
                    darBaixaPagar.darBaixa(id, dataPag, totalPago.ToString().Replace(',', '.'), "MAIOR");
                    darBaixa.atualizarTitulo("P");
                    totalPago = 0;
                }

            }
            

            this.Close();
        }
    }
}
