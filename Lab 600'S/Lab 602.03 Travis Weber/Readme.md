Prime Number Checker
Overview
This repository contains three similar Windows Forms applications that check whether a number is prime or composite. The applications were created using SharpDevelop 5.1 and target the .NET Framework 4.0.
Versions
There are three versions of the application:

lab 602.0 Travis Weber - User control library with button click to trigger the primality check
lab 602.01 Travis Weber - User control library with label click (label2) to trigger the primality check
lab 602.03 Travis Weber - Standalone Windows Forms application with improved UI and input validation

Features

User-friendly interface with a text input field
Action control (button or label) to trigger the primality check
Display of result indicating whether the number is prime or composite
Input validation for negative numbers (v3 only)
Standalone executable (v3) or reusable control library (v1, v2)

How It Works

The user enters a number into the text field
Upon triggering the action (clicking the button in v1/v3 or clicking label2 in v2), the application:

Parses the input as an integer
In v3, validates that the number is positive
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
Version 3 (Lab 602.03)
The third version is a standalone application that includes input validation for negative numbers:
csharp
void Button1Click(object sender, EventArgs e)
{
    int testnum = int.Parse(textBox1.Text);
    int counter = 0;
    
    if (testnum <= 0){
        label2.Text = "That number can't be prime or composite";
    }
    else
    {
        for (int i = 2; i <= testnum; i++)
            if (testnum % i == 0)                        
                counter++;

        if (testnum != 1 && counter == 1)                 
            label2.Text = "you number is prime";
        else
            label2.Text = "your number is composite";
    }
}
UI Components
Versions 1 & 2 (User Controls)

Text Box: For number input
Button (v1): Triggers the primality check in version 1
Label2 (v2): Triggers the primality check in version 2 when clicked
Labels: Display the status and result

Version 3 (Standalone Application)

Text Box: For number input
Button: Labeled "Test number" - triggers the primality check
Label1: Contains instructions "Type a number to find out if it is prime or composite"
Label2: Displays the result
Form: Has a blue background color (MenuHighlight)

Build and Run
User Controls (v1 & v2)
To use either control:

Open the solution in Visual Studio or SharpDevelop
Build the project
Add the resulting DLL as a reference in another Windows Forms application
Add the control to your form from the toolbox

Standalone Application (v3)
To run the application:

Open the solution in Visual Studio or SharpDevelop
Build the project
Run the resulting executable

Implementation Issues and Improvements

User Interface:

In versions 1 and 2, the default label texts ("label1", "label2") should be replaced with more descriptive text
Version 3 has improved UI with descriptive label text and better button labeling


Code Duplication:

In version 2, there are two Label2Click event handlers defined, which would cause a compiler error
All versions have empty event handlers that could be removed


Input Validation:

Versions 1 and 2 don't validate the input before parsing it as an integer, which could cause runtime exceptions if non-numeric input is entered
Version 3 adds validation for negative numbers but still lacks validation for non-numeric input


Algorithm Efficiency:

All versions use the same primality check algorithm with O(n) time complexity
For large inputs, a more efficient algorithm like the Sieve of Eratosthenes could be implemented


Project Structure Evolution:

The progression from user control libraries (v1, v2) to a standalone application (v3) shows the development journey
Version 3 incorporates learnings from previous versions with improved UI and validation



Note
This is a simple educational project demonstrating basic primality checking in Windows Forms. The code appears to be from a learning exercise, as evident from the naming conventions and commented placeholder code. The three versions show progression in the development process, with each version building on the knowledge gained from the previous one.
