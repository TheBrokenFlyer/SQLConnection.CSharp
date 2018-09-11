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
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();
		}

        private void cadastrar(object sender, EventArgs e) {
            Connector.execute("INSERT INTO tbPessoa(pessoa_nome, pessoa_endereco, pessoa_estadocivil, pessoa_nasc) VALUES ");
        }
	}
}
