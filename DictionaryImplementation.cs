using System;
using System.Collections.Generic;
namespace Dictionary
{
class Employee
{ 
	public int id;
	public string ename;
	public string email;
	public Employee(int id ,string ename,string email)
	{
		this.id=id;
		this.ename=ename;
		this.email=email;
	}
	//public string ToString()

	}	
	class Program
	{
	static void Main()
	{ 
	var employees=new Dictionary<int ,Employee>();
    var tony=new Employee(10001,"tony","tony@t.com");
    var carl=new Employee(10002,"carl","carl@c.com");


employees.Add(10001,tony);
employees.Add(10002,carl);


	while(true)
	{
		Console.WriteLine("Enter employee id to check and X to exit: ");

		var userinput=Console.ReadLine();
		if(userinput=="X")
		break;
		else
		{
			int id=Int32.Parse(userinput);
			Employee employee;
			if(employees.TryGetValue(id, out employee))
			{ 
				Console.WriteLine(employee.id+"  "+employee.ename);

				}
				else
				{
					Console.WriteLine("employee with given id does'nt exist");
				}
		}


	}

   }
	}
}