
namespace Bai1C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetDetails(100);
            GetDetails("Welcome to FPoly");
            GetDetails(true);
            GetDetails(20.50);
            Console.ReadLine();

        }
        static void GetDetails(dynamic d)
        {
            Console.WriteLine(d);
        }
    }
}