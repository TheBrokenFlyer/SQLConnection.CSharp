using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    public class Pessoa {
        public int id {
            public get;
            private set {
                if(value < 1 && value != -1) { throw new ArgumentException("ID não é maior que 1 nem é -1."); }
                this.id = value;
            }
        }
		public string nome {
			public get;
			private set {
				if(value.Length > 64) { throw new ArgumentException("Nome muito longo."); }
				this.nome = value;
			}
		}
		public string endereco {
			public get;
			private set {
				if(value.Length > 128) { throw new ArgumentException("Endereço muito longo."); }
				this.endereco = value;
			}
		}
		public string estadoCivil {
			public get;
			private set {
				if(value.Length > 11) { throw new ArgumentException("Estado civil muito longo."); }
				this.estadoCivil = value;
			}
		}
		public DateTime nasc { public get; private set; }

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
