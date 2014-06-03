namespace Interator
{
    public interface IInterador<T>
    {
        T Primeiro();
        T Proximo();
        bool Pronto();
        T ItemAtual();
    }
}