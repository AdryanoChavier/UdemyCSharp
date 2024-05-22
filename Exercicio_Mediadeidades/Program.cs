using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu primeiro nome e depois sua idade na mesma linha(separe por virgula): ");
            string[] i = Console.ReadLine().Split(',');
            string n1 = i[0];
            int i1 = int.Parse(i[1]);
            Console.WriteLine("Digite seu primeiro nome e depois sua idade na mesma linha(separe por virgula): ");
            string[] a = Console.ReadLine().Split(',');
            string n2 = a[0];
            int i2 = int.Parse(a[1]);
            double media = (double) (i2 + i1) /2;

            Console.WriteLine("A idade média de "+n1+ " e "+n2+" é de " + media.ToString("F1",CultureInfo.InvariantCulture) + " anos ");
        }   
    }
}