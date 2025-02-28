GCD and LCM Calculator
Project Description
This is a simple C# console application that calculates the Greatest Common Divisor (GCD) and Least Common Multiple (LCM) of two user-input numbers.
Features

Calculate Greatest Common Divisor (GCD) of two numbers
Calculate Least Common Multiple (LCM) of two numbers
Interactive console-based interface

How to Use

Run the application
When prompted, enter the first number
Enter the second number
The program will display:

The GCD of the two numbers
The LCM of the two numbers



Methods
GetGCD

Uses the Euclidean algorithm to find the Greatest Common Divisor
Repeatedly subtracts the smaller number from the larger number until they are equal

GetLCM

Calculates the Least Common Multiple using the formula:
LCM(a,b) = (a * b) / GCD(a,b)

Development Details

Created on: 4/29/2016
Language: C#
Framework: .NET Framework 4.0
IDE: SharpDevelop 5.1

Example
Type your numbers to find the GCD and LCM
Enter First Number: 24
Enter Second Number: 36

GCD(  24,  36) =      12
LCM(  24,  36) =     72
Author
Travis Weber
