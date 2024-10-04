using System;
namespace Banco
{
    public class Bank
    {
        public string Name { get; set; }
        public int Code { get; set; }

        private List<Branch> branches = new List<Branch>();

        private List<Client> clients = new List<Client>();

        public Bank(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }

        public void RemoveBranch(Branch branch)
        {
            branches.Remove(branch);
        }

        public List<Branch> GetBranches()
        {
            return branches;
        }

        public Branch GetBranch(int code)
        {
            return branches.FirstOrDefault(b => b.Code == code);
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void RemoveClient(Client client)
        {
            clients.Remove(client);
        }

        public Client GetClient(string cpf)
        {
            return clients.FirstOrDefault(c => c.CPF == cpf);
        }

        public List<Client> GetClients()
        {
            return clients;
        }
    }
}