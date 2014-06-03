namespace FactoryMethod
{
    class CriadorB : Criador
    {
        public override IProduto FactoryMethod()
        {
            return new ProdutoB();
        }
    }
}