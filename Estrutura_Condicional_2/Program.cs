using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Digite a primeira nota do aluno: ");
        double n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Digite a segunda nota do aluno: ");
        double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        if(n1+n2 >= 60.00){
            Console.WriteLine((n1+n2).ToString("F1",CultureInfo.InvariantCulture));
            Console.Write("Aprovado");
        }else{
            Console.WriteLine((n1+n2).ToString("F1",CultureInfo.InvariantCulture));
            Console.Write("Reprovado");
        }




        }
    }
}