/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/19/2016
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab_610_Travis_Weber
{
	class Program
	{
		static void Main(string[] args)
        {
            string str, revstr;
            Console.WriteLine("Enter Any String to Know It is Palindrome or not");
            str = Console.ReadLine();
            char[] tempstr = str.ToCharArray();
            Array.Reverse(tempstr);
            revstr = new string(tempstr);
            bool caseignore = str.Equals(revstr, StringComparison.OrdinalIgnoreCase);
            if (caseignore == true)
            {
                Console.WriteLine(str + " is a palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrome");
            }
            Console.Read();
        }
    }
}