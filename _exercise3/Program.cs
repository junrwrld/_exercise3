using System;
using System.Globalization;

namespace _exercise4
{
    class _exercise4
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Digite o valor que você deseja multiplicar o raio:");
            double calculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculoFinal = pi * (Math.Pow(calculo, 2.0));
            Console.WriteLine("O valor do cálculo será: " + calculoFinal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}