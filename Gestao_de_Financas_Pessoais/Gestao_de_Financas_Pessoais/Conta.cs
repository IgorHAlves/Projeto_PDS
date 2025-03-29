using System.Globalization;

namespace Gestao_de_Financas_Pessoais
{
    internal class Conta
    {
        public string Nome { get; set; }
        public decimal Saldo {
            get {
                decimal totalDespesa = this.Despesas.Sum(despesa => despesa.Valor);
                decimal totalReceitas = this.Receitas.Sum(receita => receita.Valor);
                return totalReceitas - totalDespesa;
            }
        }

        public string _saldo
        {
            get {return  Saldo.ToString("C", CultureInfo.GetCultureInfo("pt-BR")); }
        }
        public List<Despesa> Despesas { get; set; }
        public List<Receita> Receitas { get; set; } 
        public Conta(string nome)
        {
            this.Nome = nome;
            this.Despesas = new List<Despesa>();
            this.Receitas = new List<Receita>();
        }
    }
}
