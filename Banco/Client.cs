using System;
namespace Banco
{
    public class Client
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        private List<Account> accounts = new List<Account>();

        public Client(string cpf, string name, string address, string phone, string email)
        {
            CPF = cpf;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
            account.Client = this;
        }

        public void RemoveAccount(Account account)
        {
            accounts.Remove(account);
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }
    }
}