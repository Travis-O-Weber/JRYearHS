/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/17/2016
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab_608_Travis
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			double counter = 0; 
			double fin = 0;
			
			double test = double.Parse(Console.ReadLine());
			while (counter < test)
			{
				counter++;
				fin = fin + counter;
			}
			double limit = fin/test;
			Console.WriteLine("The average is " +limit);
		
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}