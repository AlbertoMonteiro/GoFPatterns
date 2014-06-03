using System;

namespace State
{
    class Desligada : IEstado
    {
        public void Handle(Lampada lampada)
        {
            lampada.Estado = new Ligada();
        }
    }
}