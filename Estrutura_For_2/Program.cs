using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int x, y, min, max, soma;
            x = int.Parse(Console.ReadLine());        
            y = int.Parse(Console.ReadLine());     

            if(x<y){
                min = x;
                max = y;
            }else{
                min = y;
                max = x;
            }
            soma = 0;
            for(int i = min+1; i<max; i++){
                if(i % 2 !=0){
                    soma += i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}
