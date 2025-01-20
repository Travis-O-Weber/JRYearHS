/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/5/2016
 * Time: 2:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber__Travis_lab408
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("What is the speed limit?");
			
			double speedlimit = double.Parse (Console.ReadLine());
			
			Console.WriteLine("What is the speed you were going?"); /* David is a qwer*/
			
			double speed = double.Parse (Console.ReadLine());
			double speedlimitover = speed-speedlimit;
			
			if (speedlimitover  >= 0 && speedlimitover  <= 10 )
			{
				Console.WriteLine("$125.00");
			}
			
			else if (speedlimitover >= 11 && speedlimitover <= 15 )
			{
				Console.WriteLine("$175.00");
			}
			
			else if (speedlimitover >= 16 && speedlimitover <= 20 )
			{
				Console.WriteLine("$225.00");
			}
			
			else if (speedlimitover >= 21 && speedlimitover <= 25 )
			{
				Console.WriteLine("$300.00");
			}
			
			else if (speedlimitover >= 25)
			{
				Console.WriteLine("$"+(((speedlimitover - 25) * 50) +300));
			}
			
			// TODO: Implement Functionality Here
			
			
			Console.ReadKey(true);
		}
	}
}