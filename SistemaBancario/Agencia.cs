namespace SistemaBancario
{
    public class Agencia
    {
        private static int _contador = 0;
        public Agencia(Endereco endereco)
        {
            _contador++;
            Codigo = _contador;
            Endereco = endereco;
        }

        public int Codigo { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
