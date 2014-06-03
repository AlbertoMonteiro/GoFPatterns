using System;
using System.Collections;

namespace Interator
{
    public class Lista<T> : ILista<T>
    {
        private ArrayList items = new ArrayList();

        public IInterador<T> CreateIterator()
        {
            return new Interador<T>(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public T this[int index]
        {
            get { return (T) items[index]; }
            set { items.Insert(index, value); }
        }

    }
}