using System;
using System.Globalization;
using System.Security.Cryptography;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double delta = Math.Pow(b,2.0)-4*a*c;

            if(a == 0 || delta < 0.0){
                Console.WriteLine("Impossivel de calcular");
            }else{
                double r1 = (-b + Math.Sqrt(delta))/(2.0*a);
                double r2 = (-b - Math.Sqrt(delta))/(2.0*a);
                Console.WriteLine("R1 = " + r1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R1 = " + r2.ToString("F5",CultureInfo.InvariantCulture));
            }
        }
    }
}