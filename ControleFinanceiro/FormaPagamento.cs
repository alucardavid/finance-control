using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    class FormaPagamento
    {
        private string strConAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\" + Environment.UserName + @"\Dropbox\David\Controle Financeiro\Planejamento.accdb";

        public string formaPagamento;
        
        public FormaPagamento(string formaPagamento)
        {
            this.formaPagamento = formaPagamento;
        }

        public void AddNovaFormPagamento()
        {
            if (formaPagamento != "")
            {
                try
                {
                    OleDbConnection con = new OleDbConnection(strConAccess);
                    OleDbCommand addFormaPgmto = new OleDbCommand("INSERT INTO FormasPagamento(nome) VALUES('" + formaPagamento + "') ", con);
                    con.Open();
                    addFormaPgmto.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserir um nome para a forma de pagamento.");
            }
        }

    }
}
