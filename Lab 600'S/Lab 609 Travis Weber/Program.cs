/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/18/2016
 * Time: 12:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;

namespace Lab_609_Travis_Weber
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please type the word you want displayed backwards");
			string og = Console.ReadLine();
			og = og.ToLower();
            string strrev = "";

            foreach (var word in og.Split(' '))
            {
                string temp = " ";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = temp + strrev + " "; 
            }
            
  
            
            string text = strrev;
			string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);

			
            Console.WriteLine(result);
            
			// TODO: Implement Functionality Here
			
			Console.ReadKey(true);
		}
	}
}