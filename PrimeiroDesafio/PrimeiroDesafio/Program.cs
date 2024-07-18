﻿using System;
using System.Globalization;

namespace PrimeiroDesafio {
    class Program
    {
        static void Main(string[] args) {
            string Produto1 = "Computador";
            string Produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{Produto1}, cujo preço é ${preco1:F2}");
            Console.WriteLine($"{Produto2}, cujo preço é ${preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredonda (três decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}