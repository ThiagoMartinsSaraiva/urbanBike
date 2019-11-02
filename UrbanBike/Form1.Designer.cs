namespace UrbanBike
{
    partial class frmUrbanBike
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
            this.btnRemoverPedal = new System.Windows.Forms.Button();
            this.dgvPedais = new System.Windows.Forms.DataGridView();
            this.NumeroConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbPremium = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.txbNumeroConta = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnCreditar = new System.Windows.Forms.Button();
            this.gbAdicionar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCreditar = new System.Windows.Forms.GroupBox();
            this.btnCreditarPedal = new System.Windows.Forms.Button();
            this.txbValorCreditar = new System.Windows.Forms.TextBox();
            this.lblValorCreditar = new System.Windows.Forms.Label();
            this.lblNumeroContaCreditar = new System.Windows.Forms.Label();
            this.txbNumeroContaCreditar = new System.Windows.Forms.TextBox();
            this.gbTransferir = new System.Windows.Forms.GroupBox();
            this.btnTransferirPedal = new System.Windows.Forms.Button();
            this.txbValorTransferencia = new System.Windows.Forms.TextBox();
            this.lblValorTransferencia = new System.Windows.Forms.Label();
            this.cbbNumeroConta = new System.Windows.Forms.ComboBox();
            this.lblNumeroContaTransferir = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPedalar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedais)).BeginInit();
            this.gbAdicionar.SuspendLayout();
            this.gbCreditar.SuspendLayout();
            this.gbTransferir.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoverPedal
            // 
            this.btnRemoverPedal.Enabled = false;
            this.btnRemoverPedal.Location = new System.Drawing.Point(107, 177);
            this.btnRemoverPedal.Name = "btnRemoverPedal";
            this.btnRemoverPedal.Size = new System.Drawing.Size(92, 23);
            this.btnRemoverPedal.TabIndex = 1;
            this.btnRemoverPedal.Text = "Remover Pedal";
            this.btnRemoverPedal.UseVisualStyleBackColor = true;
            this.btnRemoverPedal.Click += new System.EventHandler(this.btnRemoverPedal_Click);
            // 
            // dgvPedais
            // 
            this.dgvPedais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroConta,
            this.Saldo,
            this.Premium});
            this.dgvPedais.Location = new System.Drawing.Point(2, 206);
            this.dgvPedais.Name = "dgvPedais";
            this.dgvPedais.Size = new System.Drawing.Size(387, 153);
            this.dgvPedais.TabIndex = 6;
            this.dgvPedais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedais_CellContentClick);
            // 
            // NumeroConta
            // 
            this.NumeroConta.HeaderText = "Número da Conta";
            this.NumeroConta.Name = "NumeroConta";
            this.NumeroConta.Width = 120;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Premium
            // 
            this.Premium.HeaderText = "Premium";
            this.Premium.Name = "Premium";
            // 
            // chbPremium
            // 
            this.chbPremium.AutoSize = true;
            this.chbPremium.Location = new System.Drawing.Point(111, 85);
            this.chbPremium.Name = "chbPremium";
            this.chbPremium.Size = new System.Drawing.Size(66, 17);
            this.chbPremium.TabIndex = 12;
            this.chbPremium.Text = "Premium";
            this.chbPremium.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 120);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbSaldo
            // 
            this.txbSaldo.Location = new System.Drawing.Point(111, 59);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(105, 20);
            this.txbSaldo.TabIndex = 10;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 62);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Location = new System.Drawing.Point(15, 33);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroConta.TabIndex = 8;
            this.lblNumeroConta.Text = "Número da Conta";
            // 
            // txbNumeroConta
            // 
            this.txbNumeroConta.Location = new System.Drawing.Point(111, 30);
            this.txbNumeroConta.Name = "txbNumeroConta";
            this.txbNumeroConta.Size = new System.Drawing.Size(105, 20);
            this.txbNumeroConta.TabIndex = 7;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Enabled = false;
            this.btnTransferir.Location = new System.Drawing.Point(218, 177);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 13;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnCreditar
            // 
            this.btnCreditar.Enabled = false;
            this.btnCreditar.Location = new System.Drawing.Point(314, 177);
            this.btnCreditar.Name = "btnCreditar";
            this.btnCreditar.Size = new System.Drawing.Size(75, 23);
            this.btnCreditar.TabIndex = 14;
            this.btnCreditar.Text = "Creditar";
            this.btnCreditar.UseVisualStyleBackColor = true;
            this.btnCreditar.Click += new System.EventHandler(this.btnCreditar_Click);
            // 
            // gbAdicionar
            // 
            this.gbAdicionar.Controls.Add(this.label1);
            this.gbAdicionar.Controls.Add(this.txbSaldo);
            this.gbAdicionar.Controls.Add(this.txbNumeroConta);
            this.gbAdicionar.Controls.Add(this.lblNumeroConta);
            this.gbAdicionar.Controls.Add(this.chbPremium);
            this.gbAdicionar.Controls.Add(this.lblSaldo);
            this.gbAdicionar.Controls.Add(this.btnSalvar);
            this.gbAdicionar.Location = new System.Drawing.Point(12, 12);
            this.gbAdicionar.Name = "gbAdicionar";
            this.gbAdicionar.Size = new System.Drawing.Size(230, 150);
            this.gbAdicionar.TabIndex = 15;
            this.gbAdicionar.TabStop = false;
            this.gbAdicionar.Text = "Adicionar Pedal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo";
            // 
            // gbCreditar
            // 
            this.gbCreditar.Controls.Add(this.btnCreditarPedal);
            this.gbCreditar.Controls.Add(this.txbValorCreditar);
            this.gbCreditar.Controls.Add(this.lblValorCreditar);
            this.gbCreditar.Controls.Add(this.lblNumeroContaCreditar);
            this.gbCreditar.Controls.Add(this.txbNumeroContaCreditar);
            this.gbCreditar.Location = new System.Drawing.Point(260, 12);
            this.gbCreditar.Name = "gbCreditar";
            this.gbCreditar.Size = new System.Drawing.Size(216, 102);
            this.gbCreditar.TabIndex = 16;
            this.gbCreditar.TabStop = false;
            this.gbCreditar.Text = "Creditar Pedal";
            this.gbCreditar.Visible = false;
            // 
            // btnCreditarPedal
            // 
            this.btnCreditarPedal.Location = new System.Drawing.Point(5, 62);
            this.btnCreditarPedal.Name = "btnCreditarPedal";
            this.btnCreditarPedal.Size = new System.Drawing.Size(75, 23);
            this.btnCreditarPedal.TabIndex = 9;
            this.btnCreditarPedal.Text = "Ok";
            this.btnCreditarPedal.UseVisualStyleBackColor = true;
            this.btnCreditarPedal.Click += new System.EventHandler(this.btnCreditarPedal_Click);
            // 
            // txbValorCreditar
            // 
            this.txbValorCreditar.Location = new System.Drawing.Point(98, 42);
            this.txbValorCreditar.Name = "txbValorCreditar";
            this.txbValorCreditar.Size = new System.Drawing.Size(105, 20);
            this.txbValorCreditar.TabIndex = 8;
            // 
            // lblValorCreditar
            // 
            this.lblValorCreditar.AutoSize = true;
            this.lblValorCreditar.Location = new System.Drawing.Point(2, 40);
            this.lblValorCreditar.Name = "lblValorCreditar";
            this.lblValorCreditar.Size = new System.Drawing.Size(31, 13);
            this.lblValorCreditar.TabIndex = 7;
            this.lblValorCreditar.Text = "Valor";
            // 
            // lblNumeroContaCreditar
            // 
            this.lblNumeroContaCreditar.AutoSize = true;
            this.lblNumeroContaCreditar.Location = new System.Drawing.Point(2, 19);
            this.lblNumeroContaCreditar.Name = "lblNumeroContaCreditar";
            this.lblNumeroContaCreditar.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroContaCreditar.TabIndex = 6;
            this.lblNumeroContaCreditar.Text = "Número da Conta";
            // 
            // txbNumeroContaCreditar
            // 
            this.txbNumeroContaCreditar.Enabled = false;
            this.txbNumeroContaCreditar.Location = new System.Drawing.Point(98, 16);
            this.txbNumeroContaCreditar.Name = "txbNumeroContaCreditar";
            this.txbNumeroContaCreditar.Size = new System.Drawing.Size(105, 20);
            this.txbNumeroContaCreditar.TabIndex = 5;
            // 
            // gbTransferir
            // 
            this.gbTransferir.Controls.Add(this.btnTransferirPedal);
            this.gbTransferir.Controls.Add(this.txbValorTransferencia);
            this.gbTransferir.Controls.Add(this.lblValorTransferencia);
            this.gbTransferir.Controls.Add(this.cbbNumeroConta);
            this.gbTransferir.Controls.Add(this.lblNumeroContaTransferir);
            this.gbTransferir.Location = new System.Drawing.Point(493, 14);
            this.gbTransferir.Name = "gbTransferir";
            this.gbTransferir.Size = new System.Drawing.Size(248, 100);
            this.gbTransferir.TabIndex = 17;
            this.gbTransferir.TabStop = false;
            this.gbTransferir.Text = "Transferir Pedal";
            this.gbTransferir.Visible = false;
            // 
            // btnTransferirPedal
            // 
            this.btnTransferirPedal.Location = new System.Drawing.Point(6, 71);
            this.btnTransferirPedal.Name = "btnTransferirPedal";
            this.btnTransferirPedal.Size = new System.Drawing.Size(75, 23);
            this.btnTransferirPedal.TabIndex = 4;
            this.btnTransferirPedal.Text = "Transferir";
            this.btnTransferirPedal.UseVisualStyleBackColor = true;
            this.btnTransferirPedal.Click += new System.EventHandler(this.btnTransferirPedal_Click);
            // 
            // txbValorTransferencia
            // 
            this.txbValorTransferencia.Location = new System.Drawing.Point(103, 43);
            this.txbValorTransferencia.Name = "txbValorTransferencia";
            this.txbValorTransferencia.Size = new System.Drawing.Size(121, 20);
            this.txbValorTransferencia.TabIndex = 3;
            // 
            // lblValorTransferencia
            // 
            this.lblValorTransferencia.AutoSize = true;
            this.lblValorTransferencia.Location = new System.Drawing.Point(10, 46);
            this.lblValorTransferencia.Name = "lblValorTransferencia";
            this.lblValorTransferencia.Size = new System.Drawing.Size(31, 13);
            this.lblValorTransferencia.TabIndex = 2;
            this.lblValorTransferencia.Text = "Valor";
            // 
            // cbbNumeroConta
            // 
            this.cbbNumeroConta.FormattingEnabled = true;
            this.cbbNumeroConta.Location = new System.Drawing.Point(103, 17);
            this.cbbNumeroConta.Name = "cbbNumeroConta";
            this.cbbNumeroConta.Size = new System.Drawing.Size(121, 21);
            this.cbbNumeroConta.TabIndex = 1;
            this.cbbNumeroConta.Text = "Selecione";
            // 
            // lblNumeroContaTransferir
            // 
            this.lblNumeroContaTransferir.AutoSize = true;
            this.lblNumeroContaTransferir.Location = new System.Drawing.Point(7, 20);
            this.lblNumeroContaTransferir.Name = "lblNumeroContaTransferir";
            this.lblNumeroContaTransferir.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroContaTransferir.TabIndex = 0;
            this.lblNumeroContaTransferir.Text = "Número da Conta";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 177);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnPedalar
            // 
            this.btnPedalar.Location = new System.Drawing.Point(409, 206);
            this.btnPedalar.Name = "btnPedalar";
            this.btnPedalar.Size = new System.Drawing.Size(75, 23);
            this.btnPedalar.TabIndex = 19;
            this.btnPedalar.Text = "Pedalar";
            this.btnPedalar.UseVisualStyleBackColor = true;
            this.btnPedalar.Click += new System.EventHandler(this.btnPedalar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(474, 239);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 20;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(406, 242);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 21;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(409, 276);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmUrbanBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 363);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.btnPedalar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gbTransferir);
            this.Controls.Add(this.gbCreditar);
            this.Controls.Add(this.gbAdicionar);
            this.Controls.Add(this.btnCreditar);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.dgvPedais);
            this.Controls.Add(this.btnRemoverPedal);
            this.Name = "frmUrbanBike";
            this.Text = "Urban Bike";
            this.Load += new System.EventHandler(this.cbbNumeroConta_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedais)).EndInit();
            this.gbAdicionar.ResumeLayout(false);
            this.gbAdicionar.PerformLayout();
            this.gbCreditar.ResumeLayout(false);
            this.gbCreditar.PerformLayout();
            this.gbTransferir.ResumeLayout(false);
            this.gbTransferir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoverPedal;
        public System.Windows.Forms.DataGridView dgvPedais;
        public System.Windows.Forms.CheckBox chbPremium;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNumeroConta;
        public System.Windows.Forms.TextBox txbNumeroConta;
        public System.Windows.Forms.DataGridViewTextBoxColumn NumeroConta;
        public System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        public System.Windows.Forms.DataGridViewTextBoxColumn Premium;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnCreditar;
        private System.Windows.Forms.GroupBox gbAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCreditar;
        private System.Windows.Forms.Button btnCreditarPedal;
        public System.Windows.Forms.TextBox txbValorCreditar;
        private System.Windows.Forms.Label lblValorCreditar;
        private System.Windows.Forms.Label lblNumeroContaCreditar;
        public System.Windows.Forms.TextBox txbNumeroContaCreditar;
        private System.Windows.Forms.GroupBox gbTransferir;
        private System.Windows.Forms.Label lblNumeroContaTransferir;
        private System.Windows.Forms.ComboBox cbbNumeroConta;
        private System.Windows.Forms.TextBox txbValorTransferencia;
        private System.Windows.Forms.Label lblValorTransferencia;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnTransferirPedal;
        private System.Windows.Forms.Button btnPedalar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

