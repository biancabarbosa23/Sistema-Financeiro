using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrabalhoEngenhariaFinanceiro
{
    public class Conexao
    {
        SqlConnection objcon = new SqlConnection();
        string caminho;

        public Conexao()
        {
            caminho = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                'C:\Users\Bianc\Desktop\Fatec\4° semestre\ESIII\TrabalhoEngenhariaFinanceiro\TrabalhoEngenhariaFinanceiro\BancoFinanceiro.mdf';
                Integrated Security = True; Connect Timeout = 30";

            objcon.ConnectionString = caminho;
        }

        public SqlConnection conectar()
        {
            if (objcon.State == System.Data.ConnectionState.Closed) { objcon.Open(); }
            return objcon;

        }

        public void desconectar()
        {
            if (objcon.State == System.Data.ConnectionState.Open) { objcon.Close(); }

        }

    }
}
