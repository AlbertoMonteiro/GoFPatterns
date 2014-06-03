using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var criadores = new Criador[2];
            criadores[0] = new CriadorA();
            criadores[1] = new CriadorB();

            foreach (var criador in criadores)
            {
                var produto = criador.FactoryMethod();
                Console.WriteLine("Criado {0}", produto.GetType().Name);
            }

            Console.Read();
        }
    }
}