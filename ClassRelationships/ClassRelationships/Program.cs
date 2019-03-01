using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRelationships
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();

            var projectForEmp2 = new Project();
            var emp2 = new Employee(projectForEmp2);
        }
    }
    class Employee
    {
        Project p1;
        public Employee()//composition
        {
            p1 = new Project();
        }


        public Employee(Project p)//aggregation
        {
            p1 = p;
        }


        ~ Employee()
        {
            p1 = null;
        }

    }

    class Project
    {
        public Project()
        {

        }

    }
}
