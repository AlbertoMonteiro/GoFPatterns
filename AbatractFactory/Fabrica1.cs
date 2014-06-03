namespace AbatractFactory
{
    class Fabrica1 : IFabrica
    {
        public override IProdutoA CriaProdutoA()
        {
            return new ProdutoA1();
        }
        public override IProdutoB CriaProdutoB()
        {
            return new ProdutoB1();
        }
    }
}