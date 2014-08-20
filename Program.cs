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

            Console.Write("\n\n\n");

            //inicio exercício 2
            Console.WriteLine("2) Faça um programa que tenha como resultado de saída o nome de 5 times de futebol, sendo que cada nome deve estar em uma linha.");
            string[] times = new string[5] { "Ponte Preta", "Brasil", "Foda-se, não gosto de futebol","Maria Bethania","Não sei se Maria Bethania está certo" };
            for (int x = 0; x < times.Length; x++){
                Console.WriteLine(times[x]);
            }
            //fim exercício 2

            Console.Write("\n\n\n");

            Console.ReadKey();
            //inicio exercício 3
            Console.WriteLine("3) Faça um programa que exiba na tela o resultado do dobro do número 11.");
            int numero;
            numero = 11;
            Console.WriteLine("O dobro do número 11 é " + (numero * 2));
            //fim exercício 3


        }
    }
}
