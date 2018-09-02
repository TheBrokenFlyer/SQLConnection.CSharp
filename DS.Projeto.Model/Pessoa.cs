using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    public class Pessoa {
        public int id {
            public get;
            private set {
                if (value < 1) {
                    throw new ArgumentException("ID não pode ser menor que 1.");
                }
                this.id = value;
            }
        }
        public string nome {
            public get;
            private set {
                if (value.Length > 64) {
                    throw new ArgumentException("Nome muito longo.");
                }
            }
        }
        public string endereco {
            public get;
            private set {
                if (value.Length > 128) {
                    throw new ArgumentException(@"Endereço muito longo.");
                }
            }
        }
        public string estadoCivil {
            public get;
            private set {
                switch (value.ToCharArray()[0]) {
                    case '1':
                        this.estadoCivil = "solteiro(a)";
                        break;
                    case '2':
                        this.estadoCivil = "casado(a)";
                        break;
                    case '3':
                        this.estadoCivil = "outro";
                        break;
                    default:
                        throw new ArgumentException("ID de estado civil inválido.");
                }
            }
        }
    }
}
