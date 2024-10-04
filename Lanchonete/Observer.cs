using System;
namespace Lanchonete
{
    public interface IObservador
    {
        void Atualizar(string mensagem);
    }

    public class MonitorProducao : IObservador
    {
        public void Atualizar(string mensagem)
        {
            System.Console.WriteLine("Produção: " + mensagem);
        }
    }

    public class MonitorMontagem : IObservador
    {
        public void Atualizar(string mensagem)
        {
            System.Console.WriteLine("Montagem: " + mensagem);
        }
    }
}

