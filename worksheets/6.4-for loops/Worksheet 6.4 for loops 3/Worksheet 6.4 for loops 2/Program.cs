/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/19/2016
 * Time: 3:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__for_loops_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int begin = 5; 						/*3*/
			int end = 0;
			
			for(int i = begin; i>= end; i--)
				Console.WriteLine(i+"");
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}