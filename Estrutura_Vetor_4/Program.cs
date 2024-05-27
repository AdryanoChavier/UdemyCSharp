using System.Globalization;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
             
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes =new string[N];
            int[] idades = new int[N];
            double[] altura = new double[N];

            for (int i = 0; i < N; i++){
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2],CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int i = 0; i < N;i++){
                soma = soma + altura[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura media: "+media.ToString("F2",CultureInfo.InvariantCulture));

            int cont = 0;
            for(int i =0; i < N;i++){
                cont = cont + idades[i];
            }
            double media_idade = (double) cont / N;
            Console.WriteLine("A media de idade é: "+media_idade.ToString("F2",CultureInfo.InvariantCulture));




            int cont2 = 0;
            for(int i = 0; i < N;i++){
                if(idades[i]<16){
                    cont2++;
                }
            }
            double media_16 = (double) cont2 / N * 100;
            Console.WriteLine("Porcentagem de pessoas com menos de 16 anos: "+media_16.ToString("F2",CultureInfo.InvariantCulture)+"%");

        }        
    } 
}
 