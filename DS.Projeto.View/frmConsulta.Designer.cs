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
		this.dtg = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
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
		// frmConsulta
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(555, 308);
		this.Controls.Add(this.dtg);
		this.Name = "frmConsulta";
		this.Text = "frmConsulta";
		((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
		this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtg;
	}
}