using System.Globalization;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
          int N;
          int[] vet;
          N = int.Parse(Console.ReadLine());
          vet = new int[N];

          for (int i = 0; i < N; i++)
          { 
            vet[i] = int.Parse(Console.ReadLine()); 
          }

          for (int i = 0;i<N;i++){

            if (vet[i] < 0){
                Console.WriteLine(vet[i]);
            }
          }         
        } 
    }
 }
