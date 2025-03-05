
# Worksheet 6.3 - String Manipulation Console Application  

## Overview  
This C# console application demonstrates string manipulation using the `Insert` method within a `do-while` loop. The program modifies a string by inserting the letter `"a"` at alternating positions until the counter reaches the string's length.

## Functions and Logic  

### `Main(string[] args)`  
- Initializes a string variable `word = "hominy"`.  
- Sets an integer counter `counter = 0`.  
- Uses a **do-while loop** to:  
  - Insert the letter `"a"` at position `counter` in the string.  
  - Increase `counter` by `2` after each insertion.  
  - Continue the loop while `counter < word.Length`.  
- Prompts the user to press any key to exit.  

## Usage  
1. Compile and run the program.  
2. Observe how the word `"hominy"` is modified with inserted `"a"` characters.  
3. Press any key when prompted to exit.  

## Future Enhancements  
- Allow the user to input a custom word for modification.  
- Improve logic to handle out-of-range insertions without errors.  

