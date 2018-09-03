using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    class PessoaDocumento : Entidade{
        public int id {
            public get;
            private set {
                if(value < 1 && value != -1) { throw new ArgumentException("ID não é maior que 1 nem é -1."); }
                this.id = value;
            }
        }
        public int id_pessoa {
            public get;
            private set {
                if(value < 1) { throw new ArgumentException("ID não pode ser menor que 1."); }
            }
        }
        public string rg, cpf, reservista, carteiraDeTrabalho, cnh;
    }
}
