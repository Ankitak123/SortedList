using System;
using System.Collections.Generic;
namespace SortedList
{

public class program
    { 
    static void Main(string[] args)
		{
			//SortedList of int keys, string values 
			SortedList<int, string> numberNames = new SortedList<int, string>();
			numberNames.Add(3, "Three");
			numberNames.Add(1, "One");
			numberNames.Add(2, "Two");
			numberNames.Add(4, null);
			numberNames.Add(10, "Ten");
			numberNames.Add(5, "Five");

			//The following will throw exceptions
			//numberNames.Add("Three", 3); //Compile-time error: key must be int type
			//numberNames.Add(1, "One"); //Run-time exception: duplicate key
			//numberNames.Add(null, "Five");//Run-time exception: key cannot be null

			Console.WriteLine("---NumberNames---");
			foreach (var kvp in numberNames)
				Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);

			

		}
	}
}