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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_TituloPagar_Click(object sender, EventArgs e)
        {
            CadastroTituloPagar cadastroTituloPagar = new CadastroTituloPagar();
            cadastroTituloPagar.Show();
        }

        private void btn_TituloReceber_Click(object sender, EventArgs e)
        {
            CadastroTituloReceber cadastroTituloReceber = new CadastroTituloReceber();
            cadastroTituloReceber.Show();
        }

        private void btn_ManterTipo_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.Show();
        }

        private void btn_DarBaixa_Click(object sender, EventArgs e)
        {
            DarBaixa darBaixa = new DarBaixa();
            darBaixa.Show();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            ConsultarTitulo consultarTitulo = new ConsultarTitulo();
            consultarTitulo.Show();
        }
    }
}
