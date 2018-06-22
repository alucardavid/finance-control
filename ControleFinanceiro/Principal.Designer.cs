namespace ControleFinanceiro
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AdicionDespesaFixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AdicionDespesaVariavel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AdicionDespesaExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            resources.ApplyResources(this.ms_Menu, "ms_Menu");
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.açõesToolStripMenuItem});
            this.ms_Menu.Name = "ms_Menu";
            // 
            // menuToolStripMenuItem
            // 
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            // 
            // açõesToolStripMenuItem
            // 
            resources.ApplyResources(this.açõesToolStripMenuItem, "açõesToolStripMenuItem");
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_AdicionDespesaFixa,
            this.tsm_AdicionDespesaVariavel,
            this.tsm_AdicionDespesaExtra});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            // 
            // tsm_AdicionDespesaFixa
            // 
            resources.ApplyResources(this.tsm_AdicionDespesaFixa, "tsm_AdicionDespesaFixa");
            this.tsm_AdicionDespesaFixa.Name = "tsm_AdicionDespesaFixa";
            this.tsm_AdicionDespesaFixa.Click += new System.EventHandler(this.tsm_AdicionDespesaFixa_Click);
            // 
            // tsm_AdicionDespesaVariavel
            // 
            resources.ApplyResources(this.tsm_AdicionDespesaVariavel, "tsm_AdicionDespesaVariavel");
            this.tsm_AdicionDespesaVariavel.Name = "tsm_AdicionDespesaVariavel";
            this.tsm_AdicionDespesaVariavel.Click += new System.EventHandler(this.tsm_AdicionDespesaVariavel_Click);
            // 
            // tsm_AdicionDespesaExtra
            // 
            resources.ApplyResources(this.tsm_AdicionDespesaExtra, "tsm_AdicionDespesaExtra");
            this.tsm_AdicionDespesaExtra.Name = "tsm_AdicionDespesaExtra";
            // 
            // Form_Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ms_Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "Form_Principal";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_AdicionDespesaFixa;
        private System.Windows.Forms.ToolStripMenuItem tsm_AdicionDespesaVariavel;
        private System.Windows.Forms.ToolStripMenuItem tsm_AdicionDespesaExtra;

    }
}

