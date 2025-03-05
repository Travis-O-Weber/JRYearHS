

# Worksheet 6.4 - String Manipulation Console Application  

## Overview  
This C# console application demonstrates string manipulation using the `IndexOf` and `Remove` methods within a `do-while` loop. The program iteratively removes all occurrences of the letter `'e'` from a given word.

## Functions and Logic  

### `Main(string[] args)`  
- Initializes a string variable `word = "electrecety"`.  
- Uses a **do-while loop** to:  
  - Find the first occurrence of the letter `'e'` using `IndexOf('e')`.  
  - Remove that character using `Remove(eplace)`, where `eplace` is the index of `'e'`.  
  - Repeat the process until no more occurrences of `'e'` remain.  
- Prompts the user to press any key to exit.  

## Usage  
1. Compile and run the program.  
2. Observe how all occurrences of `'e'` are removed from the word `"electrecety"`.  
3. Press any key when prompted to exit.  

## Future Enhancements  
- Allow the user to input a custom word for modification.  
- Handle cases where the word does not contain the target character.  

