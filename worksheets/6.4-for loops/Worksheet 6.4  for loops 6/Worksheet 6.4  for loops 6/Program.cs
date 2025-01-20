/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/20/2016
 * Time: 9:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Worksheet_6.___for_loops_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			string phrase = "Clark Cougars Rock!";						/*5*/
			int begin = phrase.Length-1;
			int end = 0;
			
			for(i = begin; i< end; i+=2)
				Console.Write(phrase.Substring(i,1)+"");
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}