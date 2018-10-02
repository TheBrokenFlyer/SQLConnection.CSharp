using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS.Projeto.Controller;
using DS.Projeto.Model;

namespace DS.Projeto.View {
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();
		}

		public static frmConsulta windowConsulta = null;

		private void cadastrar(object sender, EventArgs e) {
            try {

                Produto prdt = new Produto(
                    txtNome.Text,
                    txtDesc.Text,
                    (int)nmbQtd.Value,
                    nmbValor.Value,
                    dtpLote.Value,
                    dtpLote.Value);

			
				Connector.execute(prdt.insertString);
			} catch (Exception exp) {
				MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace, "Erro!");
			}
		}
	}
}
