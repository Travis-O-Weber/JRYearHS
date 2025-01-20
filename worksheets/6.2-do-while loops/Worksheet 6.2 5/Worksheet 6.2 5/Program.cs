/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/17/2016
 * Time: 9:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int value = 100, counter = 0;
			do
			{
				counter ++;
				value /= counter;
				Console.WriteLine(value);
			}
			while (value != 0);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}