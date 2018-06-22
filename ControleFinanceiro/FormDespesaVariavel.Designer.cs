namespace ControleFinanceiro
{
    partial class FormDespesaVariavel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDespesaVariavel));
            this.lblLocal = new System.Windows.Forms.Label();
            this.tbxLocal = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.lblFormaPgmt = new System.Windows.Forms.Label();
            this.cbFormaPgmt = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.mcData = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            resources.ApplyResources(this.lblLocal, "lblLocal");
            this.lblLocal.Name = "lblLocal";
            // 
            // tbxLocal
            // 
            resources.ApplyResources(this.tbxLocal, "tbxLocal");
            this.tbxLocal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxLocal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxLocal.Name = "tbxLocal";
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.Name = "lblDescricao";
            // 
            // tbxDescricao
            // 
            resources.ApplyResources(this.tbxDescricao, "tbxDescricao");
            this.tbxDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxDescricao.Name = "tbxDescricao";
            // 
            // lblFormaPgmt
            // 
            resources.ApplyResources(this.lblFormaPgmt, "lblFormaPgmt");
            this.lblFormaPgmt.Name = "lblFormaPgmt";
            // 
            // cbFormaPgmt
            // 
            resources.ApplyResources(this.cbFormaPgmt, "cbFormaPgmt");
            this.cbFormaPgmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaPgmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPgmt.DisplayMember = "Descr";
            this.cbFormaPgmt.FormattingEnabled = true;
            this.cbFormaPgmt.Name = "cbFormaPgmt";
            this.cbFormaPgmt.ValueMember = "CdFrmPgmt";
            
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTipo
            // 
            resources.ApplyResources(this.lblTipo, "lblTipo");
            this.lblTipo.Name = "lblTipo";
            // 
            // cbTipo
            // 
            resources.ApplyResources(this.cbTipo, "cbTipo");
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            resources.GetString("cbTipo.Items"),
            resources.GetString("cbTipo.Items1")});
            this.cbTipo.Name = "cbTipo";
            // 
            // lblValor
            // 
            resources.ApplyResources(this.lblValor, "lblValor");
            this.lblValor.Name = "lblValor";
            // 
            // tbxValor
            // 
            resources.ApplyResources(this.tbxValor, "tbxValor");
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxValor_KeyUp);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.Name = "lblData";
            // 
            // mcData
            // 
            resources.ApplyResources(this.mcData, "mcData");
            this.mcData.Name = "mcData";
            
            // 
            // FormDespesaVariavel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mcData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbFormaPgmt);
            this.Controls.Add(this.lblFormaPgmt);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tbxLocal);
            this.Controls.Add(this.lblLocal);
            this.Name = "FormDespesaVariavel";
            this.Load += new System.EventHandler(this.DespesaVariavel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox tbxLocal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label lblFormaPgmt;
        private System.Windows.Forms.ComboBox cbFormaPgmt;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MonthCalendar mcData;
    }
}