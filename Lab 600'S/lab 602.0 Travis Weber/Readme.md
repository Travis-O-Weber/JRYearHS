Prime Number Checker
Overview
This is a simple Windows Forms user control application that checks whether a number is prime or composite. The application was created using SharpDevelop 5.1 and targets the .NET Framework 4.0.
Features

User-friendly interface with a text input field
Button to trigger the primality check
Display of result indicating whether the number is prime or composite

How It Works

The user enters a number into the text field
Upon clicking the button, the application:

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
UI Components

Text Box: For number input
Button: Triggers the primality check
Labels: Display the status and result

Build and Run
To use this control:

Open the solution in Visual Studio or SharpDevelop
Build the project
Add the resulting DLL as a reference in another Windows Forms application
Add the control to your form from the toolbox

Note
This is a simple educational project demonstrating basic primality checking. The algorithm used has O(n) time complexity, which is sufficient for small numbers but not optimized for large inputs.
