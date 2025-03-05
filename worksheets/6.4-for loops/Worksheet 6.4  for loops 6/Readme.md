

# Worksheet 6 - For Loop String Manipulation  

## Overview  
This C# console application demonstrates the use of a `for` loop to process and manipulate a string by iterating through its characters with a specific step size.  

## Functions and Logic  

### `Main(string[] args)`  
- **Prints** `"Hello World!"` to indicate the start of the program.  
- Initializes a string variable `phrase = "Clark Cougars Rock!"`.  
- Defines two integer variables:  
  - `begin = phrase.Length - 1` (starting index at the last character).  
  - `end = 0` (target ending index).  
- Uses a **for loop** to:  
  - Iterate from `begin` to `end`, increasing the index by `2` in each step.  
  - Extract and print a single character from `phrase` at each step using `Substring(i,1)`.  
- Prompts the user to press any key to exit.  

## Usage  
1. Compile and run the program.  
2. Observe how characters from `"Clark Cougars Rock!"` are printed based on the defined loop logic.  
3. Press any key when prompted to exit.  

## Issues  
- The loop condition `for(i = begin; i< end; i+=2)` contains an undeclared variable `i`, which will cause a compilation error.  
- The condition should be `i >= end` instead of `i < end` to correctly iterate backward.  

