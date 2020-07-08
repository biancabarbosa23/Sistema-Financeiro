namespace TrabalhoEngenhariaFinanceiro
{
    partial class BuscaFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NomeForn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoFinanceiroDataSet2 = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet2();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.fornecedorTableAdapter = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet2TableAdapters.FornecedorTableAdapter();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tb_NomeForn
            // 
            this.tb_NomeForn.Location = new System.Drawing.Point(56, 31);
            this.tb_NomeForn.Name = "tb_NomeForn";
            this.tb_NomeForn.Size = new System.Drawing.Size(305, 20);
            this.tb_NomeForn.TabIndex = 1;
            this.tb_NomeForn.TextChanged += new System.EventHandler(this.tb_NomeForn_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idForn,
            this.nome});
            this.dataGridView1.DataSource = this.fornecedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(349, 290);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idForn
            // 
            this.idForn.DataPropertyName = "IdForn";
            this.idForn.HeaderText = "IdForn";
            this.idForn.Name = "idForn";
            this.idForn.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.bancoFinanceiroDataSet2;
            // 
            // bancoFinanceiroDataSet2
            // 
            this.bancoFinanceiroDataSet2.DataSetName = "BancoFinanceiroDataSet2";
            this.bancoFinanceiroDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(296, 356);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.Location = new System.Drawing.Point(215, 356);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Selecionar.TabIndex = 5;
            this.btn_Selecionar.Text = "&Selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = true;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // BuscaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 391);
            this.Controls.Add(this.btn_Selecionar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_NomeForn);
            this.Controls.Add(this.label1);
            this.Name = "BuscaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaFornecedor";
            this.Load += new System.EventHandler(this.BuscaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NomeForn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sair;
        private BancoFinanceiroDataSet2 bancoFinanceiroDataSet2;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private BancoFinanceiroDataSet2TableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}