﻿using System;

namespace AulasSenac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string items = "Abacate, Cebola, Banana";

            var listaDeCompras = items.Split(' ');

            //foreach (var decomp in listaDeCompras)
            //{
            //    Console.WriteLine(decomp);
            //}

           // Console.WriteLine(listaDeCompras.GetType());

            double[,] notasDisciplinas = new double[10, 4];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    notasDisciplinas[i, j] = rand.NextDouble() * 10;
                    //Console.WriteLine($"Disciplina {i + 1}, unidade {j + 1}: {notasDisciplinas[i,j]}");
                    Console.Write($"[{notasDisciplinas[i,j]:00.0}]");
                }
                Console.WriteLine();
            }           
        }



        static void AulaStrings()
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
