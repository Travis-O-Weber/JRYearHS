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
    
    // Define constants
    string ub = "ub";
    string vowel1 = "a";
    string vowel2 = "e";
    string vowel3 = "i";
    string vowel4 = "o";
    string vowel5 = "u";
    string vowel6 = "y";
    string trigger = "hello";
    
    // Check for secret trigger word
    if (words == trigger)
    {
        // Activate Easter egg (shows hidden images and plays sound)
        // [Image visibility and sound playback code]
    }
    // Check for vowel at position 0
    else if (wordOG.Substring(0,1) == vowel1 ||
             wordOG.Substring(0,1) == vowel2 ||
             wordOG.Substring(0,1) == vowel3 ||
             wordOG.Substring(0,1) == vowel4 ||
             wordOG.Substring(0,1) == vowel5 |
             wordOG.Substring(0,1) == vowel6 )
    {
        words = words.Insert(0,ub);
        label4.Text = words;
    }
    // Additional checks for vowels at positions 1-6
    // [Similar code blocks for positions 1-6]
}
```

### Easter Egg Functionality
The application includes a hidden feature that activates when the user enters "hello":

```csharp
if (words == trigger)
{
    pictureBox1.Visible = true;
    pictureBox2.Visible = true;
    pictureBox3.Visible = true;
    pictureBox4.Visible = true;
    pictureBox5.Visible = true;
    pictureBox6.Visible = true;
    pictureBox7.Visible = true;
    pictureBox8.Visible = true;
    pictureBox9.Visible = true;
    
    startSoundPlayer.Play();
}
```

### Sound Player Implementation
The application includes audio functionality using the System.Media namespace:

```csharp
System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\legol\Documents\School stuff\Sound Effects - And His Name Is John Cena.wav");
```

### UI Event Handlers
The application includes various event handlers for UI elements:

```csharp
// Label click event handlers
void Label1Click(object sender, EventArgs e) { }
void Label2Click(object sender, EventArgs e) { }
void Label4Click(object sender, EventArgs e) { }

// PictureBox click event handlers
void PictureBox1Click(object sender, EventArgs e) { }
void PictureBox2Click(object sender, EventArgs e) { }
// [Additional PictureBox event handlers]

// TextBox change event handler
void TextBox1TextChanged(object sender, EventArgs e) { }
```

## Application Structure

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

### UI Components
The application's user interface includes:

- A title label: "Ubbi Dubbi Converter"
- An instruction label: "Type the Word You Want to Convert"
- A text box for entering words
- A button to trigger the conversion
- A label to display the converted word
- Hidden picture boxes used for the Easter egg feature
- A maroon background color for a distinctive look

## How Ubbi Dubbi Works

In Ubbi Dubbi, "ub" is inserted before each vowel sound in a word:
- "cat" → "cubbat"
- "dog" → "dubbog"
- "elephant" → "ubbellubephubant"

The algorithm checks each position in the word for vowels (a, e, i, o, u, y) and inserts "ub" before each one.

## Technical Implementation
- Built with C# on .NET Framework 4.0
- Uses Windows Forms for the user interface
- Implements string manipulation methods (Substring, Insert, ToLower)
- Includes the System.Media namespace for sound functionality
- Contains hidden multimedia elements as an Easter egg
