using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Lampada(new Ligada());

            c.Liga();
            c.Desliga();
            c.Desliga();
            c.Liga();
            c.Desliga();

            Console.Read();
        }
    }
}
