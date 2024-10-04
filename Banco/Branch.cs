using System;
namespace Banco
{
    public class Branch
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string City { get; set; }

        private List<Account> accounts = new List<Account>();

        public Branch(string name, int code, string city)
        {
            Name = name;
            Code = code;
            City = city;
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            if (accounts.Remove(account))
            {
                Console.WriteLine($"Conta {account.AccNumber} removida da filial {Name}.");
            }
            else
            {
                Console.WriteLine($"Conta {account.AccNumber} não encontrada na filial {Name}.");
            }
        }

        public Account GetAccount(int accNumber)
        {
            return accounts.FirstOrDefault(a => a.AccNumber == accNumber);
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }
    }
}