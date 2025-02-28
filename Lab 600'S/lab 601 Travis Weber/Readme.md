Prime Number Checker
A simple C# console application that checks if a number is prime.
Description
This program prompts the user to enter a number, and then determines if that number is prime or not. A prime number is a natural number greater than 1 that cannot be formed by multiplying two smaller natural numbers.
How It Works

The program reads an integer input from the user
It counts the number of divisors the input number has (excluding 1)
If the number is greater than 1 and has exactly one divisor (itself), it is considered prime
The program outputs "prime" or "not prime" based on this determination

Code Explanation
The program uses a simple algorithm to check for primality:

It counts how many numbers between 2 and the input number can evenly divide the input (i.e., have a remainder of 0)
A prime number will have exactly one such divisor (itself)
Numbers with more divisors or the number 1 are not prime

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
Usage

Run the program
Enter a positive integer when prompted
The program will display whether the number is prime or not
Press any key to exit the program
