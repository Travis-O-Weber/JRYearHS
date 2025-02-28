Store Decoration Cost Calculator
Overview
This C# console application calculates the total cost of store decorations including sales tax. It was developed as Worksheet 3.1 (Part 2) for a C# programming course.
How It Works
The program:

Defines prices for various decoration items:

Flowers: $3.00 each
Bells: $0.75 each
Ribbon: $2.75 per yard
Plastic footballs: $1.25 each


Uses an 8.25% sales tax rate
Prompts the user to input quantities for each item
Calculates the subtotal by multiplying each item's price by its quantity
Applies sales tax to the subtotal
Displays the final price (subtotal + tax)

User Interaction
When running the program, you'll be prompted to answer the following questions:
CopyHow Many Flowers?
How Many bells?
How Many yards of ribbon?
How Many plastic footballs?
After entering all quantities, the program will display the total cost with tax.
Project Files

Program.cs: Contains the main program logic with item prices, user prompts, and calculations
AssemblyInfo.cs: Assembly metadata information
app.config: Application configuration file
.csproj files: Project configuration files
Compiled outputs: .exe and .pdb files for running the program

Running the Application
To run the program:

Open the solution in SharpDevelop or Visual Studio
Build the solution
Run the application
Enter the requested quantities when prompted
View the calculated total price
Press any key to exit the program

Code Explanation
The program uses:

Fixed constant values for item prices and tax rate
Console input/output for user interaction
String parsing to convert user input to numerical values
Basic arithmetic operations to calculate costs
String concatenation for output formatting

Author
Travis Weber (Student ID: 570086)
