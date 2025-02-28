Prime Number Generator
Project Description
This is a simple C# console application that generates prime numbers up to a user-specified limit.
Features

Prompts user to enter an upper limit
Identifies and prints all prime numbers within the specified range
Simple primality testing algorithm

How to Use

Run the application
When prompted, enter the upper limit for prime number generation
The program will display all prime numbers less than or equal to the entered limit

Program Logic
The program uses a basic primality testing approach:

Iterates through numbers from 2 to the user-specified limit
For each number, checks if it's divisible by any number less than itself
If no divisors are found, the number is considered prime and printed

Limitations

The primality testing method is not the most efficient for large numbers
The time complexity increases quadratically with the input limit

Development Details

Created on: 5/4/2016
Language: C#
Framework: .NET Framework 4.0
IDE: SharpDevelop 5.1

Example
Enter the limit: 20
Prime numbers: 2 3 5 7 11 13 17 19
Author
Travis Weber
