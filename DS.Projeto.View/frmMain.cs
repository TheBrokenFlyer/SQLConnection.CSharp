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

		public static frmPesquisa windowPesquisa = null;
        public static frmConsulta windowConsulta = null;
        public List<Produto> transaction = new List<Produto>(0);

		public Produto prdt {
			private get {
				return new Produto( //cria um novo produto...
					txtNome.Text,		//nome
					txtDesc.Text,		//descrição
					(int)nmbQtd.Value,	//quantidade
					nmbValor.Value,		//valor
					dtpLote.Value,		//data lote
					dtpValidade.Value);		//data validade
			}
			set { throw new UnauthorizedAccessException("Não pode ser definido."); }
		}

        private void guardar(object sender, EventArgs e) {
            this.transaction.Add(this.prdt);
            this.limpar(sender, e);
        }

        private void enviar(object sender, EventArgs e) {
            string insert = "";
			try {
                try { insert += this.prdt.insertString; } catch { }
				//executa inserção com os dados do objeto
                foreach (Produto p in this.transaction) {
                    insert += p.insertString;
                }
                Connector.execute(insert);
                this.transaction.Clear();
			} catch (Exception exp) {
				MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace +"\n" +insert, "Erro!");
			}
		}

		private void limpar(object sender, EventArgs e) {
			txtNome.Text = txtDesc.Text = "";
			nmbQtd.Value = nmbValor.Value = 0;
			dtpLote.Value = dtpValidade.Value = DateTime.Today;
		}

		private void pesquisar(object sender, EventArgs e) {
			frmMain.windowPesquisa = new frmPesquisa(this);
			frmMain.windowPesquisa.Show();
		}
	}
}
