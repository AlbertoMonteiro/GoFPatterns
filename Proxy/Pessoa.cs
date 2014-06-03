using System;

namespace Proxy
{
    class Pessoa : Sujeito
    {
        public override void Request()
        {
            Console.WriteLine("Chamado Pessoa.Request()");
        }
    }
}