using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1= new Student("VISION",56,23);
            Student st2 = new Student("VISION", 66, 23);

            Console.WriteLine("is obese true or false : " + st1.isObese());
            Console.WriteLine("is obese true or false : " + st2.isObese());
            Console.ReadLine();
        }
    }
}
