using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEngenhariaFinanceiro
{
    public partial class BuscaFornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();
        CadastroTituloPagar cadastroTituloPagar;
        string codigo;
        string nomeForn;

        public BuscaFornecedor(CadastroTituloPagar form1)
        {
            InitializeComponent();
            cadastroTituloPagar = form1;
        }

        private void BuscaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoFinanceiroDataSet2.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.bancoFinanceiroDataSet2.Fornecedor);
           

        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            cadastroTituloPagar.tb_IdForn.Text = codigo;
            cadastroTituloPagar.tb_NomeForn.Text = nomeForn;
            cadastroTituloPagar.tb_IdForn.Refresh();
            cadastroTituloPagar.tb_NomeForn.Refresh();
            this.Close();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeForn = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            codigo = dataGridView1.Rows[e.RowIndex].Cells["IdForn"].Value.ToString();
        }

        private void tb_NomeForn_TextChanged(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = fornecedor.buscarNomeForn(tb_NomeForn.Text);
           

        }
    }
}
