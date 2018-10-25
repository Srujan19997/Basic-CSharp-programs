using System;
using System.Collections.Generic;

class HashsetImplementation
{
	static void Main()
	{
		var cars=new HashSet<string>(){"Ferrari","McLaren","Audi","BMW","Volkswagon"};
		var privateTeams=new HashSet<string>(){"Ferrari","McLaren"};
		if(cars.Add("Koeinsegg"))
		Console.WriteLine("Koeinsegg Added");
	    if(!cars.Add("Ferrari"))
	    {
	    	Console.WriteLine("Ferrari already exists");

	    }
	    Console.WriteLine("---------\n\n Collections of Cars are as follows:");
	    foreach(var temp in cars)
	    {
	    	Console.WriteLine(temp);
	    }
	    if(privateTeams.IsSubsetOf(cars))
	    {
	    	Console.WriteLine("Private teams isSubSetOf cars");

	    }
	    if(!cars.IsSupersetOf(privateTeams))
	    Console.WriteLine("Cars is isSuperSetOf privateTeams");



	    Console.WriteLine("---------\n\n Collections of  Sorted Cars are as follows:");

	    var SortedCars=new SortedSet<string>(){"Ferrari","McLaren","Audi","BMW","Volkswagon"};
	    foreach(var temp in SortedCars)
	    {
	    	Console.WriteLine(temp);
	    }

	}
}