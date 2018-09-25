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
			Pessoa ppl = new Pessoa(txtNome.Text, txtEndereco.Text, cmbEstadoCivil.Text, dtpNasc.Value);
			try {
				Connector.execute(ppl.insertString);
			} catch (Exception exp) {
				MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace, "Erro!");
			}
		}

		private void btnPesquisar_Click(object sender, EventArgs e) {
			bool nomeNull = txtNome.Text == "";
			bool endNull = txtEndereco.Text == "";
			bool estNull = cmbEstadoCivil.SelectedValue == "";
			bool nscNull = dtpNasc.Value == null;
			try {
				frmMain.windowConsulta = new frmConsulta(Connector.executeQuery(string.Format(
				   "SELECT * FROM tbPessoa WHERE {0} {1} {2} {3}",
				   nomeNull ? "" : "(pessoa_nome LIKE '%" + txtNome.Text + "%')",
				   endNull ? "" : (nomeNull ? "" : " AND ") + "(pessoa_endereco LIKE '%" + txtEndereco.Text + "%')",
				   estNull ? "" : (nomeNull && endNull ? "" : " AND ") + "(pessoa_estadocivil = '" + (string)cmbEstadoCivil.SelectedValue + "')",
				   nscNull ? "" : (nomeNull && endNull && estNull ? "" : " AND ") + "(pessoa_nasc = '" + dtpNasc.Value.ToString("yyyy-MM-dd") + "')"
				   )).Tables[0]);
				frmMain.windowConsulta.Show();
			} catch (Exception exp) {
				MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace, "Erro!");
			} finally {
				Connector.close();
			}
		}
	}
}
