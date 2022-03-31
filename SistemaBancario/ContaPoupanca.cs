namespace SistemaBancario
{
    public class ContaPoupanca : Conta
    {
        public double TaxaSaque { get; set; } = 0.5;
        public ContaPoupanca(Cliente titular, Agencia agencia) : base(titular, agencia)
        {

        }

        public ContaPoupanca(Cliente titular, double saldo, Agencia agencia) : base(titular, saldo, agencia)
        {

        }

        public override bool Saca(double valorDoSaque)
        {
            Saldo -= TaxaSaque;
            return base.Saca(valorDoSaque);            
        }
    }
}
