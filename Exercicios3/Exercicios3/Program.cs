using System;
using System.Globalization;

namespace exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha Suas Preferencias");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            int escolha = int.Parse(Console.ReadLine());
            int alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;
            while (escolha != 4)
            {
                if (escolha == 1)
                {
                    alcool++;
                }
               if (escolha == 2)
                {
                    Gasolina++;
                }
                if (escolha == 3)
                {
                    Diesel++;
                }

                else if (escolha > 4 || escolha < 0)
                { 
                    Console.WriteLine("Codigo invalido Digite novo codigo");
                   
                }
                escolha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}