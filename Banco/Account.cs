using System;
namespace Banco
{
    public abstract class Account
    {
        public int AccNumber { get; set; }
        public float Balance { get; protected set; }
        public DateTime OpeningDate { get; set; }
        public Client Client { get; set; }

        public abstract void DebitAmount(float amount);
        public abstract void CreditAmount(float amount);

        public virtual float GetBalance()
        {
            return Balance;
        }

        public virtual void Transfer(Account targetAccount, float amount)
        {
            if (Balance >= amount)
            {
                this.DebitAmount(amount);
                targetAccount.CreditAmount(amount);
                Console.WriteLine($"Transferência de R$ {amount} realizada para {targetAccount.Client.Name} com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para a transferência.");
            }
        }
    }

}