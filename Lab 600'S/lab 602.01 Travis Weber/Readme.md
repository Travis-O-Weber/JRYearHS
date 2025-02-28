Prime Number Checker
Overview
This repository contains two similar Windows Forms user control applications that check whether a number is prime or composite. The applications were created using SharpDevelop 5.1 and target the .NET Framework 4.0.
Versions
There are two versions of the application:

lab 602.0 Travis Weber - Uses a button click to trigger the primality check
lab 602.01 Travis Weber - Uses a label click (label2) to trigger the primality check

Features

User-friendly interface with a text input field
Action control (button or label) to trigger the primality check
Display of result indicating whether the number is prime or composite

How It Works

The user enters a number into the text field
Upon triggering the action (clicking the button in v1 or clicking label2 in v2), the application:

Parses the input as an integer
Counts the number of divisors
Determines if the number is prime based on having exactly one divisor (itself)
Displays the result in a label



Technical Details

Programming Language: C#
Framework: .NET Framework 4.0
Development Environment: SharpDevelop 5.1
Component Type: Windows Forms User Control Library

Code Structure
Version 1 (lab 602.0)
The main functionality is contained in the UserControl1.cs file where the Button1Click event handler performs the primality check:
csharp
void Button1Click(object sender, EventArgs e)
{
    int testnum = int.Parse(textBox1.Text);
    int counter = 0;
    for (int i = 2; i <= testnum; i++)
        if (testnum % i == 0)                        
            counter++;

    if (testnum != 1 && counter == 1)                 
        label2.Text = "you number is prime";
    else
        label2.Text = "your number is composite";
}
Version 2 (lab 602.01)
In the second version, the same primality check logic is implemented but in the Label2Click event handler:
csharp
void Label2Click(object sender, EventArgs e)
{
    int testnum = int.Parse(textBox1.Text);
    int counter = 0;
    for (int i = 2; i <= testnum; i++)
        if (testnum % i == 0)                        
            counter++;

    if (testnum != 1 && counter == 1)                 
        label2.Text = "you number is prime";
    else
        label2.Text = "your number is composite";
}
UI Components

Text Box: For number input
Button (v1): Triggers the primality check in version 1
Label2 (v2): Triggers the primality check in version 2 when clicked
Labels: Display the status and result

Build and Run
To use either control:

Open the solution in Visual Studio or SharpDevelop
Build the project
Add the resulting DLL as a reference in another Windows Forms application
Add the control to your form from the toolbox

Implementation Issues and Improvements

User Interface: The default label texts ("label1", "label2") should be replaced with more descriptive text.
Code Duplication: In version 2, there are two Label2Click event handlers defined, which would cause a compiler error.
Input Validation: Neither version validates the input before parsing it as an integer, which could cause runtime exceptions if non-numeric input is entered.
Algorithm Efficiency: The primality check algorithm has O(n) time complexity, which is sufficient for small numbers but not optimized for large inputs. A more efficient algorithm like the Sieve of Eratosthenes could be implemented for better performance.
