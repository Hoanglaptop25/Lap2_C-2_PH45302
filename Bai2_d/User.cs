using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_d
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void GetInfor(dynamic d)
        {
            Console.WriteLine(d);
        }
    }
}
