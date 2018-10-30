using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS.Projeto.Controller;

namespace DS.Projeto.View {
	public partial class frmPesquisa : Form {
		public frmPesquisa(frmMain parent) {
			InitializeComponent();
            this.parent = parent;
		}

        private frmMain parent;

		/// <summary>
		/// SQL Injection
		/// </summary>
		private void pesquisar(object sender, EventArgs e) {
            if (txtPesquisa.Text.ToUpper().Equals(">GUARDADOS")) {
                frmMain.windowConsulta = new frmConsulta(this.parent.transaction);
                return;
            }
			frmMain.windowConsulta = new frmConsulta(
				Connector.executeQuery("SELECT FROM tbProduto WHERE (produtoNome = '%" +txtPesquisa.Text +"%')")
				);
		}
	}
}
