using System;
using System.Globalization;
using System.Runtime.InteropServices;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do{
            Console.Write("Digite a temperatura em Celsius: ");
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            F = 9 * C / 5 + 32;
            Console.WriteLine("Equivalente em Fahrenheit: "+F.ToString("F1",CultureInfo.InvariantCulture));
            Console.Write("Deseja repetir (s/n)? ");
            repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');


        }
    }
}