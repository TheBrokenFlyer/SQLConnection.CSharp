namespace DS.Projeto.View {
	partial class frmConsulta {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dtg = new System.Windows.Forms.DataGridView();
			this.cmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnSelecionar = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExcluir = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
			this.cmenustrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtg
			// 
			this.dtg.AllowUserToAddRows = false;
			this.dtg.AllowUserToDeleteRows = false;
			this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg.Location = new System.Drawing.Point(13, 13);
			this.dtg.Name = "dtg";
			this.dtg.ReadOnly = true;
			this.dtg.Size = new System.Drawing.Size(530, 283);
			this.dtg.TabIndex = 0;
			this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selecionar);
			// 
			// cmenustrip
			// 
			this.cmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelecionar,
            this.btnExcluir});
			this.cmenustrip.Name = "cmenustrip";
			this.cmenustrip.Size = new System.Drawing.Size(129, 48);
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Size = new System.Drawing.Size(128, 22);
			this.btnSelecionar.Text = "Selecionar";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(128, 22);
			this.btnExcluir.Text = "Excluir";
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 308);
			this.Controls.Add(this.dtg);
			this.Name = "frmConsulta";
			this.Text = "frmConsulta";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fechar);
			((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
			this.cmenustrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtg;
		private System.Windows.Forms.ContextMenuStrip cmenustrip;
		private System.Windows.Forms.ToolStripMenuItem btnSelecionar;
		private System.Windows.Forms.ToolStripMenuItem btnExcluir;
	}
}