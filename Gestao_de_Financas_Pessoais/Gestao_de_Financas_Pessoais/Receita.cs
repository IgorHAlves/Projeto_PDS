using System.Globalization;

namespace Gestao_de_Financas_Pessoais
{
    internal class Receita
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string _valor
        {
            get { return this.Valor.ToString("C", CultureInfo.GetCultureInfo("pr-BR")); }
        }
        public string Data { get; set; }
        public Receita(string descricao, decimal valor, string data)
        {
            this.Descricao = descricao;
            this.Valor = valor;
            this.Data = data;
        }
    }
}
