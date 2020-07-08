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
    public partial class BuscaCliente : Form
    {
        CadastroTituloReceber cadastroTituloReceber;
        Cliente cliente = new Cliente();
        string nomeCliente, codigo;

        public BuscaCliente(CadastroTituloReceber form1)
        {
            InitializeComponent();
            cadastroTituloReceber = form1;
        }

        private void BuscaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoFinanceiroDataSet5.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bancoFinanceiroDataSet5.Cliente);

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            cadastroTituloReceber.tb_IdCliente.Text = codigo;
            cadastroTituloReceber.tb_NomeCliente.Text = nomeCliente;
            cadastroTituloReceber.tb_IdCliente.Refresh();
            cadastroTituloReceber.tb_NomeCliente.Refresh();
            this.Close();
        }

        private void tb_NomeCliente_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cliente.buscarNomeCli(tb_NomeCliente.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeCliente = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            codigo = dataGridView1.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();
        }


    }
}
