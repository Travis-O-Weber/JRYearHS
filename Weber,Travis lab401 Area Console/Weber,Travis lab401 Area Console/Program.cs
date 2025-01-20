/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 1/20/2016
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis_lab401_Area_Console
{
	class Program
	{
		public static void Main(string[] args)
		{
			
	    	Console.WriteLine("What shape do you want to find the area of");
		    Console.WriteLine("Please enter as 1 for Circle, 2 for Triangle, and 3 for rectangle.");
		   
		    int c=int.Parse(Console.ReadLine());
		    
		   if (c==1)
		    {
		    double pi= 3.14159;
		    Console.WriteLine("What is the radius");
			double r= double.Parse(Console.ReadLine());
			
			Console.Write("The area of your circle is ");
			Console.WriteLine(r*r*pi);
		   }
			
		    
		    
		   if (c==2)
		    {
		    
		    Console.WriteLine("What is the base");
			double B= double.Parse(Console.ReadLine());
			
			 Console.WriteLine("What is the height");
			double H= double.Parse(Console.ReadLine());
			
			Console.Write("The area of your triangle is ");
			Console.WriteLine(B*H*.5);
		   
		   }
			
			 if (c==3)
		    {
		    
		    Console.WriteLine("What is the length");
			double l= double.Parse(Console.ReadLine());
			
			 Console.WriteLine("What is the width");
			double w= double.Parse(Console.ReadLine());
			
			Console.Write("The area of your rectangle is ");
			Console.WriteLine(l*w);
		   
		   }
			
		    
		    
	
				
		
			// TODO: Implement Functionality Here
			
		
			Console.ReadKey(true);
		}
	}
}