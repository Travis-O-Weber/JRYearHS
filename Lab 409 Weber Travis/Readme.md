Lab 409 Weber Travis - Payroll Calculator
Application Overview
This is a simple Windows Forms application designed to calculate an employee's total pay based on hours worked, hourly rate, and tax exemption status.
Features

Input hours worked
Input base hourly pay rate
Select tax exemption status
Calculate total pay with tax considerations

User Interface
The application provides a straightforward interface with the following components:

Text input for hours worked
Text input for base hourly pay
Radio buttons for tax exemption status (Yes/No)
Calculate button
Display of total pay

Calculation Logic

For tax-exempt employees (Yes):

Total pay = Hours worked * Hourly rate
No tax deduction


For non-tax-exempt employees (No):

Total pay = (Hours worked * Hourly rate) - Tax
Tax rate is 11% of gross pay



Technical Details

Developed using C# and .NET Framework 4.0
Windows Forms application
Created on February 8, 2016
Developed in SharpDevelop 5.1

How to Use

Enter the number of hours worked
Enter the base hourly pay rate
Select your tax exemption status
Click "Calculate"
View your total pay in the displayed result

Limitations

Does not handle complex tax calculations
Simplified tax exemption model
Requires manual input of hours and rate
