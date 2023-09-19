namespace Bai2_c
{
    internal class Program
    {
        //Create a delegate
        public delegate void MathOps(int a);
        static void Main(string[] args)
        {
            int y = 10;
            // Instantiate the delegate using an anonymous method
            MathOps ops = delegate (int x)
            {
                Console.WriteLine("Add Result: {0}", x + y);
                Console.WriteLine("Subtract Result: {0}", x - y);
            };
            ops(90);
            Console.ReadLine(); 
        }
    }
}