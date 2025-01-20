/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/17/2016
 * Time: 8:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet__6.__1_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("1.");
			int counter = 48;
			do 
			{
				Console.WriteLine(counter);
				counter /= 3;
			}
			while (counter > 1);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}