namespace ControleFinanceiro
{
    partial class Despesa_Fixa
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
            this.Bt_Cadas = new System.Windows.Forms.Button();
            this.lbl_DtVencimento = new System.Windows.Forms.Label();
            this.mc_DtVencimento = new System.Windows.Forms.MonthCalendar();
            this.nup_QtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.lbl_QtdParcelas = new System.Windows.Forms.Label();
            this.tbx_VlraPagar = new System.Windows.Forms.TextBox();
            this.lbl_VlrGasto = new System.Windows.Forms.Label();
            this.lbl_TipGasto = new System.Windows.Forms.Label();
            this.tbx_Descricao = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.tbx_LocalGasto = new System.Windows.Forms.TextBox();
            this.lbl_LocalGasto = new System.Windows.Forms.Label();
            this.cbxFormPag = new System.Windows.Forms.ComboBox();
            this.btnAddFormaPgmto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_QtdParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Cadas
            // 
            this.Bt_Cadas.Location = new System.Drawing.Point(26, 314);
            this.Bt_Cadas.Name = "Bt_Cadas";
            this.Bt_Cadas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bt_Cadas.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cadas.TabIndex = 7;
            this.Bt_Cadas.Text = "Cadastrar";
            this.Bt_Cadas.UseVisualStyleBackColor = true;
            // 
            // lbl_DtVencimento
            // 
            this.lbl_DtVencimento.AutoSize = true;
            this.lbl_DtVencimento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DtVencimento.Location = new System.Drawing.Point(373, 21);
            this.lbl_DtVencimento.Name = "lbl_DtVencimento";
            this.lbl_DtVencimento.Size = new System.Drawing.Size(250, 14);
            this.lbl_DtVencimento.TabIndex = 38;
            this.lbl_DtVencimento.Text = "Data de Vencimento da Primeira Parcela";
            // 
            // mc_DtVencimento
            // 
            this.mc_DtVencimento.Location = new System.Drawing.Point(394, 43);
            this.mc_DtVencimento.Name = "mc_DtVencimento";
            this.mc_DtVencimento.TabIndex = 6;
            // 
            // nup_QtdParcelas
            // 
            this.nup_QtdParcelas.Location = new System.Drawing.Point(26, 265);
            this.nup_QtdParcelas.Name = "nup_QtdParcelas";
            this.nup_QtdParcelas.Size = new System.Drawing.Size(148, 20);
            this.nup_QtdParcelas.TabIndex = 5;
            // 
            // lbl_QtdParcelas
            // 
            this.lbl_QtdParcelas.AutoSize = true;
            this.lbl_QtdParcelas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtdParcelas.Location = new System.Drawing.Point(12, 241);
            this.lbl_QtdParcelas.Name = "lbl_QtdParcelas";
            this.lbl_QtdParcelas.Size = new System.Drawing.Size(150, 14);
            this.lbl_QtdParcelas.TabIndex = 35;
            this.lbl_QtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // tbx_VlraPagar
            // 
            this.tbx_VlraPagar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbx_VlraPagar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbx_VlraPagar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_VlraPagar.Location = new System.Drawing.Point(26, 210);
            this.tbx_VlraPagar.Name = "tbx_VlraPagar";
            this.tbx_VlraPagar.Size = new System.Drawing.Size(150, 21);
            this.tbx_VlraPagar.TabIndex = 4;
            this.tbx_VlraPagar.Text = "0,00 R$";
            // 
            // lbl_VlrGasto
            // 
            this.lbl_VlrGasto.AutoSize = true;
            this.lbl_VlrGasto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VlrGasto.Location = new System.Drawing.Point(12, 186);
            this.lbl_VlrGasto.Name = "lbl_VlrGasto";
            this.lbl_VlrGasto.Size = new System.Drawing.Size(143, 14);
            this.lbl_VlrGasto.TabIndex = 33;
            this.lbl_VlrGasto.Text = "Valor Total a Ser Pago";
            // 
            // lbl_TipGasto
            // 
            this.lbl_TipGasto.AutoSize = true;
            this.lbl_TipGasto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipGasto.Location = new System.Drawing.Point(12, 131);
            this.lbl_TipGasto.Name = "lbl_TipGasto";
            this.lbl_TipGasto.Size = new System.Drawing.Size(137, 14);
            this.lbl_TipGasto.TabIndex = 31;
            this.lbl_TipGasto.Text = "Forma de Pagamento";
            // 
            // tbx_Descricao
            // 
            this.tbx_Descricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbx_Descricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbx_Descricao.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Descricao.Location = new System.Drawing.Point(26, 100);
            this.tbx_Descricao.Name = "tbx_Descricao";
            this.tbx_Descricao.Size = new System.Drawing.Size(280, 21);
            this.tbx_Descricao.TabIndex = 2;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.Location = new System.Drawing.Point(12, 76);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(64, 14);
            this.lbl_Descricao.TabIndex = 29;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // tbx_LocalGasto
            // 
            this.tbx_LocalGasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbx_LocalGasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbx_LocalGasto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_LocalGasto.Location = new System.Drawing.Point(26, 45);
            this.tbx_LocalGasto.Name = "tbx_LocalGasto";
            this.tbx_LocalGasto.Size = new System.Drawing.Size(280, 21);
            this.tbx_LocalGasto.TabIndex = 1;
            // 
            // lbl_LocalGasto
            // 
            this.lbl_LocalGasto.AutoSize = true;
            this.lbl_LocalGasto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LocalGasto.Location = new System.Drawing.Point(12, 21);
            this.lbl_LocalGasto.Name = "lbl_LocalGasto";
            this.lbl_LocalGasto.Size = new System.Drawing.Size(111, 14);
            this.lbl_LocalGasto.TabIndex = 27;
            this.lbl_LocalGasto.Text = "Local da Despesa";
            // 
            // cbxFormPag
            // 
            this.cbxFormPag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFormPag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFormPag.FormattingEnabled = true;
            this.cbxFormPag.Location = new System.Drawing.Point(26, 155);
            this.cbxFormPag.MaxDropDownItems = 10;
            this.cbxFormPag.Name = "cbxFormPag";
            this.cbxFormPag.Size = new System.Drawing.Size(280, 21);
            this.cbxFormPag.TabIndex = 3;
            // 
            // btnAddFormaPgmto
            // 
            this.btnAddFormaPgmto.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFormaPgmto.BackgroundImage = global::ControleFinanceiro.Properties.Resources.tab_new_r;
            this.btnAddFormaPgmto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddFormaPgmto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFormaPgmto.FlatAppearance.BorderSize = 0;
            this.btnAddFormaPgmto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFormaPgmto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFormaPgmto.Location = new System.Drawing.Point(310, 153);
            this.btnAddFormaPgmto.Name = "btnAddFormaPgmto";
            this.btnAddFormaPgmto.Size = new System.Drawing.Size(24, 26);
            this.btnAddFormaPgmto.TabIndex = 39;
            this.btnAddFormaPgmto.UseVisualStyleBackColor = false;
            this.btnAddFormaPgmto.Click += new System.EventHandler(this.btnAddFormaPgmto_Click);
            // 
            // Despesa_Fixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 374);
            this.Controls.Add(this.btnAddFormaPgmto);
            this.Controls.Add(this.cbxFormPag);
            this.Controls.Add(this.Bt_Cadas);
            this.Controls.Add(this.lbl_DtVencimento);
            this.Controls.Add(this.mc_DtVencimento);
            this.Controls.Add(this.nup_QtdParcelas);
            this.Controls.Add(this.lbl_QtdParcelas);
            this.Controls.Add(this.tbx_VlraPagar);
            this.Controls.Add(this.lbl_VlrGasto);
            this.Controls.Add(this.lbl_TipGasto);
            this.Controls.Add(this.tbx_Descricao);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.tbx_LocalGasto);
            this.Controls.Add(this.lbl_LocalGasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Despesa_Fixa";
            this.Text = "Adicionar Despesa Fixa";
            this.Activated += new System.EventHandler(this.Despesa_Fixa_Activated);
            this.Load += new System.EventHandler(this.Despesa_Fixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_QtdParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Bt_Cadas;
        internal System.Windows.Forms.Label lbl_DtVencimento;
        internal System.Windows.Forms.MonthCalendar mc_DtVencimento;
        internal System.Windows.Forms.NumericUpDown nup_QtdParcelas;
        internal System.Windows.Forms.Label lbl_QtdParcelas;
        internal System.Windows.Forms.TextBox tbx_VlraPagar;
        internal System.Windows.Forms.Label lbl_VlrGasto;
        internal System.Windows.Forms.Label lbl_TipGasto;
        internal System.Windows.Forms.TextBox tbx_Descricao;
        internal System.Windows.Forms.Label lbl_Descricao;
        internal System.Windows.Forms.TextBox tbx_LocalGasto;
        internal System.Windows.Forms.Label lbl_LocalGasto;
        private System.Windows.Forms.ComboBox cbxFormPag;
        private System.Windows.Forms.Button btnAddFormaPgmto;
    }
}