using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSHtmlHelper.Controllers
{
    public class DatastructureController : Controller
    {
        //
        // GET: /Datastructure/
        public  bool LinearSearch(int num,int []arr)
        {
            for (int i = 0; i < arr.Length;i++ )
            {
                if(arr[i]==num)
                {
                    return true;
                }
            
            }
            return false;
        }
        public bool searchFunction(string[] a) {
            int[] array = new int[] { 1, 23, 5, 6, 7, 8, 9, 4, 13, 44 };
            // View bag
            var value = Request["Number"];
            int num = Convert.ToInt16(value);
            bool flag = LinearSearch(num, array);
            return true;
        }
        public string[] sortFunction(string []arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Convert.ToInt32(arr[i]) < Convert.ToInt32(arr[j]))
                    {
                        string temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                    // 5, 2 , 9 ,1 , 2
                    // 2. 5 ,9 ,1 ,2
                }
            }
            return arr;
        }
        public ActionResult Sorting() 
        {
            //string list = (string)Request["name"];
            string radioButton = ""+(string)Request["Operation"];
            System.Diagnostics.Debug.WriteLine("The value of Radio Button" + radioButton);
            bool result = false;
          
            string list = (string)Request["name"];
            
            if (list == null) {  list = "5,4,3,2,1"; }
            string[] arr = list.Split(',');
            // Bubble Sort

          //  System.Diagnostics.Debug.WriteLine("The Comparision Returns" +( 1 == string.Compare("" + radioButton, "Sorting")));
           // System.Diagnostics.Debug.WriteLine("The Comparision Returns" + (0 == string.Compare("" + radioButton, "Sorting")));
            
            if (radioButton.Equals("Sorting")) { 
                arr = sortFunction(arr); 
            }
            if (radioButton.Equals("Searching")) { 
                result = searchFunction(arr); 
            }
            
            
            for (int i = 0; i < arr.Length;i++ )
            {
                System.Diagnostics.Debug.WriteLine(""+arr[i]);
            }
          
            ViewBag.Sorted = arr;
            string ans = "Found :" + result;
            
            ViewBag.Search = ans;
                return View();
            
        }
        public ActionResult Searching()
        {
            int []array = new int[]{1,23,5,6,7,8,9,4,13,44};
            // View bag
            var value = Request["Number"];
            int num = Convert.ToInt16(value);
            bool flag = LinearSearch(num,array);
            Console.WriteLine("Status :"+flag);
            ViewBag.Answer = flag;


            return View(); 
        }
        public ActionResult Index()
        {
            return View();
        }
	}
}