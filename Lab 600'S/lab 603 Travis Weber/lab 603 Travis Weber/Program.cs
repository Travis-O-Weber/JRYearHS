/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/29/2016
 * Time: 9:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lab_603_Travis_Weber
{
	class Program
	{
		static int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
 
                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num1;
        }
 
 
        static int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine("Type your numbers to find the GCD and LCM");
 
            Console.Write("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
 
            int gcd = GetGCD(a, b);
            int lcm = GetLCM(a, b);
 
            Console.WriteLine("\nGCD({0,4},{1,4}) = {2,6}", a, b, gcd);
            Console.WriteLine("\nLCM({0,4},{1,4}) = {2,6}", a, b, lcm);
		}
	}
}