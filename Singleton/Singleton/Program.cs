using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //class Singleton
    //{


    //    public static int counter =0 ;
    //    private Singleton()
    //    {

    //    }

    //    public void print() { Console.WriteLine("Singletin Implemented" ); }
    //    public static Singleton initializer()
    //    {
    //        if (counter==0)// Pehli dafa object bnanae ko kahe to banado)
    //        {
    //            counter++;
    //            return new Singleton();
    //        }
    //        else
    //        {

    //            return null;
    //        }


    //    }

    //    class Child : Singleton
    //    {   



    //    }
    //}
    class Program
    {
        //static int n1 = 0, n2 = 1, n3;
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter no:");
            //int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            string revstr = String.Empty;
            int legth = str.Length - 1;
            while(legth>=0)
            {
                revstr = revstr + str[legth];
                legth--;
            }
               //Console.WriteLine($"rev string is {revstr}");
            if (str == revstr)
            {
                Console.WriteLine($"{str} is palindrome");
            }
            else
            {
                Console.WriteLine($"{revstr} is not palindrome");

            }
            //int rem, rev = 0;
            //int num2 = num;
            //while(num>0)
            //{
            //    rem = num % 10;
            //    rev = rev * 10 + rem;
            //    num = num / 10;
            //}
            //if(rev==num2)
            //{
            //    Console.WriteLine($"{num2} is palinderome");
            //}
            //else { Console.WriteLine($"{num2} is not palinderome"); }
            //Console.WriteLine($"reversee num is {rev}");
            //for(int i =1;i<=num;i++)
            //{
            //    if(num%i==0)
            //    {
            //        Console.WriteLine($"factor of {num} is {i}");


            //    }
            //}

            //int sum = 0;
            //for(int i =1;i<=num;i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine($"sum of {num} is {sum}");





            //            Singleton first_obj =  Singleton.initializer();
            //            first_obj.print();
            //            Child second_obj = new Child();
            //}
            //Program obj = new Program();
            ////var a =obj.fact(5);
            ////Console.WriteLine(a);
            //var b = obj.fibonacci(10);
            //Console.WriteLine(b);

        }
        //int fibonacci(int num)
        //{
        //    if(num==0||num==1)
        //    {
        //        return 1;
        //    }
        //    Console.WriteLine(num);
        //    return fibonacci(num - 1) + fibonacci(num - 2);
        //}
        //public int fact(int num)
        //{
        //    if(num==0)
        //    {
        //        return 1;
        //    }

        //    return num * fact(num - 1);

        //}
    }
}
