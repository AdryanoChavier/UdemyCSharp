using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a largura e o comprimento do terreno: ");
            string[] i = Console.ReadLine().Split(' ');
            double largura = double.Parse(i[0],CultureInfo.InvariantCulture);
            double comprimento = double.Parse(i[1],CultureInfo.InvariantCulture);
            double area = largura * comprimento;
            
            Console.WriteLine("A largura do terreno é " + largura + " metros e o comprimento é " + comprimento + " metros");
            Console.WriteLine("A área do terreno é "+area.ToString("F2",CultureInfo.InvariantCulture));
            Console.Write("Digite o preço do metro quadrado: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("O preço do imovel é de "+(preco*area).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}