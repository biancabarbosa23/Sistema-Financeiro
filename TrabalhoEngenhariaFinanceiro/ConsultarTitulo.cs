using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEngenhariaFinanceiro
{
    public partial class ConsultarTitulo : Form
    {
        ConsultaComplexa consultaComplexa = new ConsultaComplexa();

        string forn = null, pago = null, parcial = null, aberto = null, dataInicio = null , dataFinal = null ;
        string cliente = null, pagoR = null, parcialR = null, abertoR = null, dataInicioR = null, dataFinalR = null;

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage2)
            {
                dataGridReceber.DataSource = consultaComplexa.ConsultarReceber(cliente, dataInicioR, dataFinalR, pagoR, parcialR, abertoR);
                lbl_TotalTitulosR.Text = dataGridReceber.Rows.Count.ToString();

                decimal somaR = 0;

                for (int i = 0; i < dataGridReceber.Rows.Count; i++)
                {
                    somaR = somaR + decimal.Parse(dataGridReceber.Rows[i].Cells[6].Value.ToString());

                }
                lbl_TotalReceber.Text = somaR.ToString("c");
            }
        }

        private void ConsultarTitulo_Load(object sender, EventArgs e)
        {
            dataGridPagar.DataSource = consultaComplexa.ConsultarPagar(forn, dataInicio, dataFinal, pago,parcial,aberto);
            lb_TotalTitulos.Text = dataGridPagar.Rows.Count.ToString();

            decimal soma = 0;

            for (int i = 0; i < dataGridPagar.Rows.Count; i++)
            {
                soma = soma + decimal.Parse(dataGridPagar.Rows[i].Cells[6].Value.ToString());

            }
            lb_TotalPagar.Text = soma.ToString("c");
        }

        private void btn_SairR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GerarRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + consultaComplexa.relatorioPagar());
        }

        private void btn_GerarRelatorioR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+ consultaComplexa.relatorioReceber());
        }

        private void btn_ConsultarR_Click(object sender, EventArgs e)
        {
            if (tb_NomeCliente.Visible == true && tb_NomeCliente.Text != "")
            {
                cliente = tb_NomeCliente.Text;
            }
            if (tb_DataInicioR.Visible == true && tb_DataInicioR.Text != "  /  /" && tb_DataFinalR.Text == "  /  /")
            {
                DateTime date4 = DateTime.ParseExact(tb_DataInicioR.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dataIniR = date4.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

                dataInicioR = dataIniR;

            }
            else if (tb_DataInicioR.Visible == true && tb_DataInicioR.Text != "  /  /" && tb_DataFinalR.Text != "  /  /")
            {
                if (DateTime.Parse(tb_DataInicioR.Text) < DateTime.Parse(tb_DataFinalR.Text))
                {
                    DateTime date4 = DateTime.ParseExact(tb_DataInicioR.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dataIniR = date4.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    DateTime date5 = DateTime.ParseExact(tb_DataFinalR.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dataFimR = date5.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

                    dataInicioR = dataIniR;
                    dataFinalR = dataFimR;
                }
                else
                {
                    MessageBox.Show("Data Inicial é menor que a Data Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (radio_PagarR.Checked == true)
            {
                pagoR = "a";
            }
            if (radio_ParcialR.Checked == true)
            {
                parcialR = "a";
            }
            if (radio_NaoPagasR.Checked == true)
            {
                abertoR = "a";
            }

            dataGridReceber.DataSource = consultaComplexa.ConsultarReceber(cliente, dataInicioR, dataFinalR, pagoR, parcialR, abertoR);

            lbl_TotalTitulosR.Text = dataGridReceber.Rows.Count.ToString();

            decimal somaR = 0;

            for (int i = 0; i < dataGridReceber.Rows.Count; i++)
            {
                somaR = somaR + decimal.Parse(dataGridReceber.Rows[i].Cells[6].Value.ToString());

            }

            lbl_TotalReceber.Text = somaR.ToString("C", CultureInfo.CurrentCulture);

            dataFinalR = null;
            dataInicioR = null;
            cliente = null;
            parcialR = null;
            pagoR = null;
            abertoR = null;
        }

        private void cb_PesquisarPorR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PesquisarPorR.SelectedItem == "Fornecedor")
            {
                tb_NomeCliente.Visible = true;
                lbl_NomeCliente.Visible = true;
                tb_DataFinalR.Visible = false;
                lbl_DataR.Visible = false;
                tb_DataInicioR.Visible = false;

            }
            else if (cb_PesquisarPorR.SelectedItem == "Data Vencimento")
            {
                tb_NomeCliente.Visible = false;
                lbl_NomeCliente.Visible = false;
                tb_DataFinalR.Visible = true;
                lbl_DataR.Visible = true;
                tb_DataInicioR.Visible = true;

            }
            else
            {
                tb_NomeCliente.Visible = true;
                lbl_NomeCliente.Visible = true;
                tb_DataFinalR.Visible = true;
                lbl_DataR.Visible = true;
                tb_DataInicioR.Visible = true;
            }
        }

        public ConsultarTitulo()
        {
            InitializeComponent();
        }

        private void cb_PesquisarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_PesquisarPor.SelectedItem == "Fornecedor")
            {
                tb_Nome.Visible = true;
                lb_Nome.Visible = true;
                tb_DataFinal.Visible = false;
                lb_Data.Visible = false;
                tb_DataInicio.Visible = false;

            }else if(cb_PesquisarPor.SelectedItem == "Data Vencimento")
            {
                tb_Nome.Visible = false;
                lb_Nome.Visible = false;
                tb_DataFinal.Visible = true;
                lb_Data.Visible = true;
                tb_DataInicio.Visible = true;

            }
            else
            {
                tb_Nome.Visible = true;
                lb_Nome.Visible = true;
                tb_DataFinal.Visible = true;
                lb_Data.Visible = true;
                tb_DataInicio.Visible = true;
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if(tb_Nome.Visible == true && tb_Nome.Text != "")
            {
                forn = tb_Nome.Text;
            }
            if(tb_DataInicio.Visible == true && tb_DataInicio.Text != "  /  /" && tb_DataFinal.Text == "  /  /")
            {
                DateTime date1 = DateTime.ParseExact(tb_DataInicio.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dataIni = date1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

                dataInicio = dataIni;
                
            }else if(tb_DataInicio.Visible == true && tb_DataInicio.Text != "  /  /" && tb_DataFinal.Text != "  /  /")
            {
                if (DateTime.Parse(tb_DataInicio.Text) < DateTime.Parse( tb_DataFinal.Text))
                {
                    DateTime date1 = DateTime.ParseExact(tb_DataInicio.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dataIni = date1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    DateTime date2 = DateTime.ParseExact(tb_DataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dataFim = date2.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

                    dataInicio = dataIni;
                    dataFinal = dataFim;
                }
                else
                {
                    MessageBox.Show("Data Inicial é menor que a Data Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if(radio_Paga.Checked == true)
            {
                pago = "a";
            }
            if(radio_Parcial.Checked == true)
            {
                parcial = "a";
            }
            if (radio_NaoPaga.Checked == true)
            {
                aberto = "a";
            }

            dataGridPagar.DataSource = consultaComplexa.ConsultarPagar(forn, dataInicio, dataFinal, pago, parcial, aberto);

            lb_TotalTitulos.Text = dataGridPagar.Rows.Count.ToString();

            decimal soma = 0;

            for(int i = 0; i< dataGridPagar.Rows.Count; i++)
            {
                soma = soma + decimal.Parse(dataGridPagar.Rows[i].Cells[6].Value.ToString());
                
            }

            lb_TotalPagar.Text = soma.ToString("C", CultureInfo.CurrentCulture);

            dataFinal = null;
            dataInicio = null;
            forn = null;
            parcial = null;
            pago = null;
            aberto = null;
        }
    }
}
