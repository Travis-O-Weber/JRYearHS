/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/16/2016
 * Time: 4:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber__Travis_lab_414
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Please type your the number of the day you were born");
			int day = int.Parse (Console.ReadLine());
			
			Console.WriteLine("Please type your the number of the month you were born");
			int month = int.Parse (Console.ReadLine());
			
			Console.WriteLine("Please type your the number of the year you were born");
			int year = int.Parse (Console.ReadLine());

			
			int a = ((14 - month)/12);
			year = (year-a);
			month = (month + (12*a) - 2);
			day = ((day + year + (year/4) - (year/100) + (year/400) + ((31*month) / 12))%7);
			
			

						if (day == 0)
				       {
				        	Console.WriteLine("You were born on a Sunday");
				       }
				        else
						if (day == 1)
				       {
				        	Console.WriteLine("You were born on a Monday");
				       }
				        else
				        if (day == 2)
				       {
				        	Console.WriteLine("You were born on a Tuesday");
				       }
				        else
				        if (day == 3)
				       {
				        	Console.WriteLine("You were born on a Wednesday");
				       }
				        else
				        if (day == 4)
				       {
				        	Console.WriteLine("You were born on a Thursday");
				       }
				        else
				        if (day == 5)
				       {
				        	Console.WriteLine("You were born on a Friday");
				       }
				        else
				        if (day == 6)
				       {
				        	Console.WriteLine("You were born on a Saterday");
				       }
				       
				       
				       
				       
				       
				       // TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}