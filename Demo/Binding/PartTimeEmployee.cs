using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class PartTimeEmployee:Employee
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public string Address { get; set; }
        public double HourRate { get; set; }
        public int NumberOFHours { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I am part Time Employee ");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary: {HourRate*NumberOFHours}");
        }
    }
}
