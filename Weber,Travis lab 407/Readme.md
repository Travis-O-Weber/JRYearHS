# Go Fast Program

## Project Overview
The Go Fast Program is a Windows Forms application that calculates speeding ticket fines based on how much a driver exceeds the speed limit. Users input the speed limit and the driver's actual speed, and the application calculates and displays the appropriate fine.

## Key Functions

### UI Event Handlers

#### Button Click Handler
The primary function that drives the application logic is the `Button1Click` method, which executes when the user clicks the "Calculate" button:

```csharp
void Button1Click(object sender, EventArgs e)
{
    // Parse input values from text boxes
    double speedlimit = double.Parse(textBox1.Text);
    double speed = double.Parse(textBox2.Text);
    
    // Calculate how much over the limit
    double speedlimitover = speed - speedlimit;
    
    // Determine and display the fine based on excess speed
    if (speedlimitover >= 0 && speedlimitover <= 10)
    {
        label5.Text = "$125.00";
    }
    else if (speedlimitover >= 11 && speedlimitover <= 15)
    {
        label5.Text = "$175.00";
    }
    else if (speedlimitover >= 16 && speedlimitover <= 20)
    {
        label5.Text = "$225.00";
    }
    else if (speedlimitover >= 21 && speedlimitover <= 25)
    {
        label5.Text = "$300.00";
    }
    else if (speedlimitover >= 25)
    {
        label5.Text = "$" + (((speedlimitover - 25) * 50) + 300);
    }
}
```

#### Input Field Handlers
The application includes event handlers for text box input changes:

```csharp
void TextBox1TextChanged(object sender, EventArgs e)
{
    // Event handler for speed limit text box
}

void TextBox2TextChanged(object sender, EventArgs e)
{
    // Event handler for actual speed text box
}
```

These handlers are currently empty but could be expanded to implement input validation or real-time calculations.

#### Other UI Element Handlers
The application includes event handlers for various label clicks and form load:

```csharp
void Label1Click(object sender, EventArgs e) { }
void Label2Click(object sender, EventArgs e) { }
void Label3Click(object sender, EventArgs e) { }
void MainFormLoad(object sender, EventArgs e) { }
```

These handlers are currently empty but could be expanded to add interactive features.

### Application Entry Point
The `Main` method in `Program.cs` serves as the entry point:

```csharp
[STAThread]
private static void Main(string[] args)
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new MainForm());
}
```

## Fine Calculation Logic

The application implements a tiered fine structure:
- 1-10 mph over: $125.00
- 11-15 mph over: $175.00
- 16-20 mph over: $225.00
- 21-25 mph over: $300.00
- 26+ mph over: $300.00 plus $50.00 for each mph over 25

For speeds more than 25 mph over the limit, the application uses the formula:
```
Fine = $300 + ($50 × (speed_over_limit - 25))
```

## UI Components

The application features a clean, user-friendly interface with:
- A title label: "Go Fast Program"
- Input fields for speed limit and actual speed
- A "Calculate" button
- Output labels to display the fine amount
- The fine amount is displayed in red for emphasis

## Technical Implementation

- Built with C# on .NET Framework 4.0
- Uses Windows Forms for the user interface
- Implements event-driven programming
- Performs calculations using double-precision floating-point values
- Uses conditional logic to determine the appropriate fine
- Uses string formatting to display monetary values

## Examples

Here are some examples of how the fines are calculated:

1. **Speed limit: 55 mph, Actual speed: 60 mph**
   - 5 mph over the limit
   - Fine: $125.00

2. **Speed limit: 35 mph, Actual speed: 48 mph**
   - 13 mph over the limit
   - Fine: $175.00

3. **Speed limit: 65 mph, Actual speed: 100 mph**
   - 35 mph over the limit
   - 35 - 25 = 10 mph beyond the highest tier
   - Fine: $300 + (10 × $50) = $800.00

## Potential Improvements

1. Input validation to handle non-numeric entries
2. Handling negative speeds (when driver is below the speed limit)
3. Formatting the output for consistent decimal places
4. Adding unit tests to verify the calculation logic
5. Implementing the empty event handlers for additional functionality
