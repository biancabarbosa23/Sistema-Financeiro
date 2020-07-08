namespace TrabalhoEngenhariaFinanceiro
{
    partial class CadastroTituloPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTituloPagar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Alterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcluirBaixa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Baixa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarForn = new System.Windows.Forms.Button();
            this.tb_NomeForn = new System.Windows.Forms.TextBox();
            this.tb_IdForn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ValorRestante = new System.Windows.Forms.Label();
            this.lbl_ValorRestanteLbl = new System.Windows.Forms.Label();
            this.lb_DataPag = new System.Windows.Forms.Label();
            this.lb_ValorPago = new System.Windows.Forms.Label();
            this.tb_ValorPago = new System.Windows.Forms.TextBox();
            this.tb_DataPag = new System.Windows.Forms.MaskedTextBox();
            this.btn_NovoTipo = new System.Windows.Forms.Button();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.tb_DataVenc = new System.Windows.Forms.MaskedTextBox();
            this.tb_DataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoFinanceiroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoFinanceiroDataSet = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Descr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_IdTitulo = new System.Windows.Forms.TextBox();
            this.bt_Anterior = new System.Windows.Forms.Button();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.btn_Primeiro = new System.Windows.Forms.Button();
            this.btn_Ultimo = new System.Windows.Forms.Button();
            this.tipoTableAdapter = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSetTableAdapters.TipoTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo,
            this.toolStripSeparator1,
            this.btn_Alterar,
            this.toolStripSeparator2,
            this.btn_Excluir,
            this.toolStripSeparator3,
            this.btn_ExcluirBaixa,
            this.toolStripButton4,
            this.btn_Baixa,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(708, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Novo
            // 
            this.btn_Novo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Image")));
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(40, 35);
            this.btn_Novo.Text = "&Novo";
            this.btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Image")));
            this.btn_Alterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(46, 35);
            this.btn_Alterar.Text = "&Alterar";
            this.btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Image")));
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(46, 35);
            this.btn_Excluir.Text = "&Excluir";
            this.btn_Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_ExcluirBaixa
            // 
            this.btn_ExcluirBaixa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_ExcluirBaixa.Enabled = false;
            this.btn_ExcluirBaixa.ForeColor = System.Drawing.Color.White;
            this.btn_ExcluirBaixa.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirBaixa.Image")));
            this.btn_ExcluirBaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcluirBaixa.Name = "btn_ExcluirBaixa";
            this.btn_ExcluirBaixa.Size = new System.Drawing.Size(77, 35);
            this.btn_ExcluirBaixa.Text = "Excluir Baixa";
            this.btn_ExcluirBaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ExcluirBaixa.Click += new System.EventHandler(this.btn_ExcluirBaixa_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_Baixa
            // 
            this.btn_Baixa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Baixa.Enabled = false;
            this.btn_Baixa.ForeColor = System.Drawing.Color.White;
            this.btn_Baixa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Baixa.Image")));
            this.btn_Baixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Baixa.Name = "btn_Baixa";
            this.btn_Baixa.Size = new System.Drawing.Size(60, 35);
            this.btn_Baixa.Text = "&Dar Baixa";
            this.btn_Baixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Baixa.Click += new System.EventHandler(this.btn_Baixa_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 38);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BuscarForn);
            this.groupBox1.Controls.Add(this.tb_NomeForn);
            this.groupBox1.Controls.Add(this.tb_IdForn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedor";
            // 
            // btn_BuscarForn
            // 
            this.btn_BuscarForn.Enabled = false;
            this.btn_BuscarForn.Location = new System.Drawing.Point(512, 46);
            this.btn_BuscarForn.Name = "btn_BuscarForn";
            this.btn_BuscarForn.Size = new System.Drawing.Size(75, 22);
            this.btn_BuscarForn.TabIndex = 3;
            this.btn_BuscarForn.Text = "Buscar";
            this.btn_BuscarForn.UseVisualStyleBackColor = true;
            this.btn_BuscarForn.Click += new System.EventHandler(this.btn_BuscarForn_Click);
            // 
            // tb_NomeForn
            // 
            this.tb_NomeForn.Enabled = false;
            this.tb_NomeForn.Location = new System.Drawing.Point(149, 46);
            this.tb_NomeForn.Name = "tb_NomeForn";
            this.tb_NomeForn.Size = new System.Drawing.Size(343, 20);
            this.tb_NomeForn.TabIndex = 2;
            // 
            // tb_IdForn
            // 
            this.tb_IdForn.Enabled = false;
            this.tb_IdForn.Location = new System.Drawing.Point(26, 46);
            this.tb_IdForn.Name = "tb_IdForn";
            this.tb_IdForn.Size = new System.Drawing.Size(100, 20);
            this.tb_IdForn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ValorRestante);
            this.groupBox2.Controls.Add(this.lbl_ValorRestanteLbl);
            this.groupBox2.Controls.Add(this.lb_DataPag);
            this.groupBox2.Controls.Add(this.lb_ValorPago);
            this.groupBox2.Controls.Add(this.tb_ValorPago);
            this.groupBox2.Controls.Add(this.tb_DataPag);
            this.groupBox2.Controls.Add(this.btn_NovoTipo);
            this.groupBox2.Controls.Add(this.tb_Valor);
            this.groupBox2.Controls.Add(this.tb_DataVenc);
            this.groupBox2.Controls.Add(this.tb_DataEmissao);
            this.groupBox2.Controls.Add(this.cb_Tipo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_Descr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Título";
            // 
            // lbl_ValorRestante
            // 
            this.lbl_ValorRestante.AutoSize = true;
            this.lbl_ValorRestante.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValorRestante.Location = new System.Drawing.Point(504, 131);
            this.lbl_ValorRestante.Name = "lbl_ValorRestante";
            this.lbl_ValorRestante.Size = new System.Drawing.Size(0, 13);
            this.lbl_ValorRestante.TabIndex = 15;
            this.lbl_ValorRestante.Visible = false;
            // 
            // lbl_ValorRestanteLbl
            // 
            this.lbl_ValorRestanteLbl.AutoSize = true;
            this.lbl_ValorRestanteLbl.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValorRestanteLbl.Location = new System.Drawing.Point(426, 131);
            this.lbl_ValorRestanteLbl.Name = "lbl_ValorRestanteLbl";
            this.lbl_ValorRestanteLbl.Size = new System.Drawing.Size(75, 13);
            this.lbl_ValorRestanteLbl.TabIndex = 14;
            this.lbl_ValorRestanteLbl.Text = "Valor restante:";
            this.lbl_ValorRestanteLbl.Visible = false;
            // 
            // lb_DataPag
            // 
            this.lb_DataPag.AutoSize = true;
            this.lb_DataPag.Location = new System.Drawing.Point(426, 80);
            this.lb_DataPag.Name = "lb_DataPag";
            this.lb_DataPag.Size = new System.Drawing.Size(105, 13);
            this.lb_DataPag.TabIndex = 13;
            this.lb_DataPag.Text = "Data do Pagamento:";
            this.lb_DataPag.Visible = false;
            // 
            // lb_ValorPago
            // 
            this.lb_ValorPago.AutoSize = true;
            this.lb_ValorPago.Location = new System.Drawing.Point(543, 83);
            this.lb_ValorPago.Name = "lb_ValorPago";
            this.lb_ValorPago.Size = new System.Drawing.Size(62, 13);
            this.lb_ValorPago.TabIndex = 12;
            this.lb_ValorPago.Text = "Valor Pago:";
            this.lb_ValorPago.Visible = false;
            // 
            // tb_ValorPago
            // 
            this.tb_ValorPago.Enabled = false;
            this.tb_ValorPago.Location = new System.Drawing.Point(543, 99);
            this.tb_ValorPago.Name = "tb_ValorPago";
            this.tb_ValorPago.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorPago.TabIndex = 11;
            this.tb_ValorPago.Visible = false;
            // 
            // tb_DataPag
            // 
            this.tb_DataPag.Enabled = false;
            this.tb_DataPag.Location = new System.Drawing.Point(426, 99);
            this.tb_DataPag.Mask = "00/99/0000";
            this.tb_DataPag.Name = "tb_DataPag";
            this.tb_DataPag.Size = new System.Drawing.Size(100, 20);
            this.tb_DataPag.TabIndex = 10;
            this.tb_DataPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_DataPag.ValidatingType = typeof(System.DateTime);
            this.tb_DataPag.Visible = false;
            // 
            // btn_NovoTipo
            // 
            this.btn_NovoTipo.Location = new System.Drawing.Point(293, 99);
            this.btn_NovoTipo.Name = "btn_NovoTipo";
            this.btn_NovoTipo.Size = new System.Drawing.Size(89, 23);
            this.btn_NovoTipo.TabIndex = 9;
            this.btn_NovoTipo.Text = "Novo Tipo";
            this.btn_NovoTipo.UseVisualStyleBackColor = true;
            this.btn_NovoTipo.Click += new System.EventHandler(this.btn_NovoTipo_Click);
            // 
            // tb_Valor
            // 
            this.tb_Valor.Enabled = false;
            this.tb_Valor.Location = new System.Drawing.Point(26, 99);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(100, 20);
            this.tb_Valor.TabIndex = 6;
            // 
            // tb_DataVenc
            // 
            this.tb_DataVenc.Enabled = false;
            this.tb_DataVenc.Location = new System.Drawing.Point(543, 45);
            this.tb_DataVenc.Mask = "99/99/9999";
            this.tb_DataVenc.Name = "tb_DataVenc";
            this.tb_DataVenc.Size = new System.Drawing.Size(100, 20);
            this.tb_DataVenc.TabIndex = 5;
            this.tb_DataVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_DataEmissao
            // 
            this.tb_DataEmissao.Enabled = false;
            this.tb_DataEmissao.Location = new System.Drawing.Point(426, 45);
            this.tb_DataEmissao.Mask = "00/99/0000";
            this.tb_DataEmissao.Name = "tb_DataEmissao";
            this.tb_DataEmissao.Size = new System.Drawing.Size(100, 20);
            this.tb_DataEmissao.TabIndex = 4;
            this.tb_DataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_DataEmissao.ValidatingType = typeof(System.DateTime);
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.Enabled = false;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(148, 99);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_Tipo.TabIndex = 7;
            this.cb_Tipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_Tipo_MouseClick);
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "Tipo";
            this.tipoBindingSource.DataSource = this.bancoFinanceiroDataSetBindingSource;
            // 
            // bancoFinanceiroDataSetBindingSource
            // 
            this.bancoFinanceiroDataSetBindingSource.DataSource = this.bancoFinanceiroDataSet;
            this.bancoFinanceiroDataSetBindingSource.Position = 0;
            // 
            // bancoFinanceiroDataSet
            // 
            this.bancoFinanceiroDataSet.DataSetName = "BancoFinanceiroDataSet";
            this.bancoFinanceiroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo";
            // 
            // tb_Descr
            // 
            this.tb_Descr.Enabled = false;
            this.tb_Descr.Location = new System.Drawing.Point(26, 44);
            this.tb_Descr.Name = "tb_Descr";
            this.tb_Descr.Size = new System.Drawing.Size(376, 20);
            this.tb_Descr.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data de Vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Emissão";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Location = new System.Drawing.Point(519, 329);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "&Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(600, 328);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 9;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Codigo Título:";
            // 
            // tb_IdTitulo
            // 
            this.tb_IdTitulo.Enabled = false;
            this.tb_IdTitulo.Location = new System.Drawing.Point(605, 49);
            this.tb_IdTitulo.Name = "tb_IdTitulo";
            this.tb_IdTitulo.Size = new System.Drawing.Size(75, 20);
            this.tb_IdTitulo.TabIndex = 8;
            // 
            // bt_Anterior
            // 
            this.bt_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Anterior.Location = new System.Drawing.Point(62, 328);
            this.bt_Anterior.Name = "bt_Anterior";
            this.bt_Anterior.Size = new System.Drawing.Size(46, 23);
            this.bt_Anterior.TabIndex = 10;
            this.bt_Anterior.Text = "<";
            this.bt_Anterior.UseVisualStyleBackColor = true;
            this.bt_Anterior.Click += new System.EventHandler(this.bt_Anterior_Click);
            // 
            // bt_Proximo
            // 
            this.bt_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Proximo.Location = new System.Drawing.Point(114, 328);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(46, 23);
            this.bt_Proximo.TabIndex = 11;
            this.bt_Proximo.Text = ">";
            this.bt_Proximo.UseVisualStyleBackColor = true;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
            // 
            // btn_Primeiro
            // 
            this.btn_Primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Primeiro.Location = new System.Drawing.Point(10, 328);
            this.btn_Primeiro.Name = "btn_Primeiro";
            this.btn_Primeiro.Size = new System.Drawing.Size(46, 23);
            this.btn_Primeiro.TabIndex = 12;
            this.btn_Primeiro.Text = "<<";
            this.btn_Primeiro.UseVisualStyleBackColor = true;
            this.btn_Primeiro.Click += new System.EventHandler(this.btn_Primeiro_Click);
            // 
            // btn_Ultimo
            // 
            this.btn_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ultimo.Location = new System.Drawing.Point(166, 328);
            this.btn_Ultimo.Name = "btn_Ultimo";
            this.btn_Ultimo.Size = new System.Drawing.Size(46, 23);
            this.btn_Ultimo.TabIndex = 13;
            this.btn_Ultimo.Text = ">>";
            this.btn_Ultimo.UseVisualStyleBackColor = true;
            this.btn_Ultimo.Click += new System.EventHandler(this.btn_Ultimo_Click);
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroTituloPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 363);
            this.Controls.Add(this.btn_Ultimo);
            this.Controls.Add(this.btn_Primeiro);
            this.Controls.Add(this.bt_Proximo);
            this.Controls.Add(this.bt_Anterior);
            this.Controls.Add(this.tb_IdTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CadastroTituloPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroTituloPagar";
            this.Load += new System.EventHandler(this.CadastroTituloPagar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Alterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Descr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_IdTitulo;
        private System.Windows.Forms.MaskedTextBox tb_DataVenc;
        private System.Windows.Forms.MaskedTextBox tb_DataEmissao;
        private System.Windows.Forms.Button bt_Anterior;
        private System.Windows.Forms.Button bt_Proximo;
        private System.Windows.Forms.Button btn_Primeiro;
        private System.Windows.Forms.Button btn_Ultimo;
        private System.Windows.Forms.Button btn_BuscarForn;
        private System.Windows.Forms.Button btn_NovoTipo;
        private BancoFinanceiroDataSet bancoFinanceiroDataSet;
        private System.Windows.Forms.BindingSource bancoFinanceiroDataSetBindingSource;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private BancoFinanceiroDataSetTableAdapters.TipoTableAdapter tipoTableAdapter;
        public System.Windows.Forms.TextBox tb_NomeForn;
        public System.Windows.Forms.TextBox tb_IdForn;
        private System.Windows.Forms.TextBox tb_Valor;
        private System.Windows.Forms.Label lb_DataPag;
        private System.Windows.Forms.Label lb_ValorPago;
        private System.Windows.Forms.TextBox tb_ValorPago;
        private System.Windows.Forms.MaskedTextBox tb_DataPag;
        private System.Windows.Forms.ToolStripButton btn_Baixa;
        private System.Windows.Forms.ToolStripButton btn_ExcluirBaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.Label lbl_ValorRestante;
        private System.Windows.Forms.Label lbl_ValorRestanteLbl;
    }
}