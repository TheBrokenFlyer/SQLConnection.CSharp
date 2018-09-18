using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    public class Pessoa {
        public int id = -1;
        public string nome = null;
        public string endereco = null;
        public string estadoCivil = null;
		public DateTime nasc { get; private set; }

        public string insertString {
            get { return String.Format("INSERT INTO tbPessoa(pessoa_nome, pessoa_endereco, pessoa_estadocivil, pessoa_nasc) VALUES ('{0}','{1}','{2}','{3}')", this.nome, this.endereco, this.estadoCivil, this.nasc.ToShortDateString()); }
            private set { this.insertString = value; }
        }

		public Pessoa(int id, string nome, string endereco, string estadoCivil, DateTime nasc) {
            if (id < 1 && id != -1) { throw new ArgumentException("ID não é maior que 1 nem é -1."); }
            if (nome.Length > 64) { throw new ArgumentException("Nome muito longo."); }
            if (endereco.Length > 128) { throw new ArgumentException("Endereço muito longo."); }
            if (estadoCivil.Length > 11) { throw new ArgumentException("Estado civil muito longo."); }
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.estadoCivil = estadoCivil;
            this.nasc = nasc;
		}

        public Pessoa(string nome, string endereco, string estadoCivil, DateTime nasc) : this(-1, nome, endereco, estadoCivil, nasc) { }
	}
}
