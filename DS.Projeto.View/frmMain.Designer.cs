namespace DS.Projeto.View
{
	partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataLote = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.nmbQtd = new System.Windows.Forms.NumericUpDown();
            this.nmbValor = new System.Windows.Forms.NumericUpDown();
            this.lblVal = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.dtpLote = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Adicionar ou pesquisar produto...";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 86);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(12, 161);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 3;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 187);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(85, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor (Moeda-$):";
            // 
            // lblDataLote
            // 
            this.lblDataLote.AutoSize = true;
            this.lblDataLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLote.Location = new System.Drawing.Point(13, 211);
            this.lblDataLote.Name = "lblDataLote";
            this.lblDataLote.Size = new System.Drawing.Size(57, 13);
            this.lblDataLote.TabIndex = 5;
            this.lblDataLote.Text = "Data Lote:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(103, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(103, 83);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(227, 70);
            this.txtDesc.TabIndex = 7;
            // 
            // nmbQtd
            // 
            this.nmbQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbQtd.Location = new System.Drawing.Point(103, 159);
            this.nmbQtd.Name = "nmbQtd";
            this.nmbQtd.Size = new System.Drawing.Size(120, 20);
            this.nmbQtd.TabIndex = 8;
            this.nmbQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmbValor
            // 
            this.nmbValor.DecimalPlaces = 2;
            this.nmbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbValor.Location = new System.Drawing.Point(103, 185);
            this.nmbValor.Name = "nmbValor";
            this.nmbValor.Size = new System.Drawing.Size(120, 20);
            this.nmbValor.TabIndex = 9;
            this.nmbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.Location = new System.Drawing.Point(13, 237);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(77, 13);
            this.lblVal.TabIndex = 12;
            this.lblVal.Text = "Data Validade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(103, 263);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.cadastrar);
            // 
            // dtpValidade
            // 
            this.dtpValidade.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValidade.Location = new System.Drawing.Point(103, 237);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(227, 20);
            this.dtpValidade.TabIndex = 14;
            // 
            // dtpLote
            // 
            this.dtpLote.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLote.Location = new System.Drawing.Point(103, 211);
            this.dtpLote.Name = "dtpLote";
            this.dtpLote.Size = new System.Drawing.Size(227, 20);
            this.dtpLote.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 307);
            this.Controls.Add(this.dtpLote);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.nmbValor);
            this.Controls.Add(this.nmbQtd);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataLote);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmMain";
            this.Text = "Banco";
            ((System.ComponentModel.ISupportInitialize)(this.nmbQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDataLote;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.NumericUpDown nmbQtd;
        private System.Windows.Forms.NumericUpDown nmbValor;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.DateTimePicker dtpLote;


    }
}

