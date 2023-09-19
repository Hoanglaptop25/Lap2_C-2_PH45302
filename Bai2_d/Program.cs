using Bai1_d;
using System.Reflection.Metadata;
using System.Text;

namespace Bai1_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            dynamic dobj = new User();
            dobj.GetInfor("Nhà ở Tây Hồ");
            Console.ReadKey();
        }
        
    }
}