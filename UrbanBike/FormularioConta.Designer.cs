namespace UrbanBike
{
    partial class FormularioConta
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
            this.txbNumeroConta = new System.Windows.Forms.TextBox();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNumeroConta
            // 
            this.txbNumeroConta.Location = new System.Drawing.Point(109, 15);
            this.txbNumeroConta.Name = "txbNumeroConta";
            this.txbNumeroConta.Size = new System.Drawing.Size(172, 20);
            this.txbNumeroConta.TabIndex = 0;
            this.txbNumeroConta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Location = new System.Drawing.Point(13, 18);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroConta.TabIndex = 1;
            this.lblNumeroConta.Text = "Número da Conta";
            this.lblNumeroConta.Click += new System.EventHandler(this.lblNumeroConta_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 51);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(31, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Valor";
            this.lblSaldo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSaldo
            // 
            this.txbSaldo.Location = new System.Drawing.Point(109, 51);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(172, 20);
            this.txbSaldo.TabIndex = 3;
            this.txbSaldo.TextChanged += new System.EventHandler(this.txbSaldo_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 87);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Creditar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormularioConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 120);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNumeroConta);
            this.Controls.Add(this.txbNumeroConta);
            this.Name = "FormularioConta";
            this.Text = "FormularioConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbNumeroConta;
        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.Label lblSaldo;
        public System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.Button btnSalvar;
    }
}