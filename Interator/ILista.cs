namespace Interator
{
    public interface ILista<T>
    {
        IInterador<T> CreateIterator();
        T this[int i] { get; set; }
        int Count { get; }
    }
}