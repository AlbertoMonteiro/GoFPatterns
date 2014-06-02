using System;

namespace Composite
{
    public class Arquivo : IComponent
    {
        public Arquivo()
        {
            Nome = "Arquivo";
        }
        public string Nome { get; private set; }
        public void Add(IComponent c)
        {
            throw new Exception("Arquivo não aceita adicionar");
        }

        public void Remove(IComponent c)
        {
            throw new Exception("Arquivo não aceita adicionar");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Nome);
        }
    }
}