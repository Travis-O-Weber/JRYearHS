
# **Weber Travis Lab 403 - GPA Calculator GUI**

## **Overview**
This is a **Windows Forms (GUI) application** built with C# that allows users to **convert a letter grade (A-F) into a GPA value**. The user inputs a letter grade, and the application displays the corresponding GPA on a scale of 0.00 to 4.00.

---

## **Features**
- **Graphical User Interface (GUI)**
- Accepts **letter grades (A, B, C, D, F)** as input.
- Converts the letter grade into a **GPA value**.
- Displays the **calculated GPA** in the GUI.
- **Basic error handling** by restricting input to capital letters without `+` or `-` signs.

---

## **Functionality Breakdown**

### **1. Program Entry Point - `Program.cs`**
- **Initializes the application** using `Application.Run(new MainForm());`
- **Loads the `MainForm` GUI**, which serves as the user interface.

---

### **2. GUI Main Window - `MainForm.cs`**
#### **Key Functions:**
- `Button1Click()` - Handles the "Calculate" button click:
  - Reads the user input from the **textBox1**.
  - Checks if the input matches **A, B, C, D, or F**.
  - Displays the corresponding **GPA value** in **label4**.
  - Makes **label3 (GPA text) and label4 (GPA value)** visible.

#### **GPA Conversion Table:**
| Letter Grade | GPA Value |
|-------------|----------|
| A           | 4.00     |
| B           | 3.00     |
| C           | 2.00     |
| D           | 1.00     |
| F           | 0.00     |

---

### **3. Windows Form Designer - `MainForm.Designer.cs`**
- Defines UI components:
  - **Labels** for the title, instructions, and result.
  - **TextBox** for user input.
  - **Button** to trigger the calculation.
- Controls the **layout and appearance** of the GUI.

---

## **Usage**
1. **Run the application** to open the GUI.
2. **Enter a letter grade (A, B, C, D, or F)** in the input box.
3. **Click "Calculate"** to display the GPA value.
4. **View the result** in the output label.

---

## **Example Input/Output**

#### **Input:**  
```
A
```
#### **Output:**  
```
Your GPA is 4.00
```

---
#### **Input:**  
```
C
```
#### **Output:**  
```
Your GPA is 2.00
```

---

## **Notes**
- The program **only accepts uppercase letters** (`A, B, C, D, F`).
- **Does not support + or - grades** (e.g., A-, B+).
- **No input validation** for invalid characters (e.g., entering `E` will not show an error but will also not display a GPA).
