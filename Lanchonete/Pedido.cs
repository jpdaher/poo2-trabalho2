using System;
using System.Collections.Generic;
namespace Lanchonete
{
    public class Pedido
    {
        private List<IObservador> _observadores = new List<IObservador>();
        private IHamburguer _hamburguer;

        public void AdicionarObservador(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void RemoverObservador(IObservador observador)
        {
            _observadores.Remove(observador);
        }

        public void NotificarObservadores(string mensagem)
        {
            foreach (var observador in _observadores)
            {
                observador.Atualizar(mensagem);
            }
        }

        public void CriarPedido(IHamburguer hamburguer)
        {
            _hamburguer = hamburguer;
            NotificarObservadores("Novo pedido: " + _hamburguer.GetDescricao());
        }

        public IHamburguer GetHamburguer()
        {
            return _hamburguer;
        }
    }
}

