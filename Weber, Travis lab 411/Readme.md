# Mall Madness Shopping Calculator

## Project Overview
This Windows Forms application called "Mall Madness" allows users to calculate shopping totals with tax from different mall locations.

## Form Components
The form contains:
- Radio buttons for selecting different mall locations (Ingram, La Cantera, Bandera Point)
- Text boxes for entering purchase amounts (CDs, jewelry, t-shirts)
- A Calculate button
- Display labels for subtotal, tax, and total

## Key Functions

### Event Handlers

#### Mall Selection Handlers
- `RadioButton1CheckedChanged`: Handles the selection of "Ingram" mall
- `RadioButton2CheckedChanged`: Handles the selection of "La Cantera" mall
- `RadioButton3CheckedChanged`: Handles the selection of "Bandera Point" mall

#### Input Field Handlers
- `TextBox1TextChanged`: Responds to changes in the CDs purchase field
- `TextBox2TextChanged`: Responds to changes in the jewelry purchase field
- `TextBox3TextChanged`: Responds to changes in the t-shirts purchase field

#### Calculation Handler
- `Button1Click`: Performs the calculation of subtotal, tax, and total when the "Calculate" button is clicked
  - This is the main function that likely includes tax rate logic for different mall locations
  - Updates the labels to display calculations

#### Label Click Handlers
- `Label1Click`: Handles clicks on the title label
- `Label2Click`: Handles clicks on the CDs label
- `Label3Click`: Handles clicks on the jewelry label
- `Label4Click`: Handles clicks on the t-shirts label
- `Label5Click`: Handles clicks on the subtotal label
- `Label6Click`: Handles clicks on the tax label
- `Label7Click`: Handles clicks on the total label
- `Label8Click`: Handles clicks on the subtotal result label
- `Label9Click`: Handles clicks on the tax result label

## Application Entry Point
The `Program.cs` file contains the `Main` method which serves as the entry point for the application:
```csharp
[STAThread]
private static void Main(string[] args)
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new MainForm());
}
```

## Setup
The form's initialization is handled by the auto-generated `InitializeComponent()` method which sets up all controls, their properties, and connects event handlers.

## Implementation Note
The implementation of these event handlers is not included in the provided code files. The actual calculation logic and response to user interactions would be found in the `MainForm.cs` file.
