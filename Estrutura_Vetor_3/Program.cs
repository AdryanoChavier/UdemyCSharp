using System.Globalization;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
          int N;
          double[]  A;

          N = int.Parse(Console.ReadLine());
          A = new double[N];

          string[] s = Console.ReadLine().Split(" ");
          for (int i = 0; i < N; i++)
          {
            A[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
          }

          for(int i = 0; i < N; i++){
            Console.WriteLine(A[i].ToString("F1",CultureInfo.InvariantCulture));
          }
          double soma = 0;
          for (int i = 0;i<N;i++){
            soma += A[i];
          }
            double media = soma/N;

            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
            

        }        
        } 
}
 
