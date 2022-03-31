namespace SistemaBancario
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, Cliente titular) : base(titular)
        {

        }

        public ContaCorrente(int numero, Cliente titular, double saldo) : base(titular, saldo)
        {

        }
    }
}
