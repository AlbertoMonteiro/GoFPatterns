using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbatractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica factory1 = new Fabrica1();
            var c1 = new Cliente(factory1.CriaProdutoA(), factory1.CriaProdutoB());
            c1.Run();

            // Wait for user input 
            Console.Read();
        }
    } 
}
