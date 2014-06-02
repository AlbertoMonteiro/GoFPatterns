namespace Composite
{
    public interface IComponent
    {
        string Nome { get; }
        void Add(IComponent c);
        void Remove(IComponent c);
        void Display(int depth);
    }
}