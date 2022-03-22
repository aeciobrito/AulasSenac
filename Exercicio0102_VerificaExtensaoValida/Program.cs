using System;
using System.Collections.Generic;

/// <summary>
/// A lista de nomes dos arquivos se refere ao conteúdo de um diretório X.
/// A sua tarefa é separar os arquivos por tipos em diferentes listas,
/// para que possam ser posteriormente agrupados em outros diretórios.
/// Arquivos de texto tem extensão .txt, .pdf, .doc, .rtf...
/// Arquivos de imagem tem extensão .png, .jpg, .bmp...
/// Demais arquvos podem seguir para uma listra de "outros"
/// </summary>
namespace Exercicio0102_VerificaExtensaoValida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arquivos = new List<string>()
            {
                "trabalho_faculdade.pdf",
                "listaDeCompras.txt",
                "captura_tela_2022_01.jpg",
                "monografia_ads.doc",
                "sony_img_2022.png",
                "aniversarioPai.mp4"
            };

            foreach (string arquivo in arquivos)
                Console.WriteLine(arquivo);
        }

        //Crie um método que retorne uma lista contendo apenas os arquivos de texto
        //Crie um método que retorne uma lista contendo apenas os arquivos de imagem
        //Crie um método que retorne uma lista contendo apenas os arquivos restantes
        /* OPCIONALMENTE, crie um único método que resolva o problema inteiro */
    }
}
