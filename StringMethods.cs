using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hey there ,how are u?";
            Console.WriteLine(str1.Length);
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1[5]);
            Console.WriteLine(str1.Contains(","));
            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf("there"));
            Console.WriteLine(str1.IndexOf('e', 8));
            Console.WriteLine(str1.IndexOf('o', 1,10));
            Console.WriteLine(str1.Substring(3));
            Console.WriteLine(str1.Substring(3, 3));
            string[] arr = str1.Split(",");
            Console.WriteLine(arr[0] + "    " + arr[1]);


        }
    }
}
