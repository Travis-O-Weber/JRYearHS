Prime Number Checker
A simple C# console application that checks if a number is prime.
Description
This program prompts the user to enter a number, and then determines if that number is prime or not. A prime number is a natural number greater than 1 that cannot be formed by multiplying two smaller natural numbers.
Project Versions
This repository contains two versions of the prime number checker:
Version 1 (lab 601 Travis Weber)

Simple implementation with minimal output
Displays only "prime" or "not prime"

Version 2 (lab 601.5 Travis Weber)

Enhanced user experience with clearer prompts
More descriptive output messages ("Your number is prime" or "Your number is composite")

How It Works

The program reads an integer input from the user
It counts the number of divisors the input number has (excluding 1)
If the number is greater than 1 and has exactly one divisor (itself), it is considered prime
The program outputs whether the number is prime or composite

Code Explanation
Both versions use the same algorithm to check for primality:

Count how many numbers between 2 and the input number can evenly divide the input (i.e., have a remainder of 0)
A prime number will have exactly one such divisor (itself)
Numbers with more divisors or the number 1 are not prime

Version 1 Code
csharp
using System;
namespace lab_601_Travis_Weber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int testnum = int.Parse(Console.ReadLine());
            int devisors = 0;
            
            for (int i = 2; i <= testnum; i++)
                if (testnum % i == 0)                        
                    devisors++;

            if (testnum != 1 && devisors == 1)                 
                Console.WriteLine("prime");
            else                          
                Console.WriteLine("not prime");
                
            Console.ReadKey(true);
        }
    }
}
Version 2 Code
csharp
using System;
namespace lab_601.__Travis_Weber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please type the number you want to know is prime or composite");
            
            int testnum = int.Parse(Console.ReadLine());
            int counter = 0;
            
            for (int i = 2; i <= testnum; i++)
                if (testnum % i == 0)                        
                    counter++;

            if (testnum != 1 && counter == 1)                 
                Console.WriteLine("Your number is prime");
            else
                Console.WriteLine("Your number is composite");
                
            Console.ReadKey(true);
        }
    }
}
Usage

Run either version of the program
For Version 2, you'll see a prompt asking for input
Enter a positive integer
The program will display whether the number is prime or composite
Press any key to exit the program
