using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRelationships
{
    interface IB
    {
        void Show();

    }
    interface IC:IB,IA
    {
        void ShowData();
    }
    interface IA
    {
        int Age { get; set; }
        void Show();
    }
    
    class B:IA,IB
    {
        public void Show()
        {
            throw new NotImplementedException();
        }
        private int _age;
        public int Age
        {
            get 
            {
                //_age = CalculateAge();
                return _age; 
            }
            set { _age = value; }
        }
    }
    class C :IC
    {
        class D
        {
            protected void Sub(int a,int b)
            {
                C obj = new C();

                
            }
           
        }

        protected void Add()
        {
            D obj = new D();
           
        }
        private void ShowData()
        {
            C obj = new C();
            obj.Add();
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public class Demo:C
{

        private static Demo obj;
        private Demo()
        {
           
        }
        public static Demo GetInstance()
        {
            if(obj ==null)
            {
                obj = new Demo();
            }
            return obj;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            C objc=new C();
            objc.
            var s=Demo.GetInstance();
            var emp = new Employee();

            var projectForEmp2 = new Project();
            var emp2 = new Employee(projectForEmp2);

            IA objB = new B();
            B obj = new B();
            obj.Show();
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
