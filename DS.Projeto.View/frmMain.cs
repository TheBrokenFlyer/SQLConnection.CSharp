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
			bool estNull = (((string)cmbEstadoCivil.SelectedValue) == "");
			bool nscNull = dtpNasc.Value == null || dtpNasc.Value.Equals(DateTime.Now);
			try {
				DataTable searchResults = Connector.executeQuery(string.Format("SELECT * FROM tbPessoa WHERE (id_pessoa LIKE '%{0}%') OR (pessoa_nome LIKE '%{0}%') OR (pessoa_endereco LIKE '%{0}%') OR (pessoa_estadocivil = '{0}') {1}",txtNomePesquisa.Text,(!txtNomePesquisa.Text.Contains('-'))?"":"OR (pessoa_nasc = '" +txtNomePesquisa.Text +"')")).Tables[0];
				frmMain.windowConsulta = new frmConsulta(searchResults);
				frmMain.windowConsulta.Show();
			} catch (Exception exp) {
				MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace, "Erro!");
			} finally {
				Connector.close();
			}
		}
	}
}
