
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  Console.WriteLine("Inseri 2 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            
            if(n2 % n1 == 0 || n1 % n2 == 0){
                Console.WriteLine("São Multiplos");
            }else{
                Console.WriteLine("Não sao Multiplos");
            }
        }
    }
}
