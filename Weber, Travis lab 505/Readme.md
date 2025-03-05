# Name Game Song Generator

## Project Overview
This console application creates a personalized version of "The Name Game" song based on user input. The program takes a name, processes it according to the song's rules, and outputs the resulting lyrics.

## How It Works

### Core Functionality
The application follows these steps:
1. Prompts the user to enter a name
2. Processes the name according to "The Name Game" rules
3. Generates the song lyrics with the appropriate modifications
4. Displays the personalized song to the user

### Name Processing Rules
The program analyzes the structure of the input name to determine how to transform it for the song:

- If the name starts with a vowel (a, e, i, o, u, y), the program uses the full name in all parts of the song
- If the name starts with consonants, the program:
  - Identifies the position of the first vowel in the name
  - Removes all consonants before the first vowel
  - Uses this modified version of the name in the song verses

### Key Functions

#### Main Function
The `Main` method serves as the entry point and contains all the application logic:

```csharp
public static void Main(string[] args)
{
    // Prompt the user for input
    Console.WriteLine("Please type your name and prepare for dank song");
    
    // Process the name and generate song lyrics
    // [Detailed name processing logic]
    
    // Output the song verses
    // [Song output logic]
    
    // Wait for user key press before closing
    Console.ReadKey(true);
}
```

#### Name Processing Logic
The program identifies the position of the first vowel using a series of conditional checks:

```csharp
// Convert name to lowercase for consistent processing
name = name.ToLower();

// Check if the first letter is a vowel
if (name.Substring(0,1)==(vowel1) || 
    name.Substring(0,1)==(vowel2) ||
    // [additional vowel checks])
{
    // Name starts with vowel, use as-is
}
else if (name.Substring(1,1)==(vowel1) || 
         name.Substring(1,1)==(vowel2) ||
         // [additional vowel checks])
{
    // First vowel is at position 1, remove first consonant
    name2 = name.Remove(0,1);
    // [song output logic]
}
// [additional position checks continue up to position 6]
```

#### Song Generation
After processing the name, the program generates the song lyrics following "The Name Game" pattern:

```csharp
// For names beginning with vowels
Console.WriteLine(name+" "+name+" "+"Bo "+B+name);
Console.WriteLine("Banana Fana Fo "+F+name);
Console.WriteLine("Fe fi Mo "+M+name);
Console.WriteLine(name);

// For names beginning with consonants
Console.WriteLine(name+" "+name+" "+"Bo "+B+name2); // name2 is without initial consonants
Console.WriteLine("Banana Fana Fo "+F+name2);
Console.WriteLine("Fe fi Mo "+M+name2);
Console.WriteLine(name);
```

## Example Output

For a name like "Bob":
```
bob bob Bo Bob
Banana Fana Fo ob
Fe fi Mo ob
bob
```

For a name like "Amy":
```
amy amy Bo Amy
Banana Fana Fo Amy
Fe fi Mo Amy
amy
```

## Technical Implementation
- Built with C# on .NET Framework 4.0
- Console application with standard input/output
- Uses string manipulation methods (Substring, Remove, ToLower, ToUpper)
- Handles names with up to 6 initial consonants
- Includes 'y' as a potential vowel for more accurate name processing

## Setup and Requirements
- Developed using SharpDevelop 5.1
- Targets .NET Framework 4.0
- Compiled for x86 platform
