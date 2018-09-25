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
		this.lblNome = new System.Windows.Forms.Label();
		this.lblEndereco = new System.Windows.Forms.Label();
		this.lblEstadoCivil = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.txtNome = new System.Windows.Forms.TextBox();
		this.txtEndereco = new System.Windows.Forms.TextBox();
		this.dtpNasc = new System.Windows.Forms.DateTimePicker();
		this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCadastrar = new System.Windows.Forms.Button();
		this.btnPesquisar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		// 
		// lblNome
		// 
		this.lblNome.AutoSize = true;
		this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.lblNome.Location = new System.Drawing.Point(23, 68);
		this.lblNome.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
		this.lblNome.Name = "lblNome";
		this.lblNome.Size = new System.Drawing.Size(55, 20);
		this.lblNome.TabIndex = 1;
		this.lblNome.Text = "Nome:";
		// 
		// lblEndereco
		// 
		this.lblEndereco.AutoSize = true;
		this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.lblEndereco.Location = new System.Drawing.Point(23, 106);
		this.lblEndereco.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
		this.lblEndereco.Name = "lblEndereco";
		this.lblEndereco.Size = new System.Drawing.Size(82, 20);
		this.lblEndereco.TabIndex = 2;
		this.lblEndereco.Text = "Endereço:";
		// 
		// lblEstadoCivil
		// 
		this.lblEstadoCivil.AutoSize = true;
		this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.lblEstadoCivil.Location = new System.Drawing.Point(23, 144);
		this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
		this.lblEstadoCivil.Name = "lblEstadoCivil";
		this.lblEstadoCivil.Size = new System.Drawing.Size(92, 20);
		this.lblEstadoCivil.TabIndex = 3;
		this.lblEstadoCivil.Text = "Estado civil:";
		// 
		// label5
		// 
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.label5.Location = new System.Drawing.Point(23, 186);
		this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(156, 20);
		this.label5.TabIndex = 4;
		this.label5.Text = "Data de nascimento:";
		// 
		// txtNome
		// 
		this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.txtNome.Location = new System.Drawing.Point(193, 65);
		this.txtNome.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.txtNome.Name = "txtNome";
		this.txtNome.Size = new System.Drawing.Size(396, 26);
		this.txtNome.TabIndex = 5;
		// 
		// txtEndereco
		// 
		this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.txtEndereco.Location = new System.Drawing.Point(193, 103);
		this.txtEndereco.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.txtEndereco.Name = "txtEndereco";
		this.txtEndereco.Size = new System.Drawing.Size(396, 26);
		this.txtEndereco.TabIndex = 6;
		// 
		// dtpNasc
		// 
		this.dtpNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.dtpNasc.Location = new System.Drawing.Point(193, 181);
		this.dtpNasc.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.dtpNasc.Name = "dtpNasc";
		this.dtpNasc.Size = new System.Drawing.Size(396, 26);
		this.dtpNasc.TabIndex = 8;
		// 
		// cmbEstadoCivil
		// 
		this.cmbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
		this.cmbEstadoCivil.FormattingEnabled = true;
		this.cmbEstadoCivil.Items.AddRange(new object[] {
		"solteiro(a)",
		"casado(a)",
		"outro"});
		this.cmbEstadoCivil.Location = new System.Drawing.Point(193, 141);
		this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.cmbEstadoCivil.Name = "cmbEstadoCivil";
		this.cmbEstadoCivil.Size = new System.Drawing.Size(239, 28);
		this.cmbEstadoCivil.TabIndex = 9;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(224, 9);
		this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(196, 24);
		this.label1.TabIndex = 10;
		this.label1.Text = "Cadastro de Pessoa";
		// 
		// btnCadastrar
		// 
		this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
		this.btnCadastrar.Location = new System.Drawing.Point(223, 230);
		this.btnCadastrar.Name = "btnCadastrar";
		this.btnCadastrar.Size = new System.Drawing.Size(109, 29);
		this.btnCadastrar.TabIndex = 11;
		this.btnCadastrar.Text = "Cadastrar";
		this.btnCadastrar.UseVisualStyleBackColor = true;
		this.btnCadastrar.Click += new System.EventHandler(this.cadastrar);
		// 
		// btnPesquisar
		// 
		this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
		this.btnPesquisar.Location = new System.Drawing.Point(338, 230);
		this.btnPesquisar.Name = "btnPesquisar";
		this.btnPesquisar.Size = new System.Drawing.Size(109, 29);
		this.btnPesquisar.TabIndex = 12;
		this.btnPesquisar.Text = "Pesquisar";
		this.btnPesquisar.UseVisualStyleBackColor = true;
		this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
		// 
		// frmMain
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(671, 278);
		this.Controls.Add(this.btnPesquisar);
		this.Controls.Add(this.btnCadastrar);
		this.Controls.Add(this.label1);
		this.Controls.Add(this.cmbEstadoCivil);
		this.Controls.Add(this.dtpNasc);
		this.Controls.Add(this.txtEndereco);
		this.Controls.Add(this.txtNome);
		this.Controls.Add(this.label5);
		this.Controls.Add(this.lblEstadoCivil);
		this.Controls.Add(this.lblEndereco);
		this.Controls.Add(this.lblNome);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Name = "frmMain";
		this.Text = "Banco";
		this.ResumeLayout(false);
		this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEndereco;
		private System.Windows.Forms.Label lblEstadoCivil;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.DateTimePicker dtpNasc;
		private System.Windows.Forms.ComboBox cmbEstadoCivil;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnPesquisar;

	}
}

