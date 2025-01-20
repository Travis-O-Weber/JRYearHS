/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/18/2016
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int num = 1;
			while (num*num  < 100)
			{
				Console.WriteLine(num +" "+ num );
				num++;
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}