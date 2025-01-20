/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/19/2016
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__13
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			int num = 5; 
			
			while (num < 105)					/*13.*/
			{
				Console.WriteLine(num);
				num += 5;
			}
			
			
			int p = 100;						/*14.*/
			
			while (p > 0)
			{
				Console.WriteLine(p);
				p -= 5;
			}
			
			int c = 1;                           /*15.*/
			while (c <= 5)
			{
			Console.WriteLine("Travis Weber");
			
			c += 1;
			}
			
			Console.WriteLine("10 9 8 7 6 5 4 3 2 1 blastoff");
			
				
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}