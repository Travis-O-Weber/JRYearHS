/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 11/19/2015
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis_Not_David__worksheet_3.__part_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double flowerCost = 3.00; //decalre variable 
			double bellCost = 0.75; //decalre variable
			double ribbonCost = 2.75; //decalre variable
			double footballCost = 1.25; //decalre variable
			double salesTax = 0.0825; //decalre variable
				
			Console.WriteLine("How Many Flowers?"); // question displayed 
			string amountFlowers = Console.ReadLine(); // user input
			double totflowers = double.Parse(amountFlowers); //total parse
			
			Console.WriteLine("How Many bells?"); // question displayed
			string amountBells = Console.ReadLine(); // user input
			double totBells = double.Parse(amountBells); //total parse
			
			Console.WriteLine("How Many yards of ribbon?"); // question displayed
			string amountRibbon = Console.ReadLine(); // user input
			double totRibbon = double.Parse(amountRibbon); //total parse
			
			Console.WriteLine("How Many plastic footballs?"); // question displayed
			string amountFootballs = Console.ReadLine(); // user input 
			double totfootballs = double.Parse(amountFootballs); //total parse
			
			double total = ((flowerCost*totflowers)+(bellCost*totBells)+(ribbonCost*totRibbon)+(footballCost*totfootballs)); //adding it all together 
			double totalTax = salesTax*total; // adding in sales tax
			
			Console.WriteLine(total+totalTax);
				
			Console.ReadKey(true);
		}
	}
}