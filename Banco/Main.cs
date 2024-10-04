using System;
namespace Banco
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Criando o banco
            Bank banco = new Bank("Banco POO", 001);

            // Criando a filial
            Branch branch = new Branch("CC4M", 001, "Vila Velha");
            banco.AddBranch(branch);

            // Criando dois clientes
            Client joao = new Client("123456789", "João Pedro", "Rua Universidade", "99999-9999", "joao@email.com");
            Client wagner = new Client("987654321", "Wagner", "Rua Vila Velha", "99999-9998", "wagner@email.com");

            banco.AddClient(joao);
            banco.AddClient(wagner);

            // Criando uma CurrentAccount (Conta Corrente) para João e Wagner
            CurrentAccount correnteJoao = new CurrentAccount { AccNumber = 1 };
            CurrentAccount correnteWagner = new CurrentAccount { AccNumber = 2 };

            // Adicionando as contas aos clientes
            joao.AddAccount(correnteJoao);
            wagner.AddAccount(correnteWagner);

            // Adicionando as contas à filial
            branch.AddAccount(correnteJoao);
            branch.AddAccount(correnteWagner);

            // Depositando 10 milhões de reais na conta de João
            Console.WriteLine("\nDepositando 10 milhões de reais na conta de João");
            correnteJoao.CreditAmount(10000000);

            // Transferindo 1 milhão de reais de João para Wagner
            Console.WriteLine("\nTransferindo 1 milhão de reais de João para Wagner");
            correnteJoao.Transfer(correnteWagner, 1000000);

            // Resultado final
            Console.WriteLine($"\nResultado final: \nSaldo de João: R${correnteJoao.Balance}\nSaldo de Wagner: R${correnteWagner.Balance}\n");
        }
    }

}