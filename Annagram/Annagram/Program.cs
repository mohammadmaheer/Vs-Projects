using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            s1 = "saaassasa";
            s2 = "assassasa";

            bool flag = IsAnnagram(s1,s2);

           
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(31));
            Console.WriteLine(IsPrime(11));
            Console.WriteLine(IsPrime(3));


            //Console.WriteLine(IsAnnagram("Test","Sate"));            

            Console.ReadKey();
        }

        private static bool IsPrime(int num)
        {
            bool flag = true;
            int m = num / 2;
            for (int i =2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        private static bool IsAnnagram(string first,string second)
        {
            bool flag = false;

            char[] arr_1 = first.ToCharArray();
            char[] arr_2 = second.ToCharArray();
            for (int i = 0; i < first.Length; i++)
            {
                if (arr_2.Contains(arr_1[i]))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
