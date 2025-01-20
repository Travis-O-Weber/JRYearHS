/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/19/2016
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__for_loops_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int begin = 1; 						/*1*/
			int end = 5;
			
			for(int i = begin; i<= end; i++)
				Console.WriteLine(i+"");
				
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}