using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 minuto = 60 segundos
            // 1 hora = 60 minutos = 3600 segundos
            int n, horas, resto, minutos, segundos;
            n = int.Parse(Console.ReadLine());
            horas = n / 3600;
            resto = n % 3600;
            minutos = resto /60;
            segundos = resto % 60;
            Console.WriteLine(horas + ":"+minutos+":"+segundos);


            

        }
    }
}