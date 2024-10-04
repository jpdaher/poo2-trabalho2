using System;
namespace Banco
{
    public class CurrentAccount : Account
    {
        public override void DebitAmount(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public override void CreditAmount(float amount)
        {
            Balance += amount;
        }

        public void Pix(string key, float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Pix de R${amount} enviado para a chave {key}. Novo saldo: {Balance}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o Pix.");
            }
        }
    }

}