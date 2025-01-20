/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/5/2016
 * Time: 9:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lab_601.__Travis_Weber
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("please type the number you want to know is prime or composite");
			
			int testnum = int.Parse(Console.ReadLine());
			 int counter= 0;
 for (int i = 2; i <= testnum ; i++)
     if (testnum  % i == 0)                        
          counter++;

 if (testnum  != 1 && counter == 1)                 
     Console.WriteLine("Your number is prime");
 else
     Console.WriteLine("Your number is composite");
			Console.ReadKey(true);
		}
	}
}