/*
 * Created by SharpDevelop.
 * User: Travis
 * Date: 3/9/2016
 * Time: 10:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber__Travis_lab_507
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			// TODO: Implement Functionality Here
			
			
			Console.ReadKey(true);
		
			Console.WriteLine("Type the word you want to convert");
			string wordOG = Console.ReadLine();
			string words = wordOG.ToLower();
			int length = wordOG.Length ;
			
			string ub = "ub";
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			string vowel6 = "y";
			
			if 
				(wordOG.Substring(0,1) == vowel1 ||
			    wordOG.Substring(0,1) == vowel2 ||
			    wordOG.Substring(0,1) == vowel3 ||
			    wordOG.Substring(0,1) == vowel4 ||
			    wordOG.Substring(0,1) == vowel5 |
			    wordOG.Substring(0,1) == vowel6 )
			   
				{
				words = words.Insert(0,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			else if 
				(wordOG.Substring(1,1) == vowel1 ||
			    wordOG.Substring(1,1) == vowel2 ||
			    wordOG.Substring(1,1) == vowel3 ||
			    wordOG.Substring(1,1) == vowel4 ||
			    wordOG.Substring(1,1) == vowel5 ||
			    wordOG.Substring(1,1) == vowel6 )
	
				{
				words = words.Insert(1,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			else if 
				(wordOG.Substring(2,1) == vowel1 ||
			    wordOG.Substring(2,1) == vowel2 ||
			    wordOG.Substring(2,1) == vowel3 ||
			    wordOG.Substring(2,1) == vowel4 ||
			    wordOG.Substring(2,1) == vowel5 ||
			    wordOG.Substring(2,1) == vowel6 )
			
				{
				words = words.Insert(2,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			else if 
				(wordOG.Substring(3,1) == vowel1 ||
			    wordOG.Substring(3,1) == vowel2 ||
			    wordOG.Substring(3,1) == vowel3 ||
			    wordOG.Substring(3,1) == vowel4 ||
			    wordOG.Substring(3,1) == vowel5 ||
			    wordOG.Substring(3,1) == vowel6 )
			
				{
				words = words.Insert(3,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			else if 
				(wordOG.Substring(4,1) == vowel1 ||
			    wordOG.Substring(4,1) == vowel2 ||
			    wordOG.Substring(4,1) == vowel3 ||
			    wordOG.Substring(4,1) == vowel4 ||
			    wordOG.Substring(4,1) == vowel5 ||
			    wordOG.Substring(4,1) == vowel6 )
			
				{
				words = words.Insert(4,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			else if 
				(wordOG.Substring(5,1) == vowel1 ||
			    wordOG.Substring(5,1) == vowel2 ||
			    wordOG.Substring(5,1) == vowel3 ||
			    wordOG.Substring(5,1) == vowel4 ||
			    wordOG.Substring(5,1) == vowel5 ||
			    wordOG.Substring(5,1) == vowel6 )
		
				{
				words = words.Insert(5,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			else if 
				(wordOG.Substring(5,1) == vowel1 ||
			    wordOG.Substring(5,1) == vowel2 ||
			    wordOG.Substring(5,1) == vowel3 ||
			    wordOG.Substring(5,1) == vowel4 ||
			    wordOG.Substring(5,1) == vowel5 ||
			    wordOG.Substring(5,1) == vowel6 )
		
				{
				words = words.Insert(6,ub);
				Console.WriteLine("Your new word is");
				Console.WriteLine(words);
				}
			Console.ReadKey(true);
		}
	}
}