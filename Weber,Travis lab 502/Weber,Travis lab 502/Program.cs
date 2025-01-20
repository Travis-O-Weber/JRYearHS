/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 3/1/2016
 * Time: 2:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis_lab_502
{
	class Program
	{
		public static void Main(string[] args)
		{
			string words = (Console.ReadLine());
			
			words = words.ToLower();
			
			
			string wordadd = "ay"; 
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			string vowel6 = "y";
			
			
			if 
				(words.Substring(0,1) == vowel1 ||
			    words.Substring(0,1) == vowel2 ||
			    words.Substring(0,1) == vowel3 ||
			    words.Substring(0,1) == vowel4 ||
			    words.Substring(0,1) == vowel5 ||
			    words.Substring(0,1) == vowel6 )
			   
		
				{
				Console.WriteLine(words + wordadd);
			
				}
			else if 
				(words.Substring(1,1) == vowel1 ||
			    words.Substring(1,1) == vowel2 ||
			    words.Substring(1,1) == vowel3 ||
			    words.Substring(1,1) == vowel4 ||
			    words.Substring(1,1) == vowel5 ||
			    words.Substring(1,1) == vowel6 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,1);
				words=words.Remove(0,1);
				Console.WriteLine(words + cons + wordadd);
				
				}
			else if 
				(words.Substring(2,1) == vowel1 ||
			    words.Substring(2,1) == vowel2 ||
			    words.Substring(2,1) == vowel3 ||
			    words.Substring(2,1) == vowel4 ||
			    words.Substring(2,1) == vowel5 ||
			    words.Substring(2,1) == vowel6 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,2);
				words=words.Remove(0,2);
				Console.WriteLine(words + cons + wordadd);
				
				}
			else if 
				(words.Substring(3,1) == vowel1 ||
			    words.Substring(3,1) == vowel2 ||
			    words.Substring(3,1) == vowel3 ||
			    words.Substring(3,1) == vowel4 ||
			    words.Substring(3,1) == vowel5 ||
			    words.Substring(3,1) == vowel6 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,3);
				words=words.Remove(0,3);
				Console.WriteLine(words + cons + wordadd);
				
			}
			else if 
				(words.Substring(4,1) == vowel1 ||
			    words.Substring(4,1) == vowel2 ||
			    words.Substring(4,1) == vowel3 ||
			    words.Substring(4,1) == vowel4 ||
			    words.Substring(4,1) == vowel5 ||
			    words.Substring(4,1) == vowel6 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,4);
				words=words.Remove(0,4);
				Console.WriteLine(words + cons + wordadd);
			
		
				}
			else if 
				(words.Substring(5,1) == vowel1 ||
			    words.Substring(5,1) == vowel2 ||
			    words.Substring(5,1) == vowel3 ||
			    words.Substring(5,1) == vowel4 ||
			    words.Substring(5,1) == vowel5 ||
			    words.Substring(5,1) == vowel6 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,5);
				words=words.Remove(0,5);
				Console.WriteLine(words + cons + wordadd);
		
		
				}
			else if 
				(words.Substring(6,1) == vowel1 ||
			    words.Substring(6,1) == vowel2 ||
			    words.Substring(6,1) == vowel3 ||
			    words.Substring(6,1) == vowel4 ||
			    words.Substring(6,1) == vowel5 ||
			    words.Substring(6,1) == vowel6 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,6);
				words=words.Remove(0,6);
				Console.WriteLine(words + cons + wordadd);
		
		
				}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}