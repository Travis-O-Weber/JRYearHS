/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/17/2016
 * Time: 8:52 PM
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
			string word = "hominy";
			int counter = 0;
			do
			{
				word = word.Insert(counter,"a");
				counter += 2;
			}
			while (counter < word.Length);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}