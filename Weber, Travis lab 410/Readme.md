# HiLo Game 

## Project Structure Overview
The game is built using Windows Forms, with two primary functions driving the game mechanics:
1. `Button1Click()` - Game Initialization
2. `Button2Click()` - Guess Evaluation

## Class-Level Variables
```csharp
int attempts = 0;      // Tracks number of guessing attempts
bool clicked = true;   // Manages game state and attempt counting
```

## 1. Game Initialization: `Button1Click()`
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
    random = tool.Next(1,1001);
    
    // Store the random number in a hidden label
    label6.Text = random.ToString();
}
```

### Function Breakdown
- **Purpose**: Prepare the game for a new round
- **Key Actions**:
  1. Reset UI elements
  2. Generate a random target number
  3. Store the target number

#### Detailed Analysis
- `label3.Text = ""`: Clears any previous game feedback
- `label2.Visible = true`: Shows game instructions
- `button2.Visible = true`: Enables the "Evaluate" button
- `textBox1.Visible = true`: Makes the input text box available
- `Random tool = new Random()`: Creates a random number generator
- `random = tool.Next(1,1001)`: Generates a random integer
  - Lower bound (1) is inclusive
  - Upper bound (1001) is exclusive
  - Effectively creates a number between 1 and 1000
- `label6.Text = random.ToString()`: Stores the random number in a hidden label

## 2. Guess Evaluation: `Button2Click()`
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

### Function Breakdown
- **Purpose**: Process and evaluate the player's guess
- **Key Actions**:
  1. Parse the random number and user's guess
  2. Track the number of attempts
  3. Provide feedback based on the guess
  4. Update the game state

#### Detailed Analysis
##### Parsing Inputs
- `int random = int.Parse(label6.Text)`: 
  - Retrieves the target number from the hidden label
  - Converts the stored string to an integer
- `int guess = int.Parse(textBox1.Text)`: 
  - Gets the player's input from the text box
  - Converts the input to an integer

##### Attempt Tracking
```csharp
if (clicked == true)
{
    attempts++;
}
```
- Uses `clicked` boolean to manage attempt counting
- Prevents additional attempts after a correct guess
- Increments `attempts` only during an active game state

##### Guess Evaluation Logic
- Three possible outcomes:
  1. **High Guess**:
     ```csharp
     if (guess > random)
     {
         label3.Visible = true;
         label3.Text = "You guessed high";
     }
     ```
     - Displays "You guessed high"
     - Helps player understand they need to guess lower

  2. **Low Guess**:
     ```csharp
     else if (guess < random)
     {
         label3.Visible = true;
         label3.Text = "You guessed low";
     }
     ```
     - Displays "You guessed low"
     - Helps player understand they need to guess higher

  3. **Correct Guess**:
     ```csharp
     else if (guess == random)
     {
         label2.Visible = true;
         label3.Text = "You guessed Correct"; 
         button2.Visible = true;
         textBox1.Visible = true;
         clicked = false;
     }
     ```
     - Displays "You guessed Correct"
     - Sets `clicked` to `false` to end the current game session

##### Attempts Display
```csharp
string att = attempts.ToString();
label5.Text = att; 
```
- Converts `attempts` to a string
- Updates the label to show the current number of attempts

## Unused Event Handlers
```csharp
void Label1Click(object sender, EventArgs e) { }
void Label2Click(object sender, EventArgs e) { }
void Label3Click(object sender, EventArgs e) { }
void Label4Click(object sender, EventArgs e) { }
void Label5Click(object sender, EventArgs e) { }
void TextBox1TextChanged(object sender, EventArgs e) { }
```
- Default event handlers created by Windows Forms designer
- Currently empty, but can be used to add future functionality

## Potential Improvements
1. **Input Validation**
   - Add error handling for non-numeric inputs
   - Validate input is within 1-1000 range
   ```csharp
   try 
   {
       int guess = int.Parse(textBox1.Text);
       if (guess < 1 || guess > 1000)
       {
           throw new ArgumentOutOfRangeException();
       }
   }
   catch (FormatException)
   {
       // Handle non-numeric input
   }
   catch (ArgumentOutOfRangeException)
   {
       // Handle out of range input
   }
   ```

2. **Game Reset Mechanism**
   - Add a method to fully reset the game state
   ```csharp
   void ResetGame()
   {
       attempts = 0;
       clicked = true;
       label3.Text = "";
       label5.Text = "0";
       // Additional reset logic
   }
   ```

3. **Enhanced Feedback**
   - Provide more detailed guidance
   - Add proximity hints (e.g., "You're getting warmer")

## Learning Objectives
- Event-driven programming
- State management
- Simple game logic implementation
- User interface interaction in Windows Forms

## Development Considerations
- Simple, straightforward implementation
- Demonstrates basic C# and Windows Forms concepts
- Provides a foundation for more complex game designs
