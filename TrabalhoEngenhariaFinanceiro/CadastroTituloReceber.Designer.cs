namespace TrabalhoEngenhariaFinanceiro
{
    partial class CadastroTituloReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTituloReceber));
            this.btn_Ultimo = new System.Windows.Forms.Button();
            this.btn_Primeiro = new System.Windows.Forms.Button();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.bt_Anterior = new System.Windows.Forms.Button();
            this.tb_IdTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ValorRestante = new System.Windows.Forms.Label();
            this.lbl_ValorRestanteLbl = new System.Windows.Forms.Label();
            this.lb_DataPag = new System.Windows.Forms.Label();
            this.lb_ValorPago = new System.Windows.Forms.Label();
            this.tb_ValorPago = new System.Windows.Forms.TextBox();
            this.tb_DataPag = new System.Windows.Forms.MaskedTextBox();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.btn_NovoTitulo = new System.Windows.Forms.Button();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.tb_DataVenc = new System.Windows.Forms.MaskedTextBox();
            this.tb_DataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Descr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoFinanceiroDataSet4 = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet4();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.tb_NomeCliente = new System.Windows.Forms.TextBox();
            this.tb_IdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tipoTableAdapter = new TrabalhoEngenhariaFinanceiro.BancoFinanceiroDataSet4TableAdapters.TipoTableAdapter();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Ultimo
            // 
            this.btn_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ultimo.Location = new System.Drawing.Point(166, 327);
            this.btn_Ultimo.Name = "btn_Ultimo";
            this.btn_Ultimo.Size = new System.Drawing.Size(46, 23);
            this.btn_Ultimo.TabIndex = 23;
            this.btn_Ultimo.Text = ">>";
            this.btn_Ultimo.UseVisualStyleBackColor = true;
            this.btn_Ultimo.Click += new System.EventHandler(this.btn_Ultimo_Click);
            // 
            // btn_Primeiro
            // 
            this.btn_Primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Primeiro.Location = new System.Drawing.Point(10, 327);
            this.btn_Primeiro.Name = "btn_Primeiro";
            this.btn_Primeiro.Size = new System.Drawing.Size(46, 23);
            this.btn_Primeiro.TabIndex = 22;
            this.btn_Primeiro.Text = "<<";
            this.btn_Primeiro.UseVisualStyleBackColor = true;
            this.btn_Primeiro.Click += new System.EventHandler(this.btn_Primeiro_Click);
            // 
            // bt_Proximo
            // 
            this.bt_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Proximo.Location = new System.Drawing.Point(114, 327);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(46, 23);
            this.bt_Proximo.TabIndex = 21;
            this.bt_Proximo.Text = ">";
            this.bt_Proximo.UseVisualStyleBackColor = true;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
            // 
            // bt_Anterior
            // 
            this.bt_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Anterior.Location = new System.Drawing.Point(62, 327);
            this.bt_Anterior.Name = "bt_Anterior";
            this.bt_Anterior.Size = new System.Drawing.Size(46, 23);
            this.bt_Anterior.TabIndex = 20;
            this.bt_Anterior.Text = "<";
            this.bt_Anterior.UseVisualStyleBackColor = true;
            this.bt_Anterior.Click += new System.EventHandler(this.bt_Anterior_Click);
            // 
            // tb_IdTitulo
            // 
            this.tb_IdTitulo.Enabled = false;
            this.tb_IdTitulo.Location = new System.Drawing.Point(605, 48);
            this.tb_IdTitulo.Name = "tb_IdTitulo";
            this.tb_IdTitulo.Size = new System.Drawing.Size(75, 20);
            this.tb_IdTitulo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Codigo Título:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(605, 327);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 19;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(524, 328);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 18;
            this.btn_Salvar.Text = "&Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ValorRestante);
            this.groupBox2.Controls.Add(this.lbl_ValorRestanteLbl);
            this.groupBox2.Controls.Add(this.lb_DataPag);
            this.groupBox2.Controls.Add(this.lb_ValorPago);
            this.groupBox2.Controls.Add(this.tb_ValorPago);
            this.groupBox2.Controls.Add(this.tb_DataPag);
            this.groupBox2.Controls.Add(this.cb_Tipo);
            this.groupBox2.Controls.Add(this.btn_NovoTitulo);
            this.groupBox2.Controls.Add(this.tb_Valor);
            this.groupBox2.Controls.Add(this.tb_DataVenc);
            this.groupBox2.Controls.Add(this.tb_DataEmissao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_Descr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 150);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Título";
            // 
            // lbl_ValorRestante
            // 
            this.lbl_ValorRestante.AutoSize = true;
            this.lbl_ValorRestante.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValorRestante.Location = new System.Drawing.Point(501, 134);
            this.lbl_ValorRestante.Name = "lbl_ValorRestante";
            this.lbl_ValorRestante.Size = new System.Drawing.Size(0, 13);
            this.lbl_ValorRestante.TabIndex = 30;
            this.lbl_ValorRestante.Visible = false;
            // 
            // lbl_ValorRestanteLbl
            // 
            this.lbl_ValorRestanteLbl.AutoSize = true;
            this.lbl_ValorRestanteLbl.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValorRestanteLbl.Location = new System.Drawing.Point(423, 134);
            this.lbl_ValorRestanteLbl.Name = "lbl_ValorRestanteLbl";
            this.lbl_ValorRestanteLbl.Size = new System.Drawing.Size(75, 13);
            this.lbl_ValorRestanteLbl.TabIndex = 29;
            this.lbl_ValorRestanteLbl.Text = "Valor restante:";
            this.lbl_ValorRestanteLbl.Visible = false;
            // 
            // lb_DataPag
            // 
            this.lb_DataPag.AutoSize = true;
            this.lb_DataPag.Location = new System.Drawing.Point(423, 82);
            this.lb_DataPag.Name = "lb_DataPag";
            this.lb_DataPag.Size = new System.Drawing.Size(105, 13);
            this.lb_DataPag.TabIndex = 28;
            this.lb_DataPag.Text = "Data do Pagamento:";
            this.lb_DataPag.Visible = false;
            // 
            // lb_ValorPago
            // 
            this.lb_ValorPago.AutoSize = true;
            this.lb_ValorPago.Location = new System.Drawing.Point(540, 85);
            this.lb_ValorPago.Name = "lb_ValorPago";
            this.lb_ValorPago.Size = new System.Drawing.Size(62, 13);
            this.lb_ValorPago.TabIndex = 27;
            this.lb_ValorPago.Text = "Valor Pago:";
            this.lb_ValorPago.Visible = false;
            // 
            // tb_ValorPago
            // 
            this.tb_ValorPago.Enabled = false;
            this.tb_ValorPago.Location = new System.Drawing.Point(540, 101);
            this.tb_ValorPago.Name = "tb_ValorPago";
            this.tb_ValorPago.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorPago.TabIndex = 26;
            this.tb_ValorPago.Visible = false;
            // 
            // tb_DataPag
            // 
            this.tb_DataPag.Enabled = false;
            this.tb_DataPag.Location = new System.Drawing.Point(423, 101);
            this.tb_DataPag.Mask = "00/99/0000";
            this.tb_DataPag.Name = "tb_DataPag";
            this.tb_DataPag.Size = new System.Drawing.Size(100, 20);
            this.tb_DataPag.TabIndex = 25;
            this.tb_DataPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_DataPag.ValidatingType = typeof(System.DateTime);
            this.tb_DataPag.Visible = false;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.Enabled = false;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(148, 98);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_Tipo.TabIndex = 24;
            this.cb_Tipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_Tipo_MouseClick);
            // 
            // btn_NovoTitulo
            // 
            this.btn_NovoTitulo.Location = new System.Drawing.Point(293, 99);
            this.btn_NovoTitulo.Name = "btn_NovoTitulo";
            this.btn_NovoTitulo.Size = new System.Drawing.Size(89, 23);
            this.btn_NovoTitulo.TabIndex = 9;
            this.btn_NovoTitulo.Text = "Novo Tipo";
            this.btn_NovoTitulo.UseVisualStyleBackColor = true;
            this.btn_NovoTitulo.Click += new System.EventHandler(this.btn_NovoTitulo_Click);
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
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "Tipo";
            this.tipoBindingSource.DataSource = this.bancoFinanceiroDataSet4;
            // 
            // bancoFinanceiroDataSet4
            // 
            this.bancoFinanceiroDataSet4.DataSetName = "BancoFinanceiroDataSet4";
            this.bancoFinanceiroDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BuscarCliente);
            this.groupBox1.Controls.Add(this.tb_NomeCliente);
            this.groupBox1.Controls.Add(this.tb_IdCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Enabled = false;
            this.btn_BuscarCliente.Location = new System.Drawing.Point(512, 46);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(75, 22);
            this.btn_BuscarCliente.TabIndex = 3;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // tb_NomeCliente
            // 
            this.tb_NomeCliente.Enabled = false;
            this.tb_NomeCliente.Location = new System.Drawing.Point(149, 46);
            this.tb_NomeCliente.Name = "tb_NomeCliente";
            this.tb_NomeCliente.Size = new System.Drawing.Size(343, 20);
            this.tb_NomeCliente.TabIndex = 2;
            // 
            // tb_IdCliente
            // 
            this.tb_IdCliente.Enabled = false;
            this.tb_IdCliente.Location = new System.Drawing.Point(26, 46);
            this.tb_IdCliente.Name = "tb_IdCliente";
            this.tb_IdCliente.Size = new System.Drawing.Size(100, 20);
            this.tb_IdCliente.TabIndex = 1;
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
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
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
            this.toolStrip1.TabIndex = 25;
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
            // CadastroTituloReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 363);
            this.Controls.Add(this.toolStrip1);
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
            this.Name = "CadastroTituloReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroTituloReceber";
            this.Load += new System.EventHandler(this.CadastroTituloReceber_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoFinanceiroDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Ultimo;
        private System.Windows.Forms.Button btn_Primeiro;
        private System.Windows.Forms.Button bt_Proximo;
        private System.Windows.Forms.Button bt_Anterior;
        private System.Windows.Forms.TextBox tb_IdTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_NovoTitulo;
        private System.Windows.Forms.TextBox tb_Valor;
        private System.Windows.Forms.MaskedTextBox tb_DataVenc;
        private System.Windows.Forms.MaskedTextBox tb_DataEmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Descr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private BancoFinanceiroDataSet4 bancoFinanceiroDataSet4;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private BancoFinanceiroDataSet4TableAdapters.TipoTableAdapter tipoTableAdapter;
        public System.Windows.Forms.TextBox tb_NomeCliente;
        public System.Windows.Forms.TextBox tb_IdCliente;
        private System.Windows.Forms.Label lb_DataPag;
        private System.Windows.Forms.Label lb_ValorPago;
        private System.Windows.Forms.TextBox tb_ValorPago;
        private System.Windows.Forms.MaskedTextBox tb_DataPag;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Alterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_ExcluirBaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton btn_Baixa;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.Label lbl_ValorRestante;
        private System.Windows.Forms.Label lbl_ValorRestanteLbl;
    }
}