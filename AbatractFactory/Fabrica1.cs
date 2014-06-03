namespace AbatractFactory
{
    class Fabrica1 : IFabrica
    {
        public IProdutoA CriaProdutoA()
        {
            return new ProdutoA1();
        }
        public IProdutoB CriaProdutoB()
        {
            return new ProdutoB1();
        }
    }
}