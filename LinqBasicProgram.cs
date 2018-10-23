using System;
using System.Linq;
using System.Collections.Generic;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[50];
            for (int i = 0; i < 50;i++)
            {
                arr[i] = i;
            }
            var brr = from i in arr where i>20 select i;


            foreach(int x in brr)
            Console.WriteLine(x+"  ");


             





            var names = new List<string> { "Nino", "Alberto", "Juan", "Mike", "Phil" };
            var namesWithJ = from n in names where n.StartsWith("J") orderby n select n;
            Console.WriteLine("First iteration"); 
            foreach (string name in namesWithJ)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            names.Add("John"); 
            names.Add("Jim"); 
            names.Add("Jack"); 
            names.Add("Denny");
            Console.WriteLine("Second iteration");
            foreach (string name in namesWithJ)
            {
                Console.WriteLine(name);
            }



        }
    }
}
