/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/18/2016
 * Time: 2:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int number = -4;
			do 
			{
				Console.WriteLine(number);
				number +=3;
				
			}while (number <= 20);
				
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}