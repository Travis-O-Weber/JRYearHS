# Pig Latin Converter

## Project Overview
This Windows Forms application converts English words to Pig Latin based on standard Pig Latin rules. The user enters a word, and the application displays the converted version following Pig Latin transformation rules.

## Features
- Simple and intuitive user interface
- Real-time word conversion
- Handles words with up to 4 initial consonants
- Proper implementation of Pig Latin rules

## How It Works
Pig Latin is a language game where words are altered according to these rules:
1. For words beginning with consonant sounds, move all consonants before the first vowel to the end of the word and add "ay"
2. For words beginning with vowel sounds, simply add "ay" to the end

## Application Components

### User Interface
- Instruction label: "Please enter the word you want to convert"
- Input text box: For entering the English word
- Convert button: Initiates the conversion process
- Result label: Displays the converted Pig Latin word
- The application has a light purple background color for aesthetic appeal

### Key Functions

#### Word Conversion Logic
The main conversion occurs in the `Button1Click` method which:
1. Retrieves the input word from the text box
2. Converts the word to lowercase for consistent processing
3. Checks for vowels (a, e, i, o, u) at different positions to determine:
   - If the word starts with a vowel, it simply adds "ay" to the end
   - If the word starts with consonants, it moves all consonants before the first vowel to the end and adds "ay"
4. Supports words with up to 4 initial consonants (e.g., "scratchy" → "atchyscray")
5. Displays the result in the output label

#### Example Conversions
- "apple" → "appleay" (word starting with vowel)
- "cat" → "atcay" (word starting with 1 consonant)
- "school" → "oolschay" (word starting with 2 consonants)
- "string" → "ingstray" (word starting with 3 consonants)
- "scratch" → "atchscray" (word starting with 4 consonants)

## Technical Implementation
The application is built using:
- C# programming language
- .NET Framework 4.0
- Windows Forms for the user interface
- String manipulation methods (Substring, Remove, ToLower)
- Conditional logic to handle different word patterns

## Setup and Requirements
- Developed using SharpDevelop 5.1
- Targets .NET Framework 4.0
- The solution consists of standard C# project structure with:
  - MainForm.cs: Contains the application logic
  - MainForm.Designer.cs: Contains the UI component definitions
  - Program.cs: Contains the application entry point

## Future Enhancements
Potential improvements for the application could include:
- Handling sentences instead of just single words
- Adding support for special cases and exceptions in Pig Latin rules
- Implementing a history of converted words
- Adding the ability to convert from Pig Latin back to English
