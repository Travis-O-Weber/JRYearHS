/*
 * Created by SharpDevelop.
 * User: Travis
 * Date: 3/3/2016
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Weber__Travis_lab_504
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please type your name and prepare for dank song");
			
			string name = Console.ReadLine();
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			string vowel6 = "y";
			string first;
			
			
			string name2;
			string name3;
			string name4;
			string B = "B";
		    string F = "F";
		    string M = "M";
		    
		    
		    
			
		    name = name.ToLower();
			
			int nameL = name.Length;
			
			if (name.Substring(0,1)==(vowel1)||
			    name.Substring(0,1)==(vowel2)||
			    name.Substring(0,1)==(vowel3)||
			    name.Substring(0,1)==(vowel4)||
			    name.Substring(0,1)==(vowel5)||
			    name.Substring(0,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,1);
				name4 = name.Remove(0,1);
				first = first.ToUpper();
				name3 = first+name2;
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name);
				Console.WriteLine("Banana Fana Fo "+F+name);
				Console.WriteLine("Fe fi Mo "+M+name);
				Console.WriteLine(name);
			}
			
			else if  
				(name.Substring(1,1)==(vowel1)||
			    name.Substring(1,1)==(vowel2)||
			    name.Substring(1,1)==(vowel3)||
			    name.Substring(1,1)==(vowel4)||
			    name.Substring(1,1)==(vowel5)||
			    name.Substring(1,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,1);
				first = first.ToUpper();
				name3 = first+name2;
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name2);
				Console.WriteLine("Banana Fana Fo "+F+name2);
				Console.WriteLine("Fe fi Mo "+M+name2);
				Console.WriteLine(name);
			}
			
			else if  
				(name.Substring(2,1)==(vowel1)||
			    name.Substring(2,1)==(vowel2)||
			    name.Substring(2,1)==(vowel3)||
			    name.Substring(2,1)==(vowel4)||
			    name.Substring(2,1)==(vowel5)||
			    name.Substring(2,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,2);
				first = first.ToUpper();
				name3 = first+name2;
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name2);
				Console.WriteLine("Banana Fana Fo "+F+name2);
				Console.WriteLine("Fe fi Mo "+M+name2);
				Console.WriteLine(name);
			}
			
			else if  
				(name.Substring(3,1)==(vowel1)||
			    name.Substring(3,1)==(vowel2)||
			    name.Substring(3,1)==(vowel3)||
			    name.Substring(3,1)==(vowel4)||
			    name.Substring(3,1)==(vowel5)||
			    name.Substring(3,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,3);
				first = first.ToUpper();
				name3 = first+name2;
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name2);
				Console.WriteLine("Banana Fana Fo "+F+name2);
				Console.WriteLine("Fe fi Mo "+M+name2);
				Console.WriteLine(name);
			}
			
			else if  
				(name.Substring(4,1)==(vowel1)||
			    name.Substring(4,1)==(vowel2)||
			    name.Substring(4,1)==(vowel3)||
			    name.Substring(4,1)==(vowel4)||
			    name.Substring(4,1)==(vowel5)||
			    name.Substring(4,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,4);
				first = first.ToUpper();
				name3 = first+name2;
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name2);
				Console.WriteLine("Banana Fana Fo "+F+name2);
				Console.WriteLine("Fe fi Mo "+M+name2);
				Console.WriteLine(name);
			}
			
			else if  
				(name.Substring(5,1)==(vowel1)||
			    name.Substring(5,1)==(vowel2)||
			    name.Substring(5,1)==(vowel3)||
			    name.Substring(5,1)==(vowel4)||
			    name.Substring(5,1)==(vowel5)||
			    name.Substring(5,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,5);
				first = first.ToUpper();
				name3 = first+name2;
				name = Console.ReadLine();
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name2);
				Console.WriteLine("Banana Fana Fo "+F+name2);
				Console.WriteLine("Fe fi Mo "+M+name2);
				Console.WriteLine(name);
			}
			else if  
				(name.Substring(6,1)==(vowel1)||
			    name.Substring(6,1)==(vowel2)||
			    name.Substring(6,1)==(vowel3)||
			    name.Substring(6,1)==(vowel4)||
			    name.Substring(6,1)==(vowel5)||
			    name.Substring(6,1)==(vowel6))
			
			{
			
				first = name.Substring(0,1);
				name2 = name.Remove(0,6);
				first = first.ToUpper();
				name3 = first+name2;
			
				Console.WriteLine(name+" "+name+" "+"Bo "+B+name2);
				Console.WriteLine("Banana Fana Fo "+F+name2);
				Console.WriteLine("Fe fi Mo "+M+name2);
				Console.WriteLine(name);
			}
		
			// TODO: Implement Functionality Here
			
			
			Console.ReadKey(true);
		}
	}
}