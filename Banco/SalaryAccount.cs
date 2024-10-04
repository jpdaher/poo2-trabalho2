using System;
namespace Banco
{
    public class SalaryAccount : Account
    {
        public override void DebitAmount(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Saque realizado. Novo saldo: {Balance}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }

        public override void CreditAmount(float amount)
        {
            Balance += amount;
            Console.WriteLine($"Depósito realizado. Novo saldo: {Balance}");
        }

        public override void Transfer(Account targetAccount, float amount)
        {
            if (Balance >= amount)
            {
                base.Transfer(targetAccount, amount); // Transferência permitida
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para a transferência.");
            }
        }
    }

}