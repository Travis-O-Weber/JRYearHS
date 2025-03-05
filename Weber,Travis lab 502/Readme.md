Here's a README.md file focusing on the functionality of the provided **Program.cs** file:  

---

## Weber Travis Lab 502 - Pig Latin Converter

### Overview
This is a simple **C# console application** that converts an input word into **Pig Latin** based on standard rules. The program processes a single word input from the user, determines the first vowel occurrence, and rearranges the letters accordingly.

---

### Features
- Accepts a single **word input** from the user.
- Converts the word into **Pig Latin** by:
  - Adding `"ay"` if the word starts with a **vowel**.
  - Moving **leading consonants** to the end before appending `"ay"`.
- Supports **both lowercase and uppercase inputs** by converting everything to lowercase.
- Waits for a key press before terminating.

---

### Functionality Breakdown
#### **Main Method (Program.cs)**
1. **Reads user input** and converts it to lowercase.
2. Defines:
   - `"ay"` suffix for Pig Latin conversion.
   - Vowel characters (`a, e, i, o, u, y`).
3. **Checks for vowels at different positions**:
   - If the word starts with a vowel → Append `"ay"` to the end.
   - If a vowel appears after one or more consonants → Move consonants before the vowel to the end, then append `"ay"`.
4. **Handles different consonant clusters** by iterating up to the 6th character.
5. Outputs the transformed word.

---

### Usage
1. Compile and run the program.
2. Enter a word when prompted.
3. View the Pig Latin translation.
4. Press any key to exit.

---

### Example Input/Output
#### **Input:**  
```
hello
```
#### **Output:**  
```
ellohay
```
---
#### **Input:**  
```
apple
```
#### **Output:**  
```
appleay
```

---

### Notes
- The program currently checks up to **6 leading consonants**. If a word starts with more, the behavior may be undefined.
- Does **not handle** spaces or multiple words.

---

### Future Improvements
- Support for **multiple words**.
- More **efficient handling** of consonants.
- Allow **punctuation and case preservation**.

---
