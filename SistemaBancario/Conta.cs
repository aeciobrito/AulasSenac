namespace SistemaBancario
{
    public abstract class Conta
    {
        private static int _contador = 0;

        protected Conta(Cliente titular, Agencia agencia)
        {
            Titular = titular;
            Agencia = agencia;
            _contador++;
            Numero = _contador;
        }

        protected Conta(Cliente titular, double saldo, Agencia agencia) : this(titular, agencia)
        {
            Saldo = saldo;
        }

        public int Numero { get; protected set; }
        public Cliente Titular { get; protected set; }
        public Agencia Agencia { get; protected set; }
        public double Saldo { get; protected set; }

        public virtual bool Saca(double valorDoSaque)
        {
            if(Saldo >= valorDoSaque)
            {
                Saldo -= valorDoSaque;
                return true;
            }

            return false;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public bool Transfere(double valor, Conta destino)
        {
            if (Saca(valor))
            {
                destino.Deposita(valor);
                return true;
            }

            return false;
        }
    }
}
