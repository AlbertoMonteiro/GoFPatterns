namespace AbatractFactory
{
    class Fabrica2 : IFabrica
    {
        public override IProdutoA CriaProdutoA()
        {
            return new ProductA2();
        }
        public override IProdutoB CriaProdutoB()
        {
            return new ProdutoB2();
        }
    }
}