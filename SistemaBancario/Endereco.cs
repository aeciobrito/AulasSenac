namespace SistemaBancario
{
    public class Endereco
    {
        public Endereco(string cidade, string estado)
        {
            Cidade = cidade;
            Estado = estado;
        }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
