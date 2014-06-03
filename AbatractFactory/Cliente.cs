namespace AbatractFactory
{
    class Cliente
    {
        private IProdutoA _produtoA;
        private IProdutoB _produtoB;

        public Cliente(IProdutoA produtoA, IProdutoB produtoB)
        {
            _produtoA = produtoA;
            _produtoB = produtoB;
        }

        public void Run()
        {
            _produtoB.Interact(_produtoA);
        }
    }
}