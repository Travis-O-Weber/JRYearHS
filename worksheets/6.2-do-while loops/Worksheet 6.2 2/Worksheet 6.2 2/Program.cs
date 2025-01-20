/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/17/2016
 * Time: 8:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("2.");
			
			int counter = 48;
			do 
			{
				counter /= 3;
				Console.WriteLine(counter);
			}
			while (counter > 1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}