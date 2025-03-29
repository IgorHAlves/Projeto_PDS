namespace Gestao_de_Financas_Pessoais
{
    internal class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Data { get; set; }
        public Despesa(string descricao, decimal valor, string data)
        {
            this.Descricao = descricao;
            this.Valor = valor;
            this.Data = data;
        }
    }
}
