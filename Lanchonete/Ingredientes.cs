using System;
namespace Lanchonete
{
    public abstract class IngredienteDecorator : IHamburguer
    {
        protected IHamburguer _hamburguer;

        public IngredienteDecorator(IHamburguer hamburguer)
        {
            _hamburguer = hamburguer;
        }

        public abstract string GetDescricao();
        public abstract double GetPreco();
    }

    public class Bacon : IngredienteDecorator
    {
        public Bacon(IHamburguer hamburguer) : base(hamburguer)
        {
        }

        public override string GetDescricao()
        {
            return _hamburguer.GetDescricao() + ", Bacon";
        }

        public override double GetPreco()
        {
            return _hamburguer.GetPreco() + 2.00;
        }
    }

    public class Queijo : IngredienteDecorator
    {
        public Queijo(IHamburguer hamburguer) : base(hamburguer)
        {
        }

        public override string GetDescricao()
        {
            return _hamburguer.GetDescricao() + ", Queijo";
        }

        public override double GetPreco()
        {
            return _hamburguer.GetPreco() + 2.00;
        }
    }

    public class Ovo : IngredienteDecorator
    {
        public Ovo(IHamburguer hamburguer) : base(hamburguer)
        {
        }

        public override string GetDescricao()
        {
            return _hamburguer.GetDescricao() + ", Ovo";
        }

        public override double GetPreco()
        {
            return _hamburguer.GetPreco() + 2.00;
        }
    }

    public class Alface : IngredienteDecorator
    {
        public Alface(IHamburguer hamburguer) : base(hamburguer)
        {
        }

        public override string GetDescricao()
        {
            return _hamburguer.GetDescricao() + ", Alface";
        }

        public override double GetPreco()
        {
            return _hamburguer.GetPreco() + 2.00;
        }
    }

    public class Tomate : IngredienteDecorator
    {
        public Tomate(IHamburguer hamburguer) : base(hamburguer)
        {
        }

        public override string GetDescricao()
        {
            return _hamburguer.GetDescricao() + ", Tomate";
        }

        public override double GetPreco()
        {
            return _hamburguer.GetPreco() + 2.00;
        }
    }
}
