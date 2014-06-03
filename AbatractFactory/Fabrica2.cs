namespace AbatractFactory
{
    class Fabrica2 : IFabrica
    {
        public IProdutoA CriaProdutoA()
        {
            return new ProductA2();
        }
        public IProdutoB CriaProdutoB()
        {
            return new ProdutoB2();
        }
    }
}