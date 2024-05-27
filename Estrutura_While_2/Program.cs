using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if(x<y){
                    Console.WriteLine("Crescente");
                }else{
                    Console.WriteLine("Descrescente");
                }
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            } 
        }
    }
}