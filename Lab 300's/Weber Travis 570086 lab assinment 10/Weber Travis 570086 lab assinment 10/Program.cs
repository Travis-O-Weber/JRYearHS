/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 11/5/2015
 * Time: 2:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis_570086_lab_assinment_10
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2; 

num1 = 50;

num2 = 300; 

double num3 = 5.0; 

double num4 = 9.2; 

bool boo = true; 

string name = "O'Connor"; 

char initial = 'P'; 

Console.WriteLine("---- integer testing----"); 

Console.WriteLine(num1 + num2); 

Console.WriteLine(num1 - num2); 

Console.WriteLine(num1 * num2); 

Console.WriteLine(num1 / num2); 

Console.WriteLine(num1 % num2); 

Console.WriteLine(); 

Console.WriteLine(num2 + num1); 

Console.WriteLine(num2 - num1); 

Console.WriteLine(num2 * num1); 

Console.WriteLine(num2 / num1); 

Console.WriteLine(num2 % num1); 

Console.WriteLine(); 

Console.WriteLine("---- real number(double) testing----"); 

Console.WriteLine(num3 + num4); 

Console.WriteLine(num3 - num4); 

Console.WriteLine(num3 * num4); 

Console.WriteLine(num3 / num4); 

Console.WriteLine(); 

Console.WriteLine(num4 + num3); 

Console.WriteLine(num4 - num3); 

Console.WriteLine(num4 * num3); 

Console.WriteLine(num4 / num3); 

Console.WriteLine(); 

Console.WriteLine("---- boolean testing----"); 

Console.WriteLine(boo);; 

Console.WriteLine(); 

Console.WriteLine("----string testing----"); 

Console.WriteLine(name); 

Console.WriteLine(); 

Console.WriteLine("---- char testing----"); 

Console.WriteLine(initial);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}