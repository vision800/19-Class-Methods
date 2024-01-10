using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__Class_Methods
{
    internal class Student
    {
        double weight ;
        string name ;
        int age ;

        public Student(string name, double weight,  int age)
        {
            this.weight = weight;
            this.name = name;
            this.age = age;
        }

       public bool isObese()
        {
            if(weight>60) {
            return true;
            }
            else return false;
        }
    }
}
