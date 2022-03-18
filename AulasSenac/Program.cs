using System;
using System.Collections.Generic;

namespace AulasSenac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array
            //int totalDeItems = 0;
            //string texto = "Abacate, Banana, Cebola, Alho, Amendoim";

            //string[] listaDeCompras = texto.Split();


            //listaDeCompras[1] = "";
            //for (int i = 0; i < listaDeCompras.Length; i++)
            //{
            //    if (listaDeCompras[i].StartsWith('A'))
            //    {
            //        Console.WriteLine(listaDeCompras[i]);
            //    }
            //}
            #endregion

            var texto = Console.ReadLine();

            Console.WriteLine($"{texto[0]}{texto.Length}{texto[texto.Length -1]}");
        }





        static void AulasListas()
        {
            List<string> listaDeCompras = new List<string>();

            listaDeCompras.Add("Abacate");
            listaDeCompras.Add("Ovo");
            listaDeCompras.Add("Cebola");
            listaDeCompras.Add("Alho");
            listaDeCompras.Add("Amendoim");

            //listaDeCompras.Remove("Alho");
            //listaDeCompras.Remove(listaDeCompras.Count);
            //listaDeCompras.Insert(1, "Banana");
            //listaDeCompras.RemoveAt(3);

            //var resultado = listaDeCompras.Find(texto => texto.EndsWith("o"));
            //resultado = listaDeCompras.FindLast(texto => texto.EndsWith("o"));
            //var res = listaDeCompras.FindIndex(texto => texto.StartsWith("C"));
            var res = listaDeCompras.FindAll(texto => texto.StartsWith("A"));

            //Console.WriteLine(res);

            foreach (var item in res)
                Console.WriteLine(item);
        }








        static void AulaStringsChars()
        {
            #region EntendendoStrings
            //string texto = "Hello World!";
            //Console.WriteLine(texto.Replace("l", "5"));
            //string traducao = "Ola Mundo";
            //texto += traducao;
            //Console.WriteLine(texto);

            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto);
            #endregion

            #region conversão de entrada de dados
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.TryParse(Console.ReadLine(), out 0);
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1.ToString() + num3.ToString());
            #endregion

            #region Conversão Implícita x Explícita
            //int numero = 1234;
            //double resultado = numero;

            //double numero2 = 1234;
            //int resultado2 = (int)numero2;
            #endregion

            #region Escritas de saída Concatenada, Composta, Interpolada
            //string nome1 = "Fulano", nome2 = "Beltrano";

            ////Concatenação
            //Console.WriteLine(nome1 + " e " + nome2 + " são alunos.");

            ////Formatação composta            
            //Console.WriteLine("{0} e {1} são alunos", nome1, nome2);

            ////Interpolação
            //Console.WriteLine($"{nome1} e {nome2} são alunos");

            #endregion

            #region Caracteres
            //var letra = 'X';

            //Console.WriteLine(letra.GetType());
            //Console.WriteLine(letra.ToString());
            //Console.WriteLine(letra + 1); //char é um número

            #endregion

            #region Loops For Each (percorrer listas)
            //string textoQualquer = "Feliz 2022!";

            //foreach (var letra in textoQualquer)
            //{
            //    if (char.IsLetter(letra))
            //    {
            //        Console.Write(letra);
            //    }
            //}
            #endregion
        }


    }
}
