# HiLo Game - Function Breakdown

## Core Game Functions

### `Button1Click(event)`
```csharp
void Button1Click(object sender, EventArgs e)
{
    // Clear previous game state
    label3.Text = "";
    label2.Visible = true;
    button2.Visible = true;
    textBox1.Visible = true;

    // Generate a random number
    int random;
    Random tool = new Random();
    random = tool.Next(1, 1001);

    // Store the random number in a hidden label
    label6.Text = random.ToString();
}
```

#### Function Breakdown
- **Purpose**: Initialize a new game
- **Key Actions**:
  1. Reset UI elements
  2. Generate a random number between 1 and 1000
  3. Store the target number in a hidden label
- **Technical Details**:
  - Uses `Random.Next(1, 1001)` to generate number
  - Inclusive of 1, exclusive of 1001 (thus 1-1000 range)
  - Makes input elements visible
  - Clears previous game feedback

### `Button2Click(event)`
```csharp
void Button2Click(object sender, EventArgs e)
{
    // Convert stored random number and user guess to integers
    int random = int.Parse(label6.Text);
    int guess = int.Parse(textBox1.Text);

    // Increment attempts if game is active
    if (clicked == true)
    {
        attempts++;
    }

    // Evaluate the guess
    if (guess > random)
    {
        label3.Visible = true;
        label3.Text = "You guessed high";
    }
    else if (guess < random)
    {
        label3.Visible = true;
        label3.Text = "You guessed low";
    }
    else if (guess == random)
    {
        label2.Visible = true;
        label3.Text = "You guessed Correct"; 
        button2.Visible = true;
        textBox1.Visible = true;
        clicked = false;
    }

    // Update attempts display
    string att = attempts.ToString();
    label5.Text = att; 
}
```

#### Function Breakdown
- **Purpose**: Evaluate the player's guess
- **Key Actions**:
  1. Parse the random number and user guess
  2. Track number of attempts
  3. Provide feedback based on guess
  4. Update UI with guess result
- **Guess Evaluation Logic**:
  - If guess > random: "You guessed high"
  - If guess < random: "You guessed low"
  - If guess == random: "You guessed Correct"
- **State Management**:
  - Uses `clicked` boolean to manage game state
  - Updates `attempts` counter
  - Displays current attempt count

## Supporting Methods

### Unused Event Handlers
Several event handlers are present but empty:
```csharp
void Label1Click(object sender, EventArgs e) { }
void Label2Click(object sender, EventArgs e) { }
void Label3Click(object sender, EventArgs e) { }
void Label4Click(object sender, EventArgs e) { }
void Label5Click(object sender, EventArgs e) { }
void TextBox1TextChanged(object sender, EventArgs e) { }
```
These are default event handlers created by the Windows Forms designer, currently not implementing any specific functionality.

## Game State Variables

### Class-Level Variables
```csharp
int attempts = 0;       // Tracks number of guessing attempts
bool clicked = true;    // Manages game state and attempt counting
```

## Key Implementation Details

### Random Number Generation
- Uses `System.Random` class
- `.Next(1, 1001)` ensures a number between 1 and 1000
- Target number is stored in `label6` for tracking

### User Feedback Mechanism
- Uses `label3` to display guess feedback
- Provides immediate visual cues about the guess
- Guides player towards correct number

### Attempt Tracking
- `attempts` variable increments with each guess
- Displayed in `label5`
- Allows players to monitor their performance

## Potential Improvements
1. Add input validation
2. Implement maximum attempt limit
3. Add game restart functionality
4. Create more detailed feedback
5. Implement score tracking

## Development Insights
- Simple, straightforward game logic
- Demonstrates basic Windows Forms event handling
- Shows use of random number generation
- Illustrates basic UI interaction and state management
