using System.Collections;

namespace Interator
{
    public class Interador<T> : IInterador<T>
    {
        private readonly ILista<T> itens;
        private int indice;

        public Interador(ILista<T> lista)
        {
            itens = lista;
            indice = 0;
        }

        public T Primeiro()
        {
            return Pronto() ? itens[0] : default(T);
        }

        public T Proximo()
        {
            return Pronto() ? itens[++indice] : default(T);
        }

        public bool Pronto()
        {
            return indice < itens.Count - 1;
        }

        public T ItemAtual()
        {
            return itens[indice];
        }
    }
}