# Speeding Ticket Calculator

## Project Overview
This console application calculates speeding ticket fines based on how much a driver exceeds the speed limit. The application prompts the user for the speed limit and the actual speed, then calculates and displays the appropriate fine.

## Main Function

The entire application logic is contained within the `Main` method in `Program.cs`:

```csharp
public static void Main(string[] args)
{
    // Prompt for speed limit
    Console.WriteLine("What is the speed limit?");
    double speedlimit = double.Parse(Console.ReadLine());
    
    // Prompt for actual speed
    Console.WriteLine("What is the speed you were going?");
    double speed = double.Parse(Console.ReadLine());
    
    // Calculate how much over the limit
    double speedlimitover = speed - speedlimit;
    
    // Determine and display the fine
    if (speedlimitover >= 0 && speedlimitover <= 10)
    {
        Console.WriteLine("$125.00");
    }
    else if (speedlimitover >= 11 && speedlimitover <= 15)
    {
        Console.WriteLine("$175.00");
    }
    else if (speedlimitover >= 16 && speedlimitover <= 20)
    {
        Console.WriteLine("$225.00");
    }
    else if (speedlimitover >= 21 && speedlimitover <= 25)
    {
        Console.WriteLine("$300.00");
    }
    else if (speedlimitover >= 25)
    {
        Console.WriteLine("$" + (((speedlimitover - 25) * 50) + 300));
    }
    
    // Wait for key press before exiting
    Console.ReadKey(true);
}
```

## Function Components

### 1. User Input Handling
The application prompts the user for two pieces of information:
- The speed limit on the road
- The actual speed the driver was traveling

```csharp
Console.WriteLine("What is the speed limit?");
double speedlimit = double.Parse(Console.ReadLine());

Console.WriteLine("What is the speed you were going?");
double speed = double.Parse(Console.ReadLine());
```

### 2. Excess Speed Calculation
The application calculates how much the driver exceeded the speed limit:

```csharp
double speedlimitover = speed - speedlimit;
```

### 3. Fine Determination
Based on the excess speed, the application determines the appropriate fine using a series of conditional statements:

```csharp
if (speedlimitover >= 0 && speedlimitover <= 10)
{
    Console.WriteLine("$125.00");
}
else if (speedlimitover >= 11 && speedlimitover <= 15)
{
    Console.WriteLine("$175.00");
}
// Additional tiers...
```

### 4. Dynamic Fine Calculation
For speeds more than 25 mph over the limit, the application uses a formula to calculate an escalating fine:

```csharp
else if (speedlimitover >= 25)
{
    Console.WriteLine("$" + (((speedlimitover - 25) * 50) + 300));
}
```

## Fine Structure

The application uses the following fine structure:
- 1-10 mph over: $125.00
- 11-15 mph over: $175.00
- 16-20 mph over: $225.00
- 21-25 mph over: $300.00
- 26+ mph over: $300.00 plus $50.00 for each mph over 25

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

## Technical Implementation
- Built with C# on .NET Framework 4.0
- Console application with standard input/output
- Uses `double.Parse()` for conversion of user input to numerical values
- Compiled for x86 platform

## Potential Improvements
1. Input validation to handle non-numeric entries
2. Handling negative speeds (when driver is below the speed limit)
3. Formatting the output for consistent decimal places
4. Adding unit tests to verify the calculation logic
