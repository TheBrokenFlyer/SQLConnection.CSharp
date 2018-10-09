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
		public frmPesquisa() {
			InitializeComponent();
		}

		/// <summary>
		/// SQL Injection was never so easy, i think.
		/// </summary>
		private void pesquisar(object sender, EventArgs e) {
			frmMain.windowConsulta = new frmConsulta(
				Connector.executeQuery("SELECT FROM tbProduto WHERE (produtoNome = '%" +txtPesquisa.Text +"%')")
				);
		}
	}
}
