namespace TrabalhoEngenhariaFinanceiro
{
    partial class ValoresBaixa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_DataPag = new System.Windows.Forms.Label();
            this.lb_ValorPago = new System.Windows.Forms.Label();
            this.tb_ValorPago = new System.Windows.Forms.TextBox();
            this.tb_DataPag = new System.Windows.Forms.MaskedTextBox();
            this.btn_DarBaixa = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_DataPag);
            this.groupBox1.Controls.Add(this.lb_ValorPago);
            this.groupBox1.Controls.Add(this.tb_ValorPago);
            this.groupBox1.Controls.Add(this.tb_DataPag);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 135);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // lb_DataPag
            // 
            this.lb_DataPag.AutoSize = true;
            this.lb_DataPag.Location = new System.Drawing.Point(44, 20);
            this.lb_DataPag.Name = "lb_DataPag";
            this.lb_DataPag.Size = new System.Drawing.Size(105, 13);
            this.lb_DataPag.TabIndex = 21;
            this.lb_DataPag.Text = "Data do Pagamento:";
            // 
            // lb_ValorPago
            // 
            this.lb_ValorPago.AutoSize = true;
            this.lb_ValorPago.Location = new System.Drawing.Point(61, 79);
            this.lb_ValorPago.Name = "lb_ValorPago";
            this.lb_ValorPago.Size = new System.Drawing.Size(62, 13);
            this.lb_ValorPago.TabIndex = 20;
            this.lb_ValorPago.Text = "Valor Pago:";
            // 
            // tb_ValorPago
            // 
            this.tb_ValorPago.Location = new System.Drawing.Point(44, 95);
            this.tb_ValorPago.Name = "tb_ValorPago";
            this.tb_ValorPago.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorPago.TabIndex = 19;
            // 
            // tb_DataPag
            // 
            this.tb_DataPag.Location = new System.Drawing.Point(44, 39);
            this.tb_DataPag.Mask = "00/99/0000";
            this.tb_DataPag.Name = "tb_DataPag";
            this.tb_DataPag.Size = new System.Drawing.Size(100, 20);
            this.tb_DataPag.TabIndex = 18;
            this.tb_DataPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_DataPag.ValidatingType = typeof(System.DateTime);
            // 
            // btn_DarBaixa
            // 
            this.btn_DarBaixa.Location = new System.Drawing.Point(24, 191);
            this.btn_DarBaixa.Name = "btn_DarBaixa";
            this.btn_DarBaixa.Size = new System.Drawing.Size(75, 23);
            this.btn_DarBaixa.TabIndex = 19;
            this.btn_DarBaixa.Text = "&Dar Baixa";
            this.btn_DarBaixa.UseVisualStyleBackColor = true;
            this.btn_DarBaixa.Click += new System.EventHandler(this.btn_DarBaixa_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(115, 191);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 20;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // ValoresBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 226);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_DarBaixa);
            this.Controls.Add(this.groupBox1);
            this.Name = "ValoresBaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValoresBaixa";
            this.Load += new System.EventHandler(this.ValoresBaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_DataPag;
        private System.Windows.Forms.Label lb_ValorPago;
        private System.Windows.Forms.TextBox tb_ValorPago;
        private System.Windows.Forms.MaskedTextBox tb_DataPag;
        private System.Windows.Forms.Button btn_DarBaixa;
        private System.Windows.Forms.Button btn_Sair;
    }
}