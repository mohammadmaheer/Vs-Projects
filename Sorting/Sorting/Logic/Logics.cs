using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Logic
{
    class Logics
    {
        public bool BinarySearch(int num,int[] arr)
        {
            
            int start = 0, middle, end = arr.Length-1;
            bool value = false;

            while(start<=end)
            {
                middle = (end + start) / 2;
                if (num == arr[middle])
                {
                    value = true;
                    break;

                }
                if (num > arr[middle])
                {
                    start = middle + 1;

                }
                else
                {
                    end = middle - 1;
                }

            }
            return value;

        }
        public bool LinearSearch(int num,int []arr)
        {
            bool searched = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("The number is found....");
                    searched = true;
                    break;
                    //return true;
                }

            }
            Console.WriteLine("The number is not found....");

            return searched;
        }
        public void Swap(int a,int b)
        {
            //2,3
            a = a + b;//a=5 b=3
            b = a - b;//a=5 b=2
            a = a - b;//a=3 b=2
            Console.WriteLine("a=:{0} & b=:{1}",a,b);
        }
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] > array[j])
                    {
                        array[i] = array[i] + array[j];
                        array[j] = array[i] - array[j];
                        array[i] = array[i] - array[j];

                    }

                }
            }
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
