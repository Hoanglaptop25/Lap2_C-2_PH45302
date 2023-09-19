namespace Bai2_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create anonymous type object
            var user = new
            {
                Id = 1,
                Name = "Suresh Dasari",
                IsActive = true,
            };
            //Access anonymous type object properties
            Console.WriteLine("Id:" + user.Id);
            Console.WriteLine("Name:" + user.Name);
            Console.WriteLine("IsActive:" + user.IsActive);
            Console.ReadLine();
          
        }
    }
}