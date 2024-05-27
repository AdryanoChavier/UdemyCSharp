using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int  cont;
            idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            soma = 0.0;
            cont = 0;
            while (idade >= 0)
            {   
                soma += idade;
                cont += 1;
                idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            if(cont == 0){
                Console.WriteLine("Impossivel de calcular");
            }else{
                media = soma/cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}