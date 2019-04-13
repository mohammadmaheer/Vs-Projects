using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int value;
            string output = " ";
            Random obj = new Random();
            for (int i = 1; i <= 20; i++)
            {
                value = obj.Next(1, 7);
                output += value + " ";
                if (i % 5 == 0)
                {
                    output += "\n";
                }
            }
            MessageBox.Show(output, "20 randoms numbers ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           /* int[] a = { 15, 40, 56, 87, 80, 90, 12, 67, 45, 100 };
            int total = 0;
            for (int i = 0; i < a.Length; i++)
                total += a[i];
            MessageBox.Show("The Sum of an array is :" + total, "sum of an array elements",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
           // Console.ReadKey();*/
        }
    }
}
