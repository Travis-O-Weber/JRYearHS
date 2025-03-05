# Console Ubbi Dubbi Converter

## Project Overview
This console application converts English words to Ubbi Dubbi, a playful language game where "ub" is inserted before each vowel sound in a word. For example, "hello" becomes "hubellubo".

## Main Function

The application's entire functionality is contained within the `Main` method in `Program.cs`. This function performs the following tasks:

```csharp
public static void Main(string[] args)
{
    // Wait for initial key press
    Console.ReadKey(true);
    
    // Prompt for user input
    Console.WriteLine("Type the word you want to convert");
    string wordOG = Console.ReadLine();
    
    // Process the input word
    string words = wordOG.ToLower();
    int length = wordOG.Length;
    
    // Define constants for conversion
    string ub = "ub";
    string vowel1 = "a";
    string vowel2 = "e";
    string vowel3 = "i";
    string vowel4 = "o";
    string vowel5 = "u";
    string vowel6 = "y";
    
    // Check for vowels at different positions and apply conversion
    if (wordOG.Substring(0,1) == vowel1 || /* other vowel checks */)
    {
        words = words.Insert(0,ub);
        Console.WriteLine("Your new word is");
        Console.WriteLine(words);
    }
    else if (wordOG.Substring(1,1) == vowel1 || /* other vowel checks */)
    {
        words = words.Insert(1,ub);
        Console.WriteLine("Your new word is");
        Console.WriteLine(words);
    }
    // Additional position checks...
    
    // Wait for final key press before exit
    Console.ReadKey(true);
}
```

## Function Components

### 1. User Input Handling
The application starts by waiting for an initial keypress, then prompts the user to enter a word:

```csharp
Console.ReadKey(true);
Console.WriteLine("Type the word you want to convert");
string wordOG = Console.ReadLine();
```

### 2. Word Processing
The input word is converted to lowercase for consistent processing:

```csharp
string words = wordOG.ToLower();
int length = wordOG.Length;
```

### 3. Vowel Detection
The application defines vowels and checks for their presence at different positions in the word:

```csharp
// Define vowels
string vowel1 = "a";
string vowel2 = "e";
string vowel3 = "i";
string vowel4 = "o";
string vowel5 = "u";
string vowel6 = "y";

// Check for vowel at position 0
if (wordOG.Substring(0,1) == vowel1 ||
    wordOG.Substring(0,1) == vowel2 ||
    wordOG.Substring(0,1) == vowel3 ||
    wordOG.Substring(0,1) == vowel4 ||
    wordOG.Substring(0,1) == vowel5 ||
    wordOG.Substring(0,1) == vowel6)
{
    // Process word that starts with a vowel
}
```

### 4. Ubbi Dubbi Conversion
When a vowel is detected, "ub" is inserted before it using the `Insert` method:

```csharp
words = words.Insert(position, ub);
```

### 5. Result Display
The converted word is displayed to the user:

```csharp
Console.WriteLine("Your new word is");
Console.WriteLine(words);
```

## How The Algorithm Works

The Ubbi Dubbi converter performs these steps:
1. Checks each position of the word sequentially (0-6)
2. At each position, determines if the character is a vowel (a, e, i, o, u, y)
3. When it finds a vowel, inserts "ub" before that vowel
4. Displays the modified word to the user
5. Exits the conditional chain after finding the first vowel

## Examples

Input: "cat"
- First vowel at position 1 ('a')
- Insert "ub" before 'a'
- Output: "cubat"

Input: "apple"
- First vowel at position 0 ('a')
- Insert "ub" before 'a'
- Output: "ubapple"

## Limitations

The current implementation:
1. Only processes the first vowel in the word (standard Ubbi Dubbi would insert "ub" before every vowel)
2. Can only handle words up to 7 characters long
3. Does not handle input validation or error cases
4. Has a logical error in the last conditional block (checking position 5 twice instead of position 6)

## Technical Implementation
- Built with C# on .NET Framework 4.0
- Console application with standard input/output
- Uses string manipulation methods (Substring, Insert, ToLower)
- Compiled for x86 platform
