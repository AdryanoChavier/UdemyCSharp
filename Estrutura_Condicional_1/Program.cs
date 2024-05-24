using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas;
            Console.WriteLine("Que horas são ?");
            horas = int.Parse(Console.ReadLine());
            if(horas < 12){
                Console.WriteLine("Bom dia!");
            }else if(horas < 18 ){
                Console.WriteLine("Boa tarde!");
            }else if(horas <= 24 ){
                Console.WriteLine("Boa noite!");
            }else {
                Console.WriteLine("Horario invado");
            }
        }
    }
}