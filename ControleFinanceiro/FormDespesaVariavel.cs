using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ControleFinanceiro.ControleFinanceiroAccessTableAdapters;
using ControleFinanceiro.LocalTableAdapters;
using System.Globalization;
using ControleFinanceiro.Model;

namespace ControleFinanceiro
{
    public partial class FormDespesaVariavel: Form
    {
        public FormDespesaVariavel()
        {
            InitializeComponent();
            //LoadAutoCompleteDescricao();
            //LoadAutoCompleteLocais();
            //LoadFormasPagamento();
        }

        private async void DespesaVariavel_Load(object sender, EventArgs e)
        {
            
            var resultado = await TesteAsync();

            tbxDescricao.AutoCompleteCustomSource.Clear();
            tbxDescricao.AutoCompleteCustomSource.AddRange(resultado);
        }

        private async Task<string[]> GetDescriptions()
        {
            var task = Task.Factory.StartNew(() =>
            {
                using (var context = new FinanceModel())
                {
                    return context.VariableExpenses.ToList().Select(v => v.Description).Distinct().ToArray();

                    //tbxDescricao.AutoCompleteCustomSource.Clear();
                    //tbxDescricao.AutoCompleteCustomSource.AddRange(descriptions);
                }
            });

            return await task;
        }

        private void LoadAutoCompleteDescricao(string[] descriptions)
        {



            //using (var context = new FinanceModel())
            //{
            //    string[] descriptions = context.VariableExpenses.ToList().Select(v => v.Description).Distinct().ToArray();

            //    tbxDescricao.AutoCompleteCustomSource.Clear();
            //    tbxDescricao.AutoCompleteCustomSource.AddRange(descriptions);
            //}

            //using (var context = new ControleFinanceiroContext())
            //{
            //    string[] descricoes = context.DespesaVariavel.ToList().Select(x => x.Descr).Distinct().ToArray();

            //    tbxDescricao.AutoCompleteCustomSource.Clear();
            //    tbxDescricao.AutoCompleteCustomSource.AddRange(descricoes);

            //}
        
        }

        public void LoadAutoCompleteLocais()
        {
            using (var context = new FinanceModel())
            {
                string[] places = context.VariableExpenses.ToList().Select(v => v.Place).Distinct().ToArray();

                tbxLocal.AutoCompleteCustomSource.Clear();
                tbxLocal.AutoCompleteCustomSource.AddRange(places);

            }

            //using (var context = new ControleFinanceiroContext())
            //{
            //    string[] locais = context.DespesaVariavel.ToList().Select(x => x.Local).Distinct().ToArray();

            //    tbxLocal.AutoCompleteCustomSource.Clear();
            //    tbxLocal.AutoCompleteCustomSource.AddRange(locais);
                
            //}
        }

        public void LoadFormasPagamento()
        {

            using (var context = new FinanceModel())
            {
                IList<FormOfPayment> formOfPayment = context.FormOfPayments.ToList().OrderBy(f => f.Description).ToArray();

                cbFormaPgmt.Items.Clear();
                cbFormaPgmt.DisplayMember = "Description";
                cbFormaPgmt.ValueMember = "Id";
                cbFormaPgmt.DataSource = formOfPayment;
            }

            //using (var context = new ControleFinanceiroContext())
            //{
            //    IList<FrmsPgmt> formasPgmt = context.FrmsPgmt.ToList().OrderBy(x=> x.Descr).ToArray(); ;
            //    cbFormaPgmt.Items.Clear();
            //    cbFormaPgmt.DisplayMember = "Descr";
            //    cbFormaPgmt.ValueMember = "CdFrmPgmt";
            //    cbFormaPgmt.DataSource = formasPgmt;
                
            //}
        }

