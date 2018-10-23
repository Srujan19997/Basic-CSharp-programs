using System;

namespace Inheritance
{
    public class Employee
    {
        public string name;
         public int  id_number;
        public string city;
        public void printDetails()
        {
            Console.WriteLine("{0} {1} {2}", name, id_number, city);
        }

    }
    class fullTimeEmployee : Employee
    {
       public int fixedSalary;
        public  void printDetails()
        {
            Console.WriteLine(name);
        }
        public void printDetails(DateTime Today)
        {
            Console.WriteLine(Today);
        }

    }
    class HourlyEmployee : Employee
    {
        public int  HourlyRate;
    }
   public  class Program
    {
        static void Main(string[] args)
        {
            fullTimeEmployee fte = new fullTimeEmployee();
            fte.name = "Srujan";
            fte.id_number = 80335;
            fte.city = "Hyderabad";
            fte.fixedSalary = 25000;
            fte.printDetails();
            DateTime date1 = DateTime.Today;
            fte.printDetails(date1);

            HourlyEmployee hObj = new HourlyEmployee();
            hObj.name = "Akhil";
            hObj.id_number = 80350;
            hObj.city = "Warangal";
            hObj.HourlyRate = 200;
            hObj.printDetails();


        }
    }
}
