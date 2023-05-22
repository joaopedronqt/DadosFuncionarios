using System;
using System.Globalization;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Funcionario fun = new Funcionario();

            System.Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            System.Console.WriteLine();
            Console.Write("Funcionario: " + fun);

            System.Console.WriteLine();
            
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double por = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(por);
            
            System.Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + fun);

        }           
    }
}