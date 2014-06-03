using System;

namespace AbatractFactory
{
    class ProdutoB2 : IProdutoB
    {
        public void Interact(IProdutoA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}