

# Worksheet 6 - Reverse String Output  

## Overview  
This C# console application demonstrates the use of a `for` loop to iterate through a string in reverse order, printing one character at a time.  

## Functions and Logic  

### `Main(string[] args)`  
- **Prints** `"Hello World!"` to indicate the start of the program.  
- Initializes a string variable `phrase = "I love computer Science!"`.  
- Defines two integer variables:  
  - `begin = phrase.Length - 1` (starting index at the last character).  
  - `end = 0` (target ending index).  
- Uses a **for loop** to:  
  - Start at `begin` and decrement `i` until it reaches `end`.  
  - Extract and print a single character from `phrase` at each step using `Substring(i,1)`.  
- Prompts the user to press any key to exit.  

## Issues  
- The loop uses `for(i = begin; i >= end; i--)` but `i` is undeclared, causing a compilation error.  
- The variable `i` should be declared within the loop as `for(int i = begin; i >= end; i--)`.  

## Usage  
1. Compile and run the program.  
2. Observe how `"I love computer Science!"` is printed in reverse order, one character per line.  
3. Press any key when prompted to exit.  

## Future Enhancements  
- Fix the undeclared variable `i`.  
- Modify the program to print the reversed string in a single line instead of separate lines.  
- Allow user input for a custom phrase.  

