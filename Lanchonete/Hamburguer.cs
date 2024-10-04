using System;
namespace Lanchonete
{
    public interface IHamburguer
    {
        string GetDescricao();
        double GetPreco();
    }

    public class HamburguerSimples : IHamburguer
    {

        // Descrição do hambúrguer simples
        public string GetDescricao()
        {
            return "Hambúrguer simples";
        }

        // Preço do hambúrguer simples
        public double GetPreco()
        {
            return 10.00;
        }
    }
}
