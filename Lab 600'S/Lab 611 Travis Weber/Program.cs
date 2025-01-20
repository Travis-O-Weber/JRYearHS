/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/19/2016
 * Time: 2:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab_611_Travis_Weber
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please type the limit");
			
			double counter = 0; 
			double fin = 0;
			
			double test = double.Parse(Console.ReadLine());
			while (counter < test-2)
			{
				counter+=2;
				fin = fin + counter;
			}
			
			Console.WriteLine("The sum of the even integers between 1 and " +test +" is " +fin);
		
			// TODO: Implement Functionality Here

			Console.ReadKey(true);
		}
	}
}