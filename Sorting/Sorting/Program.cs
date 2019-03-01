using System;
using Sorting.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Logics obj = new Logics();
            //int[] arr = new int[] { 3, 5,44, 0, 1, 4, 2,55,44,11,12,10,15,17,19,23,32,36,63,96,69,87,78,54,45,20,100,12,11,14,185,69,74,123,650 };
            //obj.Sort(arr);
            //obj.Swap(2, 3);
            //obj.LinearSearch(650,arr);
            int[] arr = new int[] { 1, 2, 3, 4,8, 9, 10 };
            //bool ans = obj.BinarySearch(1, arr);
            //Console.WriteLine("Number : " +1+ " found status : " + ans);
            for (int i = 0; i <arr.Length; i++)
            {
                bool ans = obj.BinarySearch(arr[i], arr);
                Console.WriteLine("Number : "+arr[i]+" found status : " + ans);            
            }
                
            Console.ReadKey();
        }
    }
}
