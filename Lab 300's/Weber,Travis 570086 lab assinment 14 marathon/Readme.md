Marathon Distance Converter
Project Description
This is a simple C# console application that demonstrates basic distance conversion by calculating the number of yards in a given distance.
Program Functionality
The program performs a simple mathematical calculation:

Converts a given distance (46,145 meters) to yards
Divides the total meters by the number of yards in a mile (1,760)
Displays the result of the conversion
Waits for a key press before closing

Technical Details

Created: November 9, 2015
Language: C#
Platform: .NET Framework 4.0
Development Environment: SharpDevelop

Code Breakdown
csharpCopyint m = 46145;           // Total distance in meters
int yards = 1760;        // Number of yards in a mile
Console.WriteLine(m/yards);  // Perform integer division
Calculation Explanation

Total distance: 46,145 meters
Yards per mile: 1,760
Result: 26.2 miles (standard marathon distance)
