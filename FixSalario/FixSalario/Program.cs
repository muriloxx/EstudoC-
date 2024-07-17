using System;
using System.Globalization;

namespace FixSalario;

class Program
{
    static void Main(string[] args)
    {
        Funcionario p = new Funcionario();
        Console.WriteLine("Nome: ");
        p.Nome = Console.ReadLine();
        Console.WriteLine("Salário Bruto: " );
        p.SalarioBruto = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture );
        Console.WriteLine("Imposto: ");
        p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write("Funcionário: " + p);
        Console.WriteLine();

        Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
        double por = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        p.AumentarSalario(por);

        Console.WriteLine();
        Console.Write("Dados Atualizados " + p);

    }
}