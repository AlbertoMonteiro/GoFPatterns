using System;
using System.Collections.Generic;

namespace Composite
{
    public class Pasta : IComponent
    {
        private IList<IComponent> itens;

        public Pasta()
        {
            Nome = "Pasta";
            itens = new List<IComponent>();
        }

        public string Nome { get; private set; }

        public void Add(IComponent c)
        {
            itens.Add(c);
        }

        public void Remove(IComponent c)
        {
            itens.Remove(c);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Nome);

            // Recursively display child nodes 
            foreach (IComponent component in itens)
            {
                component.Display(depth + 2);
            }

        }
    }
}