using System;
using System.Globalization;

namespace CONSUMO_MEDIO_CARRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distância (Km): ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Litros consumidos (L): ");
            double litros = double.Parse(Console.ReadLine());

            double consMedio = km / litros;
            Console.WriteLine("Consumo médio : {0}km/l", consMedio.ToString("F3", CultureInfo. InvariantCulture));


        }
    }
}
