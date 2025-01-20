/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/23/2016
 * Time: 5:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Test_100_down_to_5_by_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int p = 100;						/*14.*/
			
			while (p > 0)
			{
				Console.WriteLine(p);
				p -= 5;
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}