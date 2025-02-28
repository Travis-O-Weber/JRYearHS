GCD and LCM UserControl
Description
This is a Windows Forms UserControl project designed to calculate the Greatest Common Divisor (GCD) and Least Common Multiple (LCM) of two numbers.
Features

Calculate Greatest Common Divisor (GCD) of two numbers
Calculate Least Common Multiple (LCM) of two numbers
Implemented as a reusable .NET UserControl

Technical Details

Developed using C# and .NET Framework 4.0
Created on April 29, 2016
Part of a computer science lab assignment

Calculation Methods

GCD (Greatest Common Divisor):

Uses a subtraction-based algorithm to find the GCD
Iteratively reduces the two numbers until they are equal


LCM (Least Common Multiple):

Calculated using the formula: LCM(a,b) = (a * b) / GCD(a,b)



Requirements

.NET Framework 4.0
Windows operating system
Visual Studio (for development and compilation)

Usage
The UserControl provides methods to:
csharpCopyint GetGCD(int num1, int num2)    // Calculate Greatest Common Divisor
int GetLCM(int num1, int num2)    // Calculate Least Common Multiple
Note
This implementation contains some console-related code that appears to be remnants of testing and may not be fully functional in a UserControl context.
