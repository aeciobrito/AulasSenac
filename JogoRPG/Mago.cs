namespace JogoRPG
{
    class Mago : Personagem
    {
        public Mago(string nome, int pontosDeVida, int forca, int defesa) 
            : base(nome, pontosDeVida, forca, defesa)
        {

        }

        public int PontosDeMagia { get; set; }

        public void ConjurarMagia()
        {
            
        }
    }
}
