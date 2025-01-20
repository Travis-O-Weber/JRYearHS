/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 11/18/2015
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis__Not_david__worksheet_3._
{
	class Program
	{
		public static void Main(string[] args)
		{
			double adultcost=4.75;
			double studentcost=3.50;
         	
           Console.WriteLine("student amount of tickets");
           string studentt = Console.ReadLine();
           Console.WriteLine("adult amount of tickets");
           string adultt = Console.ReadLine();
           Console.WriteLine("total cost of tickets");
           double adultT= double.Parse(adultt);
           double studentT= double.Parse(studentt);
           double totalcost = (studentcost*studentT)+(adultcost*adultT);
           Console.WriteLine(totalcost);
           Console.ReadKey(true);
            
            
		   
		}
	}
}