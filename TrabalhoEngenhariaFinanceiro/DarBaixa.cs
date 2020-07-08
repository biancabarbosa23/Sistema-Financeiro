using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TrabalhoEngenhariaFinanceiro
{
    public partial class DarBaixa : Form
    {
        string id_R, id_P, valorR, valorP;
        int indiceR, indiceP;
        decimal totalPagoR = 0, totalPagoP = 0;

        DarBaixaPagar darBaixaPagar = new DarBaixaPagar();
        DarBaixaReceber darBaixaReceber = new DarBaixaReceber();

        public DarBaixa()
        {
            InitializeComponent();
        }

        public void atualizarTitulo(string form)
        {
            if (form == "R")
            {
                DataTable dt_R = new DataTable();
                dt_R = darBaixaReceber.consultar();
                dataGridReceber.DataSource = dt_R;
                dataGridReceber.Columns["IdTitulo"].Visible = false;
                dataGridReceber.Columns["dataPagamento"].Visible = false;
            }
            else
            {

                DataTable dt_P = new DataTable();
                dt_P = darBaixaPagar.consultar();
                dataGridPagar.DataSource = dt_P;
                dataGridPagar.Columns["IdTitulo"].Visible = false;
                dataGridPagar.Columns["dataPagamento"].Visible = false;
            }

        }

        private void btn_SairR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SairP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DarBaixa_Load(object sender, EventArgs e)
        {
            DataTable dt_R = new DataTable();
            dt_R = darBaixaReceber.consultar();
            dataGridReceber.DataSource = dt_R;
            dataGridReceber.Columns["IdTitulo"].Visible = false;
            dataGridReceber.Columns["dataPagamento"].Visible = false;

            DataTable dt_P = new DataTable();
            dt_P = darBaixaPagar.consultar();
            dataGridPagar.DataSource = dt_P;
            dataGridPagar.Columns["IdTitulo"].Visible = false;
            dataGridPagar.Columns["dataPagamento"].Visible = false;
        }

        private void btn_DarBaixaR_Click(object sender, EventArgs e)
        {
            if (dataGridReceber.Rows[indiceR].Cells["valorPago"].Value.ToString() != "")
            {
                totalPagoR = decimal.Parse(dataGridReceber.Rows[indiceR].Cells["valorPago"].Value.ToString());
            }
            else
            {
                totalPagoR = 0;
            }

            ValoresBaixa valoresBaixa = new ValoresBaixa("R", id_R, valorR,totalPagoR, this);
            valoresBaixa.Show();

        }

        private void btn_DarBaixaP_Click(object sender, EventArgs e)
        {
            if (dataGridPagar.Rows[indiceP].Cells["valorPago"].Value.ToString() != "")
            {
                totalPagoP = decimal.Parse(dataGridPagar.Rows[indiceP].Cells["valorPago"].Value.ToString());
            }
            else
            {
                totalPagoP = 0;
            }

            ValoresBaixa valoresBaixaP = new ValoresBaixa("P",id_P,valorP,totalPagoP,this);
            valoresBaixaP.Show();
        }

        private void dataGridReceber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_R = dataGridReceber.Rows[e.RowIndex].Cells["IdTitulo"].Value.ToString();
            indiceR = e.RowIndex;
            valorR = dataGridReceber.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            btn_DarBaixaR.Enabled = true;

        }

        private void dataGridPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_P = dataGridPagar.Rows[e.RowIndex].Cells["IdTitulo"].Value.ToString();
            indiceP = e.RowIndex;
            valorP = dataGridPagar.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            btn_DarBaixaP.Enabled = true;

        }

    }
}
