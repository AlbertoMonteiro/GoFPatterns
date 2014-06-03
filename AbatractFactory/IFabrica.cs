namespace AbatractFactory
{
    interface IFabrica
    {
        IProdutoA CriaProdutoA();
        IProdutoB CriaProdutoB();
    }
}