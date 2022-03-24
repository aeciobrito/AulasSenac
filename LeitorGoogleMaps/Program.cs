using System;

namespace LeitorGoogleMaps
{
    internal class Program
    {
        /// <summary>
        /// Atividade: 
        /// 1 - Crie uma classe que represente o nome do lugar contido no endereço.
        /// 2 - Gere um novo objeto capaz de guardar esse endereço no código.
        /// 3 - Adicione esse objeto a uma lista de objetos da mesma classe
        /// 4 - Escreva toda a lista de endereços cadastrados sempre que o programa inicializar
        /// </summary>

        static string nomeLugar = string.Empty;
        static decimal posicaoX = 0m;
        static decimal posicaoY = 0m;
        const string caminhoLugar = "place/";

        static void Main()
        {
            CaputaEndereco();
        }

        static void CaputaEndereco()
        {
            Console.Clear();
            Console.WriteLine("Informe o link do endereço no Google Maps: ");
            var link = Console.ReadLine().Trim();
            Console.Clear();
            ValidadorDeEndereco(link);
        }

        static void ValidadorDeEndereco(string endereco)
        {
            if (string.IsNullOrEmpty(endereco))
                ExibeMensagemDeErro("Endereço não pode ser vazio!");
           // else if (!endereco.StartsWith("https://www.google.com/maps/") || !endereco.StartsWith("https://www.google.com.br/maps/"))
            else if (!endereco.Contains("www.google.com") && !endereco.Contains("maps"))
                ExibeMensagemDeErro("Não é um link do google maps válido.\nEndereço deve iniciar com https://www.google.com/maps/");

            SeparaDadosEndereco(endereco);
            SeparaDadosPosicao(endereco);

            Console.WriteLine("Deseja Cadastrar um novo endereço? (1) SIM (2) NÃO");
            if (Console.ReadLine() == "1")
                Main();
            else
                Environment.Exit(0);
        }

        static void ExibeMensagemDeErro(string mensagemDeErro)
        {
            Console.WriteLine(mensagemDeErro);
            Console.WriteLine("Pressione qualquer tecla para retornar.");
            Console.ReadKey();
            CaputaEndereco();
        }

        static void SeparaDadosEndereco(string endereco)
        {
            nomeLugar = endereco.Substring(endereco.IndexOf(caminhoLugar) + caminhoLugar.Length, endereco.IndexOf("/@") - (endereco.IndexOf(caminhoLugar) + caminhoLugar.Length));
            nomeLugar = nomeLugar.Replace('+', ' ');
            Console.WriteLine($"Nome do lugar: {nomeLugar}");
        }

        static void SeparaDadosPosicao(string endereco)
        {
            var coordenadas = endereco.Substring(endereco.IndexOf("@") + 1, (endereco.LastIndexOf(",") ) - (endereco.IndexOf("@") + 1));
            posicaoX = decimal.Parse(coordenadas.Split(',')[0]);
            posicaoY = decimal.Parse(coordenadas.Split(',')[1]);

            Console.WriteLine($"Posição X: {posicaoX}\nPosiçãoY: {posicaoY}");
        }
    }
}
