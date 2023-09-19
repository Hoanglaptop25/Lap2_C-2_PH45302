namespace Bai1b
{
    class Program
    {
        static void Main()
        {
            dynamic data = new Dictionary<string, int>();
            data.Add("cat", 2);
            data.Add("dog", 1);
            Console.WriteLine("cat - dog = {0}",
                data["cat"] - data["dog"]);
        }
    }
}
    
