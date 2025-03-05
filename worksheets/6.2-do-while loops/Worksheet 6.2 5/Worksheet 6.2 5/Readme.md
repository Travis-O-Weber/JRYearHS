

# Worksheet 6.5 - Console Application  

## Overview  
This C# console application demonstrates mathematical operations within a `do-while` loop. The program starts with an initial integer value and continuously divides it by an incrementing counter until the value reaches `0`.  

## Functions and Logic  

### `Main(string[] args)`  
- **Prints** `"Hello World!"` to indicate the start of the program.  
- Initializes two integer variables:  
  - `value = 100` (starting number).  
  - `counter = 0` (incrementing divisor).  
- Uses a **do-while loop** to:  
  - Increment `counter` by `1`.  
  - Divide `value` by `counter`.  
  - Print the current `value`.  
  - Repeat the process until `value == 0`.  
- Prompts the user to press any key to exit.  

## Usage  
1. Compile and run the program.  
2. Observe the decreasing values of `value` as it is divided by an increasing counter.  
3. The program stops when `value` reaches `0`.  
4. Press any key when prompted to exit.  

## Future Enhancements  
- Implement input validation to prevent division by zero.  
- Allow the user to input custom starting values.  
