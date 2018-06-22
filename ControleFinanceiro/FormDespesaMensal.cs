using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ControleFinanceiro
{
    public partial class Despesa_Fixa : Form
    {
        //String local, descricaoProd, formPagamento;

        string strConAccess;
       
        public Despesa_Fixa()
        {
           InitializeComponent();
           strConAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\" + Environment.UserName + @"\Dropbox\David\Controle Financeiro\Planejamento.accdb";
        }

        private void Despesa_Fixa_Load(object sender, EventArgs e)
        {
            AddFormsPagam();
            AddAutoCompleDescri();
            AddAutoCompleLocal();
        }

        public bool ValidarCampos()
        { 
            if(tbx_LocalGasto.Text == "")
            {
                MessageBox.Show("Favor preencher Local da Despesa.");
                tbx_LocalGasto.Focus();
                return  false;
            }
            else if (tbx_Descricao.Text == "")
            {
                MessageBox.Show("Favor preencher a Descrição.");
                tbx_Descricao.Focus();
                return false;
            }
            else if (tbx_VlraPagar.Text == "")
            {
                MessageBox.Show("Favor preencher o Valor Total a ser Pagar");
                tbx_VlraPagar.Focus();
                return false;
            }
            else if (nup_QtdParcelas.Value == 0)
            {
                MessageBox.Show("Numero de parcelas tem que ser maior do que 0.");
                nup_QtdParcelas.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddFormsPagam()
        {
            DataTable results = new DataTable();
            try
            {
                using (OleDbConnection con = new OleDbConnection(strConAccess))
                {
                    con.Open();
                    OleDbCommand selFormsPagam = new OleDbCommand("SELECT Nome FROM FormasPagamento;", con);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(selFormsPagam);
                    adapter.Fill(results);
                    cbxFormPag.DataSource = results;
                    cbxFormPag.ValueMember = "Nome";
                    con.Close();
                }
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAutoCompleDescri()
        {
            DataTable results = new DataTable();
            try
            {
                using (OleDbConnection con = new OleDbConnection(strConAccess))
                {
                    con.Open();
                    OleDbCommand selDescri = new OleDbCommand("SELECT DISTINCT Desc_Gast FROM Gastos_Prazo;", con);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(selDescri);
                    adapter.Fill(results);
                    foreach (DataRow nomes in results.Rows)
                    {
                        tbx_Descricao.AutoCompleteCustomSource.Add(nomes["Desc_Gast"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAutoCompleLocal()
        {
            DataTable results = new DataTable();
            try
            {
                using (OleDbConnection con = new OleDbConnection(strConAccess))
                {
                    con.Open();
                    OleDbCommand selLocal = new OleDbCommand("SELECT DISTINCT Local_Gast FROM Gastos_Prazo;", con);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(selLocal);
                    adapter.Fill(results);
                    foreach (DataRow locais in results.Rows)
                    {
                        tbx_LocalGasto.AutoCompleteCustomSource.Add(locais["Local_Gast"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Despesa_Fixa_Activated(object sender, EventArgs e)
        {
            //TODO:
        }

        private void btnAddFormaPgmto_Click(object sender, EventArgs e)
        {
            //string retorno = 
            //FormaPagamento novaFormaPagamento = new FormaPagamento();
        }
    }
        
}
