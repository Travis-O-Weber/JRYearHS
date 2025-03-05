
# Worksheet 6 - Selective Character Output  

## Overview  
This C# console application demonstrates the use of a `for` loop to iterate through a string and selectively print characters at specific intervals.  

## Functions and Logic  

### `Main(string[] args)`  
- **Prints** `"Hello World!"` to indicate the start of the program.  
- Initializes a string variable `phrase = "Clark Cougars Rock!"`.  
- Defines two integer variables:  
  - `begin = 0` (starting index).  
  - `end = phrase.Length` (ending index).  
- Uses a **for loop** to:  
  - Iterate from `begin` to `end`, increasing `i` by `2` at each step.  
  - Extract and print every second character from `phrase` using `Substring(i,1)`.  
- Prompts the user to press any key to exit.  

## Issues  
- The loop uses `for(i = begin; i < end; i+=2)`, but `i` is undeclared, causing a compilation error.  
- The variable `i` should be declared within the loop as `for(int i = begin; i < end; i+=2)`.  

## Usage  
1. Compile and run the program.  
2. Observe the output where every second character from `"Clark Cougars Rock!"` is printed.  
3. Press any key when prompted to exit.  

## Future Enhancements  
- Fix the undeclared variable `i`.  
- Allow user input for a custom phrase.  
- Modify the step size dynamically based on user input.  

