using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    public class Funcionario {
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
        public string cargo { public get; private set; }
        public decimal salario { public get; private set; }
        public int ramal { public get; private set; }

        public Funcionario(int id, int id_pessoa, string cargo, decimal salario, int ramal) {
            this.id = id;
            this.id_pessoa = id_pessoa;
            this.cargo = cargo;
            this.salario = salario;
            this.ramal = ramal;
        }

        public Funcionario(int id_pessoa, string cargo, decimal salario, int ramal) : this(-1, id_pessoa, cargo, salario, ramal) { }
    }
}
