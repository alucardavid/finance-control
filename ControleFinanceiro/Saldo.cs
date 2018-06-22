using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using ControleFinanceiro.ControleFinanceiroAccessTableAdapters;
using ControleFinanceiro.LocalTableAdapters;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    class Saldo
    {

        public void atualizarSaldo(string formPgmt, decimal valor, string tipo)
        {
            DataTable dtFormasPgmt = new DataTable();
            DataTable dtSaldos = new DataTable();
            DataRow drFormaPgmt;
            DataRow drSaldo;
            string idSaldo = string.Empty;
            //decimal vlrAntigoSaldo = 0;

            taFrmsPgmt taFormasPgmt = new taFrmsPgmt();
            taSaldos taSaldos = new taSaldos();

            // Pegando saldo relacionado a forma de pagamento
            dtFormasPgmt = taFormasPgmt.GetData();
            drFormaPgmt = dtFormasPgmt.Rows.Find(formPgmt);
            idSaldo = drFormaPgmt["CdSaldo"].ToString();
            
            // pegando o valor antigo do saldo
            dtSaldos = taSaldos.GetData();
            drSaldo = dtSaldos.Rows.Find(idSaldo);
            try
            {
                if (tipo == "Despesa")
                {
                    drSaldo["Vlr"] = Decimal.Parse(drSaldo["Vlr"].ToString()) - valor;
                }
                else
                {
                    drSaldo["Vlr"] = Decimal.Parse(drSaldo["Vlr"].ToString()) + valor;
                }
                drSaldo["UpdatedAt"] = DateTime.Today;
                taSaldos.Update(drSaldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
