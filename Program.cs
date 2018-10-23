using System;
using System.Collections.Generic;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

 */

          
            //resizing an array 
            int[] arr = new int[10];
            Array.Resize(ref arr, 15);

            //Array List
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Insert(1, 300);
            al.Add(400);
            al.Remove(200);
            al.Add(200);
            al.RemoveAt(2);



            //Hashtable

            Hashtable ht = new Hashtable();
            ht.Add("Eid",1001);
            ht.Add("Name","Srujan"); 
            ht.Add("Email","xy@xy.com");
            ht.Add("Location","Hyderabad");

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key+" "+ht[key]);
            }
            foreach(object value in ht.Values)
            {
                Console.WriteLine(value);
            }




            //Generic List
            List<int> list = new List<int>();
            //5 is size of list 
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            //list.Add(8);
            list.Sort();
            foreach (int i in list)
                Console.WriteLine(i);


            list.Add(0);
            list.RemoveAt(5);
            list.ForEach(a => Console.WriteLine(a));
             Console.WriteLine(list);

            //Stack
            var alphabet = new Stack<char>();
            alphabet.Push('a');
            alphabet.Push('B');
            alphabet.Push('C');
            foreach(char item in alphabet)
            {
                Console.WriteLine(item);
            }






            //SortedList
            var books = new SortedList<string, string>();
            books.Add("Professional WPF Programming", "978–0–470–04180–2");
            books.Add("Professional ASP.NET MVC 3", "978–1–1180–7658–3"); 
            books["Beginning Visual C# 2010"] = "978–0–470-50226-6"; 
            books["Professional C# 4 and .NET 4"] = "978–0–470–50225–9";

            foreach (KeyValuePair<string, string> book in books)
            {
                Console.WriteLine("{0}, {1}", book.Key, book.Value);
            }


        }
    }
}
