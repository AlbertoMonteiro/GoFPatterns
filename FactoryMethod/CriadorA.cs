namespace FactoryMethod
{
    class CriadorA : Criador
    {
        public override IProduto FactoryMethod()
        {
            return new ProdutoA();
        }
    }
}