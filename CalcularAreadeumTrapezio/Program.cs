
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (B+b) / 2.0 * h;

            Console.WriteLine(area);
        }
    }
}