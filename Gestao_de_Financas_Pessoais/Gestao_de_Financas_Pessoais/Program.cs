namespace Gestao_de_Financas_Pessoais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de finanças");

            List<Conta> contas = new List<Conta>();

            //criação da conta
            while (true)
            { 
                Console.WriteLine("Informe o nome da conta que deseja cadastrar:");
                string nomeConta = Console.ReadLine();


                Conta conta = new Conta(nomeConta);

                contas.Add(conta);

                Console.WriteLine("Conta criada com sucesso\n");

                Console.WriteLine("Deseja cadastrar mais contas? (S)/(N)");

                string continua = Console.ReadLine().ToLower();
                if (continua == "n")
                    break;
            }

            Console.WriteLine("----------------------------");

            //Adiciona transacoes
            while (true)
            {
                Console.WriteLine("Escolha uma transação!!\n1 - Despesa\n2 - Receita");
                int transacao = Convert.ToInt32(Console.ReadLine());

                //Verificar tipo de transação
                //Caso seja despesa
                if (transacao == 1)
                {
                    Console.WriteLine("Você escolheu despesa!");
                    Console.WriteLine("Escolha em qual conta você quer adicionar sua despesa: ");

                    //Listar contas cadastradas
                    foreach (Conta contaCadastrada in contas)
                    {
                        Console.WriteLine(contaCadastrada.Nome);
                    }
                    Console.WriteLine("----");

                    //Receber conta desejada
                    string contaDesejada = Console.ReadLine();

                    //Listar contas cadastradas
                    foreach (Conta contaCadastrada in contas)
                    {
                        if (contaCadastrada.Nome == contaDesejada)
                        {
                            Console.WriteLine("Escreva a descricao da sua despesa: ");
                            string descricaoDespesa = Console.ReadLine();

                            Console.WriteLine("Escreva o valor da sua despesa: ");
                            decimal valorDespesa = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Escreva a data da sua despesa: ");
                            string dataDespesa = Console.ReadLine();

                            Despesa despesa = new Despesa(descricaoDespesa, valorDespesa, dataDespesa);

                            if (contaCadastrada.Saldo > despesa.Valor)
                            {
                                contaCadastrada.Despesas.Add(despesa);
                            }
                            else
                                Console.WriteLine("Não foi possível cadastrar essa receita, saldo insuficiente");
                        }
                    }
                }
                else if (transacao == 2)
                {

                    Console.WriteLine("Você escolheu receita!");
                    Console.WriteLine("Escolha em qual conta você quer adicionar sua receita: ");

                    //Listar contas cadastradas
                    foreach (Conta contaCadastrada in contas)
                    {
                        Console.WriteLine(contaCadastrada.Nome);
                    }
                    Console.WriteLine("----");

                    //Receber conta desejada
                    string contaDesejada = Console.ReadLine();

                    //Listar contas cadastradas
                    foreach (Conta contaCadastrada in contas)
                    {
                        if (contaCadastrada.Nome == contaDesejada)
                        {
                            Console.WriteLine("Escreva a descricao da sua receita: ");
                            string descricaoReceita = Console.ReadLine();

                            Console.WriteLine("Escreva o valor da sua receita: ");
                            decimal valorReceita = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Escreva a data da sua receita: ");
                            string dataReceita = Console.ReadLine();

                            Receita receita = new Receita(descricaoReceita, valorReceita, dataReceita);

                            contaCadastrada.Receitas.Add(receita);
                        }
                    }

                }

                Console.WriteLine("Deseja fazer mais transações?(S)/(N)");
                string continua = Console.ReadLine().ToLower();
                if(continua == "n")
                    break;
            }

            Console.WriteLine("----------------------------");
            foreach (Conta contaCadastrada in contas)
            {
                Console.WriteLine("Conta:");
                Console.WriteLine($"{contaCadastrada.Nome}");
                Console.WriteLine("Saldo:");
                Console.WriteLine(contaCadastrada._saldo);
                Console.WriteLine("Despesas:");
                foreach (Despesa despesa in contaCadastrada.Despesas)
                {
                    Console.WriteLine("Descrição");
                    Console.WriteLine(despesa.Descricao);
                    Console.WriteLine("Valor");
                    Console.WriteLine(despesa.Valor);
                }

                Console.WriteLine("Receitas:");
                foreach (Receita receita in contaCadastrada.Receitas)
                {
                    Console.WriteLine("Descrição");
                    Console.WriteLine(receita.Descricao);
                    Console.WriteLine("Valor");
                    Console.WriteLine(receita.Valor);
                }


            }

        }
    }
}