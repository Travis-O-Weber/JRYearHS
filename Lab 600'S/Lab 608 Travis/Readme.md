Lab 608 Travis
A simple C# console application that calculates the average of numbers from 1 to a user-specified value.
Description
This program:

Prompts the user to enter a number
Calculates the sum of all integers from 1 up to the entered number
Calculates the average of those numbers
Displays the result to the user

How It Works
The program uses a while loop to iterate from 1 to the user's input value, adding each number to a running sum. Once all numbers have been summed, it divides the total by the input value to calculate the average.
For example, if the user enters 5:

The program sums: 1 + 2 + 3 + 4 + 5 = 15
Then calculates the average: 15 ÷ 5 = 3

Running the Program
Prerequisites

.NET Framework 4.0 or later
Visual Studio or another C# compatible IDE

Execution

Open the solution file (Lab 608 Travis.sln) in Visual Studio
Build the solution (F6 or Ctrl+Shift+B)
Run the program (F5 or Ctrl+F5)
When prompted, enter a number
The program will display the average of all integers from 1 to your input

Project Structure

Program.cs - Contains the main program logic
Lab 608 Travis.csproj - Project file
Lab 608 Travis.sln - Solution file

Technical Details
The program is written in C# and targets the .NET Framework 4.0. It uses basic console input/output and arithmetic operations.
csharp
// Core algorithm
double counter = 0; 
double fin = 0;
            
double test = double.Parse(Console.ReadLine());
while (counter < test)
{
    counter++;
    fin = fin + counter;
}
double limit = fin/test;
Console.WriteLine("The average is " + limit);
