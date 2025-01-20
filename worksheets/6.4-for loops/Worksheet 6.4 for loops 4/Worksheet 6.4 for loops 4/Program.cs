/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/19/2016
 * Time: 3:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__for_loops_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			string phrase = "I love computer Science!";						/*4*/
			int begin = phrase.Length-1;
			int end = 0;
			
			for(i = begin; i>= end; i--)
				Console.WriteLine(phrase.Substring(i,1)+"");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}