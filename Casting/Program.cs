namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Casting é a conversão explicita de um tipo para outr
            //é necessario quando o compilador não é capaz de "adivinhar" 
            //que o resultado de uma expressão deve ser de outro tipo

            int a, b,c;
            double resultado,casting,d;
           
            a = 5;
            b = 2;
            d = 5.0;
            c = (int)d; //Casting

            resultado = a/b;
            casting = (double) a/b; //Casting
            Console.WriteLine(resultado);
            Console.WriteLine(casting);

        }
    }
}