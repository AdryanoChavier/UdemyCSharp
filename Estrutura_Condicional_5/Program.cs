
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int minutos;
            double conta = 50.0;
            Console.Write("Digite o minutos da conta: ");
            minutos = int.Parse(Console.ReadLine());
            if(minutos > 100){
                 conta += (minutos - 100)*2.0;

            }
                Console.WriteLine("Valor a pagar: R$"+conta.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
