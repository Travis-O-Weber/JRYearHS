/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 1/26/2016
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis_lab405_Hallo_Scream_Program
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter height in inches");
			double height= double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter weight in pounds");
			double weight= double.Parse(Console.ReadLine());
			
		
			if (weight < 109 && height > 75 )
			{
				Console.WriteLine("You are too light and too tall");
			}
			
			if (weight < 109 && height < 61)
			{
				Console.WriteLine("You are too light and too short ");
			}
			
			if (weight >  211 && height > 75)
			{
				Console.WriteLine("You are too heavy and too tall");
			}
			
			if (weight >  211 && height < 61)
			{
				Console.WriteLine("You are too heavy and too short");
			}
			
			if (weight < 110 && height >= 62 && height <= 74)
			{
				Console.WriteLine("You are too light");
			}
			
			if (weight > 210 && height >= 62 && height <= 74)
			{
				Console.WriteLine("You are too heavy");
			}
			
			if (height < 62 && weight <= 210 && weight >= 110)
			{
				Console.WriteLine("You are too short");
			}
			
			if (height > 74 && weight <= 210 && weight >= 110 )
			{
				Console.WriteLine("You are too tall");
			}
			if (height >= 62 && height <=74 &&  weight <= 210 && weight >= 110 )
			{
				Console.WriteLine("Congratulations you qualify");
			}
		
			// TODO: Implement Functionality Here
			
			
			
			Console.ReadKey(true);
		}
	}
}