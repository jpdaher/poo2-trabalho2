using System;
namespace Banco
{
    public class SavingsAccount : Account
    {
        public float Rate { get; set; }
        private int monthlyWithdrawals = 0;

        public override void DebitAmount(float amount)
        {
            if (monthlyWithdrawals >= 3)
            {
                amount += 1.00f;
                Console.WriteLine("Taxa de R$1,00 aplicada por exceder 3 saques no mês.");
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                monthlyWithdrawals++;
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

        public void Render()
        {
            float rendimento = Balance * Rate;
            Balance += rendimento;
            Console.WriteLine($"Conta rendeu R${rendimento}. Novo saldo: {Balance}");
        }

        public override void Transfer(Account targetAccount, float amount)
        {
            if (targetAccount is CurrentAccount && targetAccount.Client == this.Client)
            {
                base.Transfer(targetAccount, amount);
            }
            else
            {
                Console.WriteLine("Só é permitido transferir para uma conta corrente do mesmo cliente.");
            }
        }
    }

}