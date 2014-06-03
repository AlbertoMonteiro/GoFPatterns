namespace Proxy
{
    class Proxy : Sujeito
    {
        Pessoa _pessoa;

        public override void Request()
        {
            // Use 'lazy initialization' 
            if (_pessoa == null)
            {
                _pessoa = new Pessoa();
            }

            _pessoa.Request();
        }
    }
}