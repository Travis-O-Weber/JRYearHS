/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/18/2016
 * Time: 2:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int num=3;
			while( num <= 17 )
			{
				if (num % 3 == 0)
					Console.WriteLine(num);
				num += 2;
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}