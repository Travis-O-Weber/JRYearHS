Lab 609 Travis Weber
A C# console application that takes user input text and displays each word reversed with proper capitalization.
Description
This program:

Prompts the user to enter a phrase or sentence
Converts the input to lowercase
Reverses each individual word in the phrase
Applies proper title case formatting to the result
Displays the transformed text

How It Works
The program processes each word individually:

The input string is split into separate words
Each word is reversed character by character
The words are recombined with spaces
Title case formatting is applied to maintain proper capitalization

For example, if the user enters "Hello World":

Converts to lowercase: "hello world"
Reverses each word: "olleh dlrow"
Applies title case: "Olleh Dlrow"

Running the Program
Prerequisites

.NET Framework 4.0 or later
Visual Studio or another C# compatible IDE

Execution

Open the solution file (Lab 609 Travis Weber.sln) in Visual Studio
Build the solution (F6 or Ctrl+Shift+B)
Run the program (F5 or Ctrl+F5)
When prompted, enter a phrase or sentence
The program will display the text with each word reversed and properly capitalized

Project Structure

Program.cs - Contains the main program logic
Lab 609 Travis Weber.csproj - Project file
Lab 609 Travis Weber.sln - Solution file

Technical Details
The program uses the following C# features:

String manipulation methods (ToLower, Split)
Character arrays and string building
Foreach loops for iteration
System.Globalization.CultureInfo for proper text casing

csharp
// Core algorithm
string og = Console.ReadLine();
og = og.ToLower();
string strrev = "";

foreach (var word in og.Split(' '))
{
    string temp = " ";
    foreach (var ch in word.ToCharArray())
    {
        temp = ch + temp;
    }
    strrev = temp + strrev + " ";
}

string text = strrev;
string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
Console.WriteLine(result);
