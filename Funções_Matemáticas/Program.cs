using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A = Math.Sqrt(x); Variavel A recebe a raiz quadrada de x
            // A = Math.Pow(x, y); Variavel A recebe o resultado de x elevado a y
            // A = Math.Abs(x); Variavel A recebe o valor absoluto de x

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);  //Variavel A recebe a raiz quadrada de x
            B = Math.Sqrt(y);  //Variavel B recebe a raiz quadrada de y
            C = Math.Sqrt(25.0); //Variavel C recebe a raiz quadrada de 25
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);

            A = Math.Pow(x,y); // A = Math.Pow(x, y); Variavel A recebe o resultado de x elevado a y
            B = Math.Pow(x,2.0); // B = Math.Pow(x, y); Variavel B recebe o resultado de x elevado ao quadrado
            C = Math.Pow(5.0,2.0); // C = Math.Pow(x, y); Variavel A recebe o resultado de x elevado ao quadrado
            Console.WriteLine(x + " elevado a "+ y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);




        }
    }
}