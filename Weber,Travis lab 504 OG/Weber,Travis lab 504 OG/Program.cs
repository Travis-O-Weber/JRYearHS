/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 3/4/2016
 * Time: 2:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber_Travis_lab_504_OG
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("type the word you want to convert");
			string word2 = Console.ReadLine();
			string word = word2.ToLower();
			int lenght = word2.Length ;
			
			string izzle = "izzle";
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			string vowel6 = "y";
			
			
			if 
			
			   (word.LastIndexOf(vowel1) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel6)   )
			   
			   {
				word = (word.Remove( word.LastIndexOf(vowel1),(lenght-word.LastIndexOf(vowel1))));
			    string izzleword = word + izzle;
			    Console.WriteLine(izzleword);
			   }
			
			else if 
			
			   (word.LastIndexOf(vowel2) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel6)   )
			   
			   {
				word = (word.Remove( word.LastIndexOf(vowel2),(lenght-word.LastIndexOf(vowel2))));
			    string izzleword = word + izzle;
			    Console.WriteLine(izzleword); 
			   }
			
			else if 
			
			   (word.LastIndexOf(vowel3) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel6)   )
			   
			   {
				word = (word.Remove( word.LastIndexOf(vowel3),(lenght-word.LastIndexOf(vowel3))));
			    string izzleword = word + izzle;
			    Console.WriteLine(izzleword);
			   }
			
			else if 
			
			   (word.LastIndexOf(vowel4) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel6)   )
			   
			   {
				word = (word.Remove( word.LastIndexOf(vowel4),(lenght-word.LastIndexOf(vowel4))));
			    string izzleword = word + izzle;
			    Console.WriteLine(izzleword);
			   }
			else if 
			
			   (word.LastIndexOf(vowel5) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel6)   )
			   
			   {
				word = (word.Remove( word.LastIndexOf(vowel5),(lenght-word.LastIndexOf(vowel5))));
			    string izzleword = word + izzle;
			    Console.WriteLine(izzleword); 
			   }
			else if 
			
			   (word.LastIndexOf(vowel6) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel5)   )
			   
			   {
				word = (word.Remove( word.LastIndexOf(vowel5),(lenght-word.LastIndexOf(vowel5))));
			    string izzleword = word + izzle;
			    Console.WriteLine(izzleword);
			   }
			Console.ReadKey(true);
		}
	}
}