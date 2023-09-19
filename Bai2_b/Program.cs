namespace Bai2_b
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
                jobInfor = new { Designation = "Lead", Location = "Hyderabad" }
            };
            //Access anonymous type object properties
            Console.WriteLine("Id:" + user.Id);
            Console.WriteLine("Name:" + user.Name);
            Console.WriteLine("IsActive:" + user.IsActive);
            Console.WriteLine("Designation:{0}, Location:{1}", user.jobInfor.Designation, user.jobInfor.Location);
            Console.ReadLine();

        }
    }
}