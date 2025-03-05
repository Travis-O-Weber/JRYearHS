# Worksheet 6.1.5 - Console Application

## Overview
This is a simple console application written in C# that demonstrates basic control flow using a `do-while` loop. The program starts with an integer counter set to `48` and continuously divides it by `3`, printing the value at each step until the counter is less than or equal to `1`.

## Functions and Logic
### `Main(string[] args)`
- **Prints** `"1."` to indicate the start of the program.
- Initializes an integer variable `counter = 48`.
- Uses a **do-while loop** to:
  - Print the current value of `counter`.
  - Divide `counter` by `3` at each iteration.
  - Repeat the process while `counter > 1`.
- Prompts the user to press any key to exit.

## Usage
1. Compile and run the program.
2. Observe the output values of `counter` as they decrease by a factor of `3`.
3. Press any key when prompted to exit.

## Future Enhancements
- Implement additional functionality as needed.
- Handle edge cases where the starting value may be different.