        private bool validarCampos()
        {
            bool validate = true;
            if (tbxLocal.Text == "")
            {
                tbxLocal.Focus();
                validate = false;
            }

            if (tbxDescricao.Text == "")
            {
                tbxDescricao.Focus();
                validate = false;
            }

            if (tbxValor.Text == "")
            {
                tbxValor.Focus();
                validate = false;
            }

            if (cbTipo.SelectedItem.ToString() == "")
            {
                cbTipo.Focus();
                validate = false;
            }

            if (validate)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                using (var context = new FinanceModel())
                {
                    var formOfPayment = context.FormOfPayments.First(f => f.Id == ((FormOfPayment)cbFormaPgmt.SelectedItem).Id);
                    var balance = context.Balances.First(b => b.Id == formOfPayment.Balance_Id);
                    var user = context.Users.First(u => u.CPF == "39174716808");

                    var expense = new VariableExpense()
                    {
                        Place = tbxLocal.Text,
                        Description = tbxDescricao.Text,
                        FormOfPayment = formOfPayment,
                        Value = decimal.Parse(tbxValor.Text),
                        Date = DateTime.Parse(mcData.SelectionRange.Start.ToShortDateString()),
                        Type = cbTipo.SelectedItem.ToString(),
                        CreatedAt = DateTime.Now,
                        User = user
                    };

                    if (cbTipo.SelectedItem.ToString().Contains("Despesa"))
                    {
                        balance.Value -= (double)expense.Value;
                    }
                    else
                    {
                        balance.Value += (double)expense.Value;
                    }

                    try
                    {
                        context.VariableExpenses.Add(expense);

                        //var entries = context.ChangeTracker.Entries();
                        //var texto = new StringBuilder();

                        //foreach (var item in entries)
                        //{
                        //    texto.AppendLine($"Entity Name: {item.Entity.GetType().Name}");
                        //    texto.AppendLine($"Status: {item.State}");
                        //}

                        //MessageBox.Show(texto.ToString());

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    

                    LoadAutoCompleteDescricao();
                    LoadAutoCompleteLocais();

                    MessageBox.Show("Despesa inserida com sucesso!");
                }


                //using (var context = new ControleFinanceiroContext())
                //{
                //    FrmsPgmt formaPagamento = (FrmsPgmt)cbFormaPgmt.SelectedItem;
                //    var saldo = context.Saldos.ToList().Where(x => x.CdSaldo == formaPagamento.CdSaldo).Single();

                //    var despesa = new DespesaVariavel()
                //    {
                //        Local = tbxLocal.Text,
                //        Descr = tbxDescricao.Text,
                //        CdFrmPgmt = (int)cbFormaPgmt.SelectedValue,
                //        Vlr = decimal.Parse(tbxValor.Text),
                //        Data = DateTime.Parse(mcData.SelectionRange.Start.ToShortDateString()),
                //        TipGasto = cbTipo.SelectedItem.ToString(),
                //        CreatedAt = DateTime.Now,
                //        UpdatedAt = DateTime.Now
                //    };

                //    if (cbTipo.SelectedItem.ToString().Contains("Despesa"))
                //    {
                //        saldo.Vlr -= despesa.Vlr;
                //    }
                //    else
                //    {
                //        saldo.Vlr += despesa.Vlr;
                //    }

                //    context.DespesaVariavel.Add(despesa);
                //    context.SaveChanges();

                //    MessageBox.Show("Despesa inserida com sucesso!");
                    

                //}
            }

            //if (validarCampos())
            //{
            //    //DespesaVariavel nDespesaVariavel = new DespesaVariavel(tbxLocal.Text, 
            //    //                                                        tbxDescricao.Text, 
            //    //                                                        cbFormaPgmt.SelectedValue.ToString(), 
            //    //                                                        cbTipo.SelectedItem.ToString(), 
            //    //                                                        Decimal.Parse(tbxValor.Text), 
            //    //                                                        mcData.SelectionRange.Start.ToShortDateString());
            //    //nDespesaVariavel.adicionarNovaDespesa();
            //}
        }

        private void formatValor()
        {
            string tmpValor = tbxValor.Text.Replace(".","").Replace(",","");
            string vlrFinal = string.Empty;
            try
            {
                switch (tmpValor.Length)
                {
                    case 1:
                    case 2:
                        vlrFinal = tmpValor.Replace(",", "");
                        break;
                    case 3:
                        vlrFinal = tmpValor.Substring(0, 1) + "," + tmpValor.Substring(1, 2);
                        break;
                    case 4:
                        vlrFinal = tmpValor.Substring(0, 2) + "," + tmpValor.Substring(2, 2);
                        break;
                    case 5:
                        vlrFinal = tmpValor.Substring(0, 3) + "," + tmpValor.Substring(3, 2);
                        break;
                    case 6:
                        vlrFinal = tmpValor.Substring(0, 1) + "." + tmpValor.Substring(1, 3) + "," + tmpValor.Substring(4, 2);
                        break;
                    case 7:
                        vlrFinal = tmpValor.Substring(0, 2) + "." + tmpValor.Substring(2, 3) + "," + tmpValor.Substring(5, 2);
                        break;
                    case 8:
                        vlrFinal = tmpValor.Substring(0, 3) + "." + tmpValor.Substring(3, 3) + "," + tmpValor.Substring(6, 2);
                        break;
                    case 9:
                        vlrFinal = tmpValor.Substring(0, 1) + "." + tmpValor.Substring(1, 3) + "." + tmpValor.Substring(3, 3) + "," + tmpValor.Substring(7, 2);
                        break;
                    case 10:
                        vlrFinal = tmpValor.Substring(0, 2) + "." + tmpValor.Substring(2, 3) + "." + tmpValor.Substring(4, 3) + "," + tmpValor.Substring(8, 2);
                        break;
                    case 11:
                        vlrFinal = tmpValor.Substring(0, 3) + "." + tmpValor.Substring(3, 3) + "." + tmpValor.Substring(6, 3) + "," + tmpValor.Substring(9, 2);
                        break;
                    case 12:
                        vlrFinal = tmpValor.Substring(0, 1) + "." + tmpValor.Substring(1, 3) + "." + tmpValor.Substring(3, 3) + "." + tmpValor.Substring(6, 3) + "," + tmpValor.Substring(10, 2);
                        break;
                    default:
                        vlrFinal = tbxValor.Text;
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbxValor.Text = vlrFinal;
            tbxValor.SelectionStart = tbxValor.Text.Length;

        }

        private void tbxValor_KeyUp(object sender, KeyEventArgs e)
        {
            formatValor();
        }

    }
}
