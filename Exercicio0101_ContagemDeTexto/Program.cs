using System;
using System.Linq;

/// <summary>
/// Com base no texto inserido na variável texto do método Main(),
/// implemente os métodos que possam contar o total de letras, números e espaços
/// existentes nesse texto.
/// ---------------------------------------------------------------------------
/// Em uma segunda etapa, imprima na tela o texto, substituindo os números por letras equivalentes, sendo:
/// 3 = E
/// 5 = S
/// 0 = O
/// 4 = A
/// 1 = I
/// </summary>
namespace Exercicio0101_ContagemDeTexto
{
    public class Program
    {
        static void Main(string[] args)
        {
            string texto = "35T3 P3QU3N0 T3XTO 53RV3 4P3N45 P4R4 M05TR4R COMO NO554 C4B3Ç4 CONS3GU3 F4Z3R CO1545 1MPR3551ON4ANT35! R3P4R3 N155O!NO COM3ÇO 35T4V4 M310 COMPL1C4DO, M45 N3ST4 L1NH4 SU4 M3NT3 V41 D3C1FR4NDO O CÓD1GO QU453 4UTOM4T1C4M3NT3, S3M PR3C1S4R P3N54R MU1TO, C3RTO? POD3 F1C4R B3M ORGULHO5O D155O! SU4 C4P4C1D4D3 M3R3C3! P4R4BÉN5!";

            Console.WriteLine(ContadorDeLetras(texto));
            Console.WriteLine(ContadorDeNumeros(texto));
            Console.WriteLine(ContadorDeSeparadores(texto));
            Console.WriteLine(CorretorDeTexto(texto));
        }

        public static int ContadorDeLetras(string value)
        {
            return 0;
        }

        public static int ContadorDeNumeros(string value)
        {
            return 0;
        }

        public static int ContadorDeSeparadores(string value)
        {
            return 0;
        }
       
        public static string CorretorDeTexto(string value)
        {
            return "";
        }
    }
}
