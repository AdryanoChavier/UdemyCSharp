using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string[] i = Console.ReadLine().Split(' ');
            int a = int.Parse(i[0]);
            int b = int.Parse(i[1]);
            int c = int.Parse(i[2]);

            if (a < b && a < c ){
                Console.WriteLine("Menor = "+ a);
            }else{
                if (b < c){
                    Console.WriteLine("Menor = "+ b);
                }else{
                    Console.WriteLine("Menor = "+ c);
                }
            }
        }
    }
}
