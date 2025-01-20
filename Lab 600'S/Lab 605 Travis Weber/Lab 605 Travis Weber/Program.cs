/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/1/2016
 * Time: 9:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab_605_Travis_Weber
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Type the number of fences you want");
			int fnum = int.Parse(Console.ReadLine());
			int fnum2=fnum;
			if (fnum > 0)
			{
				while (fnum > 0)
				{
					Console.Write("|===");
					fnum--;
				}
				Console.WriteLine("|");
				
				while (fnum2 > 0)
				{
					Console.Write("|===");
					fnum2--;
				}
				Console.WriteLine("|");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}