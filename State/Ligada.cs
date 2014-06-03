using System;

namespace State
{
    class Ligada : IEstado
    {
        public void Handle(Lampada lampada)
        {
            lampada.Estado = new Desligada();
        }
    }
}