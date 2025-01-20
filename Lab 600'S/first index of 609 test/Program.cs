/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/18/2016
 * Time: 3:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace first_index_of_609_test
{
	class Program
	{
		public static void Main(string[] args)
			{
			Console.WriteLine("Please type the word you want displayed backwards");
			string og = Console.ReadLine();
			og = og.ToLower();
 
            string first = og.IndexOf(0);

            foreach (var word in og.Split(' '))
            {
                string temp = " ";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = temp + strrev + " "; 
            }
            
            Console.WriteLine(strrev);
            Console.ReadLine();

			// TODO: Implement Functionality Here
			
			Console.ReadKey(true);
		}
	}
}