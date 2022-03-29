namespace JogoRPG
{
    class Mago : Personagem
    {
        public Mago(string nome, int pontosDeVida, int forca, int defesa, bool estaVivo) 
            : base(nome, pontosDeVida, forca, defesa, estaVivo)
        {

        }

        public int PontosDeMagia { get; set; }

        public void ConjurarMagia()
        {
            
        }
    }
}
