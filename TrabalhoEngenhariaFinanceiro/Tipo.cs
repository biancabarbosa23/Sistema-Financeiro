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
    public partial class Tipo : Form
    {

        NovoTipo tipo = new NovoTipo();
        
        string dado_Sel;
        int id;

        public Tipo()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            tipo.cadastrar(tb_Tipo.Text);
            tb_Tipo.Enabled = false;
            dataGridView1.DataSource = tipo.consultar();
            tb_Tipo.Clear();
            btn_Salvar.Enabled = false;
        }

        private void Tipo_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = tipo.consultar();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            tb_Tipo.Enabled = true;
            tb_Tipo.Clear();
            btn_Salvar.Enabled = true;
            btn_Excluir.Enabled = false;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                tipo.excluir(dado_Sel);
                dataGridView1.DataSource = tipo.consultar();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            dado_Sel = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            id = e.RowIndex;
        }
    }
}
