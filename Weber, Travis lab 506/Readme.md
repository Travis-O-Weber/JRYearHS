# Ubbi Dubbi Converter

## Project Overview
This Windows Forms application converts English words to Ubbi Dubbi, a playful language game where "ub" is inserted before each vowel sound in a word. For example, "hello" becomes "hubellubo".

## Key Functions

### Word Conversion Logic
The primary function of this application is in the `Button1Click` method, which:

1. Retrieves the input text from the text box
2. Converts it to lowercase for consistent processing
3. Identifies vowel positions in the word
4. Inserts "ub" before each vowel
5. Displays the converted word

```csharp
void Button1Click(object sender, EventArgs e)
{
    // Get the original word and convert to lowercase
    string wordOG = (textBox1.Text);
    string words = wordOG.ToLower();
    int length = wordOG.Length;
    
    // Define constants
    string ub = "ub";
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
        wordOG.Substring(0,1) == vowel5 |
        wordOG.Substring(0,1) == vowel6 )
    {
        words = words.Insert(0,ub);
        label4.Text = words;
    }
    // Check for vowel at position 1
    else if (wordOG.Substring(1,1) == vowel1 ||
             wordOG.Substring(1,1) == vowel2 ||
             wordOG.Substring(1,1) == vowel3 ||
             wordOG.Substring(1,1) == vowel4 ||
             wordOG.Substring(1,1) == vowel5 ||
             wordOG.Substring(1,1) == vowel6 )
    {
        words = words.Insert(1,ub);
        label4.Text = words;
    }
    // Additional position checks continue for positions 2-6
}
```

### Vowel Detection
The application treats the following characters as vowels:
- a, e, i, o, u, y

For each position in the input word, the program checks if that character is a vowel using conditional statements:

```csharp
if (wordOG.Substring(position,1) == vowel1 ||
    wordOG.Substring(position,1) == vowel2 ||
    wordOG.Substring(position,1) == vowel3 ||
    wordOG.Substring(position,1) == vowel4 ||
    wordOG.Substring(position,1) == vowel5 ||
    wordOG.Substring(position,1) == vowel6 )
{
    // Insert "ub" at this position
}
```

### String Manipulation
The program uses two key string manipulation methods:
1. `Substring()` - To extract individual characters from the word
2. `Insert()` - To add "ub" before vowels at specific positions

```csharp
// Example of string manipulation
words = words.Insert(position, ub);
```

### UI Event Handlers
The application includes various event handlers for UI elements:

```csharp
// Label click event handlers
void Label1Click(object sender, EventArgs e) { }
void Label2Click(object sender, EventArgs e) { }
void Label4Click(object sender, EventArgs e) { }

// TextBox change event handler
void TextBox1TextChanged(object sender, EventArgs e) { }
```

### Main Function
The application's entry point is in the `Program.cs` file:

```csharp
[STAThread]
private static void Main(string[] args)
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new MainForm());
}
```

## How Ubbi Dubbi Works

In Ubbi Dubbi, "ub" is inserted before each vowel sound in a word:
- "cat" → "cubat" (inserts "ub" before the 'a')
- "dog" → "dubog" (inserts "ub" before the 'o')
- "apple" → "ubapple" (inserts "ub" before the initial 'a')

The algorithm identifies the first vowel in the word and inserts "ub" before it. The current implementation only handles the first vowel in a word, making this a simplified version of the Ubbi Dubbi language game.

## Algorithm Limitations

The current implementation:
1. Only processes the first vowel in the word
2. Can only handle words up to 7 characters long
3. Does not handle multiple vowels in a word (full Ubbi Dubbi would insert "ub" before each vowel)

## UI Components
The application's user interface includes:

- A title label: "Ubbi Dubbi Converter"
- An instruction label: "Type the Word You Want to Convert"
- A text box for entering words
- A button to trigger the conversion
- A label to display the converted word
- A maroon background color for a distinctive look

## Technical Implementation
- Built with C# on .NET Framework 4.0
- Uses Windows Forms for the user interface
- Implements string manipulation methods (Substring, Insert, ToLower)
- Handles words with up to 7 characters
