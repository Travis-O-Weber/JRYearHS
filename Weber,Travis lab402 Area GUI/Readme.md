# **Weber Travis Lab 402 - Area Calculator GUI**

## **Overview**
This is a **Windows Forms (GUI) application** built with C# that allows users to **calculate the area of different shapes** using an interactive interface. The user can select a shape (Circle, Triangle, or Rectangle), input the required dimensions, and view the calculated area.

---

## **Features**
- **Graphical User Interface (GUI)**
- Allows users to select **Circle, Triangle, or Rectangle**.
- Takes **user input** for the required dimensions.
- Performs **area calculations** based on the selected shape.
- Displays the **calculated result** in the GUI.
- Uses **event-driven programming** for UI interactions.

---

## **Functionality Breakdown**

### **1. Program Entry Point - `Program.cs`**
- **Initializes the application** using `Application.Run(new MainForm());`
- **Loads the `MainForm` GUI**, which serves as the user interface.

---

### **2. GUI Main Window - `MainForm.cs`**
#### **Key Functions:**
- `Button1Click()` - Handles the "Next" button to reveal the input fields for the selected shape.
- `Button2Click()` - Performs the area calculation based on user input and updates the result label.
- `RadioButton1CheckedChanged()`, `RadioButton2CheckedChanged()`, `RadioButton3CheckedChanged()` - Show/hide relevant input fields when selecting **Circle, Triangle, or Rectangle**.

#### **Area Calculation Logic:**
- **Circle:** `Area = π * r²`
- **Triangle:** `Area = (Base * Height) / 2`
- **Rectangle:** `Area = Length * Width`

---

### **3. Windows Form Designer - `MainForm.Designer.cs`**
- Defines UI components:
  - **Radio buttons** for shape selection.
  - **Textboxes** for input.
  - **Labels** for displaying results.
  - **Buttons** for user interaction.
- Controls the **layout and appearance** of the GUI.

---

### **4. Windows Service - `Weber,Travis lab402 Area GUI.cs`**
- Implements a **Windows Service** that manages system-level operations.
- **`OnStart()`** - Placeholder function to start the service.
- **`OnStop()`** - Placeholder function to stop the service.

---

### **5. Installer Configuration - `ProjectInstaller.cs`**
- **Handles installation setup** for the Windows Service.
- Registers the service under the name `"Weber,Travis lab402 Area GUI"`.
- Configures it to run under **Local Service**.

---

## **Usage**
1. **Run the application** to open the GUI.
2. **Select a shape** using the radio buttons.
3. **Click "Next"** to reveal the input fields.
4. **Enter the required dimensions** (e.g., radius for a circle).
5. **Click "Calculate"** to display the area.
6. **View the result** in the output label.

---

## **Example Input/Output**

### **Circle**
#### **User Input:**
- Selected **Circle**
- Entered radius: `5`
#### **Output:**
```
78.54
```

---

### **Rectangle**
#### **User Input:**
- Selected **Rectangle**
- Entered length: `10`
- Entered width: `4`
#### **Output:**
```
40
```

---

### **Triangle**
#### **User Input:**
- Selected **Triangle**
- Entered base: `8`
- Entered height: `6`
#### **Output:**
```
24
```

---

## **Future Improvements**
- Add **error handling** for invalid inputs.
- Implement **real-time calculations** without needing a button click.
- Add **support for additional shapes**.
- Improve **UI design** for a modern look.
