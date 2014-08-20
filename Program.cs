using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Código apenas para deixar o a execução mais bonita...
            Console.SetWindowSize(150, 30);
            Console.Title = "C#, Aula1 - Exercícios";
            //fim da viadagem

            //inicio exercício 1
            Console.WriteLine("1) Faça um programa que exiba na tela o resultado da soma dos números 55 e 60.\n");
            int primeiro_numero, segundo_numero, soma;
            primeiro_numero = 55;
            segundo_numero = 60;
            Console.WriteLine("O Primeiro número é "+primeiro_numero);
            Console.WriteLine("O Segundo número é " + segundo_numero);
            soma = primeiro_numero + segundo_numero;
            Console.WriteLine("A soma dos dois números é " + soma);
            //fim exercício 1




            Console.ReadKey();


        }
    }
}
