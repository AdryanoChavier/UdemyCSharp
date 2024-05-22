using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bs, altura;
            bs = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("A área do rentangulo é "+(bs*altura).ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("O perimetro do retangulo é "+(2*(bs+altura)).ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("A diagonal do retangulo é " + Math.Sqrt(Math.Pow(bs,2.0)+Math.Pow(altura,2.0)).ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}