using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
	public class Cliente {
		public int id { get; private set; }
		public int id_pessoa { get; private set; }
		public DateTime inclusao { get; private set; }

		public Cliente(int id, int id_pessoa, DateTime inclusao) {
			if (id < 1 && id != -1) { throw new ArgumentException("ID não é maior que 1 nem é -1."); }
			if (id_pessoa < 1) { throw new ArgumentException("ID não pode ser menor que 1."); }
			if (inclusao > DateTime.Now ) { throw new ArgumentException("Data inválida."); }
			this.id = id;
			this.id_pessoa = id_pessoa;
			this.inclusao = inclusao;
		}

		public Cliente(int id_pessoa, DateTime inclusao) : this(-1, id_pessoa: 1, inclusao: DateTime.Now) { }
	}
}
