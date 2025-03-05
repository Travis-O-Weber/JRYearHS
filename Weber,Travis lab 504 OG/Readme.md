## Weber Travis Lab 504 - "Izzle" Converter

### Overview
This **C# console application** modifies an input word by replacing its last vowel and everything after it with the suffix `"izzle"`. The program determines the last occurrence of a vowel and performs the transformation.

---

### Features
- **Accepts a single word input** from the user.
- **Finds the last vowel** in the word.
- **Removes** everything from the last vowel onward.
- **Appends** the suffix `"izzle"` to the modified word.
- Waits for a **key press** before exiting.

---

### Functionality Breakdown

#### **Main Method (Program.cs)**
1. **Prompts the user** to enter a word.
2. **Converts the word to lowercase** for uniform processing.
3. **Defines vowels** (`a, e, i, o, u, y`).
4. **Finds the last occurrence of any vowel**.
5. **Removes characters from the last vowel onward**.
6. **Appends `"izzle"`** to the remaining part of the word.
7. **Displays the transformed word**.
8. Waits for a key press before exiting.

---

### Usage
1. Compile and run the program.
2. Enter a **word** when prompted.
3. View the **transformed output**.
4. Press any key to exit.

---

### Example Input/Output

#### **Input:**
```
example
```
#### **Output:**
```
examizzle
```
---
#### **Input:**
```
coding
```
#### **Output:**
```
codizzle
```

---

### Notes
- If a word contains **no vowels**, the program will not modify it.
- The program **only works with single words** and does not support sentences.
- If the last character is a vowel, the entire word before that vowel remains.

---

### Future Improvements
- Support for **multi-word phrases**.
- Handle **punctuation and case preservation**.
- Improve **efficiency** by avoiding repetitive `LastIndexOf` calls.

