# C# Lab Projects Documentation

This repository contains two separate C# projects developed by Travis Weber:

1. Mall Madness Shopping Calculator (Lab 411)
2. Day of Week Calculator (Lab 414)

## Mall Madness Shopping Calculator (Lab 411)

### Project Overview
This Windows Forms application allows users to calculate shopping totals with tax from different mall locations.

### Form Components
The form contains:
- Radio buttons for selecting different mall locations (Ingram, La Cantera, Bandera Point)
- Text boxes for entering purchase amounts (CDs, jewelry, t-shirts)
- A Calculate button
- Display labels for subtotal, tax, and total

### Key Functions

#### Mall Selection Handlers
- `RadioButton1CheckedChanged`: Handles the selection of "Ingram" mall
- `RadioButton2CheckedChanged`: Handles the selection of "La Cantera" mall
- `RadioButton3CheckedChanged`: Handles the selection of "Bandera Point" mall

#### Input Field Handlers
- `TextBox1TextChanged`: Responds to changes in the CDs purchase field
- `TextBox2TextChanged`: Responds to changes in the jewelry purchase field
- `TextBox3TextChanged`: Responds to changes in the t-shirts purchase field

#### Calculation Handler
- `Button1Click`: Performs the calculation of subtotal, tax, and total when the "Calculate" button is clicked
  - This is the main function that likely includes tax rate logic for different mall locations
  - Updates the labels to display calculations

#### Application Entry Point
The `Program.cs` file contains the `Main` method which serves as the entry point for the application and launches the Windows Form.

## Day of Week Calculator (Lab 414)

### Project Overview
This console application takes a user's birth date and calculates the day of the week they were born using Zeller's Congruence algorithm.

### Functionality
1. The program prompts the user to input:
   - Day of birth
   - Month of birth
   - Year of birth
2. It performs calculations to determine the day of the week using the following formula:
   ```
   int a = ((14 - month)/12);
   year = (year-a);
   month = (month + (12*a) - 2);
   day = ((day + year + (year/4) - (year/100) + (year/400) + ((31*month) / 12))%7);
   ```
3. Based on the result (0-6), it outputs the corresponding day of the week the user was born on.

### Key Function
The program contains a single `Main` method that:
1. Collects user input
2. Performs the day of week calculation (Zeller's Congruence algorithm)
3. Uses conditional statements to convert the numeric result to the appropriate day name
4. Displays the result to the user

### Implementation Details
- The program uses `int.Parse()` to convert string input to integers
- The algorithm adjusts dates in January and February by treating them as months 13 and 14 of the previous year
- The final result is a number from 0 to 6 representing Sunday through Saturday
- The program includes proper input prompts and output formatting

## Setup and Requirements
Both projects:
- Were developed using SharpDevelop 5.1
- Target .NET Framework 4.0
- Are built with C# 
- Have configurations for both Debug and Release builds
