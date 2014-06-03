using System;

namespace State
{
    class Lampada
    {
        private IEstado _estado;

        public Lampada(IEstado estado)
        {
            Estado = estado;
        }

        public IEstado Estado
        {
            get { return _estado; }
            set
            {
                if (value != _estado)
                {
                    _estado = value;
                    Console.WriteLine("A lampada foi " + _estado.GetType().Name);
                }
            }
        }

        public void Liga()
        {
            Console.WriteLine("Liga a lampada");
            if (_estado is Ligada)
                Console.WriteLine("Lampada já está ligada");
            else
                _estado.Handle(this);
        }
        public void Desliga()
        {
            Console.WriteLine("Desliga a lampada");
            if (_estado is Desligada)
                Console.WriteLine("Lampada já está desligada");
            else
                _estado.Handle(this);
        }
    }
}