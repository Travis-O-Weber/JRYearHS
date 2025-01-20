/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/17/2016
 * Time: 8:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.__4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string word = "electrecety";
			do
			{
				int eplace = word.IndexOf('e');
				word = word.Remove (eplace);
			}
			while (word.IndexOf('e') != -1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}