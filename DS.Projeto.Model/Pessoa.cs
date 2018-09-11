using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    public class Pessoa {
        public int id {
            get { return this.id; }
            private set {
                if(value < 1 && value != -1) { throw new ArgumentException("ID não é maior que 1 nem é -1."); }
                this.id = value;
            }
        }
		public string nome {
            get { return this.nome; }
			private set {
				if(value.Length > 64) { throw new ArgumentException("Nome muito longo."); }
				this.nome = value;
			}
		}
		public string endereco {
            get { return this.endereco; }
			private set {
				if(value.Length > 128) { throw new ArgumentException("Endereço muito longo."); }
				this.endereco = value;
			}
		}
		public string estadoCivil {
            get { return this.estadoCivil; }
			private set {
				if(value.Length > 11) { throw new ArgumentException("Estado civil muito longo."); }
				this.estadoCivil = value;
			}
		}
		public DateTime nasc { get; private set; }

        public string insertString {
            get { return String.Format("INSERT INTO tbPessoa(pessoa_nome, pessoa_endereco, pessoa_estadocivil, pessoa_nasc) VALUES ({0},{1},{2},{3})", this.nome, this.endereco, this.estadoCivil, this.nasc.ToShortDateString()); }
            private set { this.insertString = value; }
        }

		public Pessoa(int id, string nome, string endereco, string estadoCivil, DateTime nasc) {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.estadoCivil = estadoCivil;
            this.nasc = nasc;
		}

        public Pessoa(string nome, string endereco, string estadoCivil, DateTime nasc) : this(-1, nome, endereco, estadoCivil, nasc) { }
	}
}
