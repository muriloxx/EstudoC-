using System;

namespace exercios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor numero 1:");
            int n1 = int.Parse( Console.ReadLine());

            Console.WriteLine("Valor numero 2:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valor da soma é: { n1 + n2}");

            int a = 5;
            int b = 6;
            int c = 7;
            int d = 8;

            int diferenca = a * b - c * d;
            Console.WriteLine( "A diferença é de "+ diferenca );
           
        }
    }
}
