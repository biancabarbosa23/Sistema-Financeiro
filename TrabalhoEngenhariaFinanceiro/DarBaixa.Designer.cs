namespace TrabalhoEngenhariaFinanceiro
{
    partial class DarBaixa
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
            this.components = new System.ComponentModel.Container();
            this.bancoFinanceiroDataSet7 = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet7();
            this.bancoFinanceiroDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloReceberTableAdapter = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet7TableAdapters.TituloReceberTableAdapter();
            this.tituloReceberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tituloReceberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Receber = new System.Windows.Forms.TabPage();
            this.dataGridReceber = new System.Windows.Forms.DataGridView();
            this.btn_SairR = new System.Windows.Forms.Button();
            this.btn_DarBaixaR = new System.Windows.Forms.Button();
            this.tp_Pagar = new System.Windows.Forms.TabPage();
            this.dataGridPagar = new System.Windows.Forms.DataGridView();
            this.btn_SairP = new System.Windows.Forms.Button();
            this.btn_DarBaixaP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloReceberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloReceberBindingSource2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_Receber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceber)).BeginInit();
            this.tp_Pagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoFinanceiroDataSet7
            // 
            this.bancoFinanceiroDataSet7.DataSetName = "BancoFinanceiroDataSet7";
            this.bancoFinanceiroDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoFinanceiroDataSet7BindingSource
            // 
            this.bancoFinanceiroDataSet7BindingSource.DataSource = this.bancoFinanceiroDataSet7;
            this.bancoFinanceiroDataSet7BindingSource.Position = 0;
            // 
            // tituloReceberBindingSource
            // 
            this.tituloReceberBindingSource.DataMember = "TituloReceber";
            this.tituloReceberBindingSource.DataSource = this.bancoFinanceiroDataSet7BindingSource;
            // 
            // tituloReceberTableAdapter
            // 
            this.tituloReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tituloReceberBindingSource1
            // 
            this.tituloReceberBindingSource1.DataMember = "TituloReceber";
            this.tituloReceberBindingSource1.DataSource = this.bancoFinanceiroDataSet7BindingSource;
            // 
            // tituloReceberBindingSource2
            // 
            this.tituloReceberBindingSource2.DataMember = "TituloReceber";
            this.tituloReceberBindingSource2.DataSource = this.bancoFinanceiroDataSet7BindingSource;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Receber);
            this.tabControl1.Controls.Add(this.tp_Pagar);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Receber
            // 
            this.tp_Receber.Controls.Add(this.dataGridReceber);
            this.tp_Receber.Controls.Add(this.btn_SairR);
            this.tp_Receber.Controls.Add(this.btn_DarBaixaR);
            this.tp_Receber.Location = new System.Drawing.Point(4, 22);
            this.tp_Receber.Name = "tp_Receber";
            this.tp_Receber.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Receber.Size = new System.Drawing.Size(818, 333);
            this.tp_Receber.TabIndex = 0;
            this.tp_Receber.Text = "Título a Receber";
            this.tp_Receber.UseVisualStyleBackColor = true;
            // 
            // dataGridReceber
            // 
            this.dataGridReceber.AllowUserToAddRows = false;
            this.dataGridReceber.AllowUserToDeleteRows = false;
            this.dataGridReceber.AllowUserToOrderColumns = true;
            this.dataGridReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceber.Location = new System.Drawing.Point(0, 6);
            this.dataGridReceber.MultiSelect = false;
            this.dataGridReceber.Name = "dataGridReceber";
            this.dataGridReceber.ReadOnly = true;
            this.dataGridReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReceber.Size = new System.Drawing.Size(812, 291);
            this.dataGridReceber.TabIndex = 2;
            this.dataGridReceber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReceber_CellContentClick);
            // 
            // btn_SairR
            // 
            this.btn_SairR.Location = new System.Drawing.Point(737, 303);
            this.btn_SairR.Name = "btn_SairR";
            this.btn_SairR.Size = new System.Drawing.Size(75, 23);
            this.btn_SairR.TabIndex = 1;
            this.btn_SairR.Text = "&Sair";
            this.btn_SairR.UseVisualStyleBackColor = true;
            this.btn_SairR.Click += new System.EventHandler(this.btn_SairR_Click);
            // 
            // btn_DarBaixaR
            // 
            this.btn_DarBaixaR.Enabled = false;
            this.btn_DarBaixaR.Location = new System.Drawing.Point(656, 304);
            this.btn_DarBaixaR.Name = "btn_DarBaixaR";
            this.btn_DarBaixaR.Size = new System.Drawing.Size(75, 23);
            this.btn_DarBaixaR.TabIndex = 0;
            this.btn_DarBaixaR.Text = "&Dar Baixa";
            this.btn_DarBaixaR.UseVisualStyleBackColor = true;
            this.btn_DarBaixaR.Click += new System.EventHandler(this.btn_DarBaixaR_Click);
            // 
            // tp_Pagar
            // 
            this.tp_Pagar.Controls.Add(this.dataGridPagar);
            this.tp_Pagar.Controls.Add(this.btn_SairP);
            this.tp_Pagar.Controls.Add(this.btn_DarBaixaP);
            this.tp_Pagar.Location = new System.Drawing.Point(4, 22);
            this.tp_Pagar.Name = "tp_Pagar";
            this.tp_Pagar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Pagar.Size = new System.Drawing.Size(818, 333);
            this.tp_Pagar.TabIndex = 1;
            this.tp_Pagar.Text = "Título a Pagar";
            this.tp_Pagar.UseVisualStyleBackColor = true;
            // 
            // dataGridPagar
            // 
            this.dataGridPagar.AllowUserToAddRows = false;
            this.dataGridPagar.AllowUserToDeleteRows = false;
            this.dataGridPagar.AllowUserToOrderColumns = true;
            this.dataGridPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPagar.Location = new System.Drawing.Point(0, 6);
            this.dataGridPagar.MultiSelect = false;
            this.dataGridPagar.Name = "dataGridPagar";
            this.dataGridPagar.ReadOnly = true;
            this.dataGridPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPagar.Size = new System.Drawing.Size(812, 291);
            this.dataGridPagar.TabIndex = 5;
            this.dataGridPagar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPagar_CellContentClick);
            // 
            // btn_SairP
            // 
            this.btn_SairP.Location = new System.Drawing.Point(740, 303);
            this.btn_SairP.Name = "btn_SairP";
            this.btn_SairP.Size = new System.Drawing.Size(75, 23);
            this.btn_SairP.TabIndex = 4;
            this.btn_SairP.Text = "&Sair";
            this.btn_SairP.UseVisualStyleBackColor = true;
            this.btn_SairP.Click += new System.EventHandler(this.btn_SairP_Click);
            // 
            // btn_DarBaixaP
            // 
            this.btn_DarBaixaP.Enabled = false;
            this.btn_DarBaixaP.Location = new System.Drawing.Point(659, 304);
            this.btn_DarBaixaP.Name = "btn_DarBaixaP";
            this.btn_DarBaixaP.Size = new System.Drawing.Size(75, 23);
            this.btn_DarBaixaP.TabIndex = 3;
            this.btn_DarBaixaP.Text = "&Dar Baixa";
            this.btn_DarBaixaP.UseVisualStyleBackColor = true;
            this.btn_DarBaixaP.Click += new System.EventHandler(this.btn_DarBaixaP_Click);
            // 
            // DarBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 363);
            this.Controls.Add(this.tabControl1);
            this.Name = "DarBaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarBaixa";
            this.Load += new System.EventHandler(this.DarBaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloReceberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloReceberBindingSource2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_Receber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceber)).EndInit();
            this.tp_Pagar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bancoFinanceiroDataSet7BindingSource;
        private BancoFinanceiroDataSet7 bancoFinanceiroDataSet7;
        private System.Windows.Forms.BindingSource tituloReceberBindingSource;
        private BancoFinanceiroDataSet7TableAdapters.TituloReceberTableAdapter tituloReceberTableAdapter;
        private System.Windows.Forms.BindingSource tituloReceberBindingSource1;
        private System.Windows.Forms.BindingSource tituloReceberBindingSource2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Receber;
        private System.Windows.Forms.Button btn_SairR;
        private System.Windows.Forms.Button btn_DarBaixaR;
        private System.Windows.Forms.TabPage tp_Pagar;
        private System.Windows.Forms.DataGridView dataGridReceber;
        private System.Windows.Forms.DataGridView dataGridPagar;
        private System.Windows.Forms.Button btn_SairP;
        private System.Windows.Forms.Button btn_DarBaixaP;
    }
}