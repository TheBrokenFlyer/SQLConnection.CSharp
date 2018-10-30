using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Projeto.Model {
    public class Produto {
        public int id { get; private set; }
        public string nome { get; private set; }
        public string desc { get; private set; }
        public int qtd { get; private set; }
        public decimal valor { get; private set; }
        public DateTime dataLote { get; private set; }
        public DateTime dataValidade { get; private set; }

        public string insertString {
            get {
                return string.Format(
                    "INSERT INTO tbProduto(produtoNome, produtoDesc, produtoQtd, produtoValor{0}, produtoDataValidade) VALUES ('{1}', '{2}', {3}, {4}{5}{6});",
                    dataLote.Equals(null)?"":", produtoDataLote",
                    this.nome,
                    this.desc,
                    this.qtd,
                    this.valor,
                    this.dataLote==null?"":string.Format(", '{0}-{1}-{2}'",this.dataLote.Year,this.dataLote.Month,this.dataLote.Day), //dataLote
                    string.Format(", '{0}-{1}-{2}'",this.dataValidade.Year,this.dataValidade.Month,this.dataValidade.Day) //dataValidade
                    );
            }
        }

        public Produto(string nome, string desc, int qtd, decimal valor, DateTime dataValidade) {
            if (qtd < 0) { throw new ArgumentException("Quantidade não pode ser menor que 0."); }
            if (valor < 0) { throw new ArgumentException("Valor não pode ser menor que 0."); }
            if (dataValidade < DateTime.Now) { throw new ArgumentException("Produto vencido."); }
            this.nome = nome;
            this.desc = desc;
            this.qtd = qtd;
            this.valor = valor;
            this.dataLote = dataLote;
            this.dataValidade = dataValidade;
        }


        public Produto(string nome, string desc, int qtd, decimal valor, DateTime dataLote, DateTime dataValidade) : this(nome, desc, qtd, valor, dataValidade) {
            this.dataLote = dataLote;
        }
    }
}
