namespace Gestao_de_Financas_Pessoais
{
    internal class Receita
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Data { get; set; }
        public Receita(string descricao, decimal valor, string data)
        {
           this.Descricao = descricao; 
           this.Valor = valor; 
           this.Data = data;
        }
    }
}
