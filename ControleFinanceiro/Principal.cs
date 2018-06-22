using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControleFinanceiro
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();

            
        }

        private void tsm_AdicionDespesaFixa_Click(object sender, EventArgs e)
        {

            FormDespesaVariavel nDespesaFixa = new FormDespesaVariavel();
            nDespesaFixa.MdiParent = this;
            nDespesaFixa.Show();

        }

        private void tsm_AdicionDespesaVariavel_Click(object sender, EventArgs e)
        {
            FormDespesaVariavel nDespesaVariavel = new FormDespesaVariavel();
            //nDespesaVariavel.MdiParent = this;
            nDespesaVariavel.Show();
            
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
