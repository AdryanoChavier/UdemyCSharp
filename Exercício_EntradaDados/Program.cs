using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)

        {   Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.Write("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);    
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] i = Console.ReadLine().Split(' ');
            string sobrenome = i[0];
            int idade = int.Parse(i[1]);
            double altura = double.Parse(i[2],CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        



        }
    }
}