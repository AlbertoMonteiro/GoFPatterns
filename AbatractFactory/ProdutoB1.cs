using System;

namespace AbatractFactory
{
    class ProdutoB1 : IProdutoB
    {
        public void Interact(IProdutoA a)
        {
            Console.WriteLine("ProdutoB1 interacts with " + a.GetType().Name);
        }
    }
}