using System;

namespace exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("Digite um numero inteiro:");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 % 2 == 0 )
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("impar");
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("Digite um numero a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero b:");
            int b = int.Parse(Console.ReadLine());

            if(a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}