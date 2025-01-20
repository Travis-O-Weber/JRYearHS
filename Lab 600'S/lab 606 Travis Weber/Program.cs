/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/4/2016
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lab_606_Travis_Weber
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Enter the limit");
			int testnum = int.Parse(Console.ReadLine());
			int div;
			bool counter = false;
 			for(int i = 2; i <= testnum; i++)
 			{
 				for (div =2; div < i; div++)
 				{
 					if (i  % div == 0)
 					{
 						counter= true;
 					}
 				}
 				
 				if (counter == false)
 				{
 					Console.Write("\t"+div);
 				}
 				else counter =  false;
 			}
			Console.ReadKey(true);
		}
	}
}