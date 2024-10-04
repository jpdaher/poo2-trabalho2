using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            IHamburguer hamburguer = new HamburguerSimples(); // Inicia com um hambúrguer simples

            Console.WriteLine("Bem-vindo à Lanchonete! Vamos montar seu hambúrguer personalizado.");
            Console.WriteLine($"Hambúrguer base: {hamburguer.GetDescricao()} - R$ {hamburguer.GetPreco():0.00}");

            // Menu para escolha de ingredientes
            hamburguer = PerguntarIngrediente(hamburguer, "Bacon", new Bacon(hamburguer));
            hamburguer = PerguntarIngrediente(hamburguer, "Queijo", new Queijo(hamburguer));
            hamburguer = PerguntarIngrediente(hamburguer, "Ovo", new Ovo(hamburguer));
            hamburguer = PerguntarIngrediente(hamburguer, "Alface", new Alface(hamburguer));
            hamburguer = PerguntarIngrediente(hamburguer, "Tomate", new Tomate(hamburguer));

            Console.WriteLine($"\n\nSeu pedido final: {hamburguer.GetDescricao()}");
            Console.WriteLine($"Preço total: R$ {hamburguer.GetPreco():0.00}\n\n");
        }

        static IHamburguer PerguntarIngrediente(IHamburguer hamburguer, string ingredienteNome, IHamburguer ingredienteDecorator)
        {
            Console.WriteLine($"\nDeseja adicionar {ingredienteNome}? (S/N)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                return ingredienteDecorator; // Adiciona o ingrediente
            }
            else
            {
                return hamburguer; // Não adiciona o ingrediente
            }
        }
    }
}
