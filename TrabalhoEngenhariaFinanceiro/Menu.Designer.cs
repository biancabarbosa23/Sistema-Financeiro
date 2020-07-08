namespace TrabalhoEngenhariaFinanceiro
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_TituloPagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_TituloReceber = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ManterTipo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_DarBaixa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TituloPagar,
            this.toolStripSeparator1,
            this.btn_TituloReceber,
            this.toolStripSeparator2,
            this.btn_ManterTipo,
            this.toolStripSeparator3,
            this.btn_DarBaixa,
            this.toolStripSeparator4,
            this.btn_Consultar,
            this.toolStripSeparator5});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(717, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_TituloPagar
            // 
            this.btn_TituloPagar.CheckOnClick = true;
            this.btn_TituloPagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_TituloPagar.Image = ((System.Drawing.Image)(resources.GetObject("btn_TituloPagar.Image")));
            this.btn_TituloPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TituloPagar.Name = "btn_TituloPagar";
            this.btn_TituloPagar.Size = new System.Drawing.Size(129, 22);
            this.btn_TituloPagar.Text = "Manter Títulos a Pagar";
            this.btn_TituloPagar.Click += new System.EventHandler(this.btn_TituloPagar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_TituloReceber
            // 
            this.btn_TituloReceber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_TituloReceber.Image = ((System.Drawing.Image)(resources.GetObject("btn_TituloReceber.Image")));
            this.btn_TituloReceber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TituloReceber.Name = "btn_TituloReceber";
            this.btn_TituloReceber.Size = new System.Drawing.Size(141, 22);
            this.btn_TituloReceber.Text = "Manter Títulos a Receber";
            this.btn_TituloReceber.Click += new System.EventHandler(this.btn_TituloReceber_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ManterTipo
            // 
            this.btn_ManterTipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ManterTipo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManterTipo.Image")));
            this.btn_ManterTipo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ManterTipo.Name = "btn_ManterTipo";
            this.btn_ManterTipo.Size = new System.Drawing.Size(124, 22);
            this.btn_ManterTipo.Text = "Tipos de Pagamentos";
            this.btn_ManterTipo.Click += new System.EventHandler(this.btn_ManterTipo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_DarBaixa
            // 
            this.btn_DarBaixa.AutoSize = false;
            this.btn_DarBaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_DarBaixa.Image = ((System.Drawing.Image)(resources.GetObject("btn_DarBaixa.Image")));
            this.btn_DarBaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DarBaixa.Name = "btn_DarBaixa";
            this.btn_DarBaixa.Size = new System.Drawing.Size(124, 22);
            this.btn_DarBaixa.Text = "Baixar Títulos";
            this.btn_DarBaixa.Click += new System.EventHandler(this.btn_DarBaixa_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.AutoSize = false;
            this.btn_Consultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.Image")));
            this.btn_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(124, 22);
            this.btn_Consultar.Text = "Consultar Títulos";
            this.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 479);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_TituloPagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_TituloReceber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_ManterTipo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_DarBaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Consultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

