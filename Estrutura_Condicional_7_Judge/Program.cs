
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
          string[] v = Console.ReadLine().Split(' ');

          int A = int.Parse(v[0]);
          int B = int.Parse(v[1]);
          int C = int.Parse(v[2]);
          int D = int.Parse(v[3]);

          if(B > C && D > A && (C + D) > (A+B) && (C > 0) && (D > 0) && A%2 == 0){
            Console.WriteLine("Valores aceitos");

          } else{
            Console.WriteLine("Valores não aceitos");
          }

        }
    }
}
