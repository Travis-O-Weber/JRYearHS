# **Weber Travis Lab 406 - Costume Pricing Calculator**

## **Overview**
This is a **Windows Forms (GUI) application** built with C# that allows users to **select costume options and accessories** to calculate the total cost. The user selects a **base costume type** and can choose additional accessories, and the program computes the total price dynamically.

---

## **Features**
- **Graphical User Interface (GUI)** for selecting costume options.
- **Three base costume types** with different prices:
  - Full Mask: **$23.00**
  - Face Makeup: **$27.00**
  - Partial Mask: **$15.00**
- **Eight additional accessories** with different prices:
  - Blood Caplets: **$2.00**
  - Scar: **$3.50**
  - Teeth: **$1.50**
  - Fingernails: **$3.00**
  - Hat: **$7.00**
  - Shirt/Blouse: **$6.00**
  - Pants: **$10.00**
  - All-in-One Costume: **$23.00**
- **Calculates the total cost** based on selected items.
- **Displays the total price dynamically**.

---

## **Functionality Breakdown**

### **1. Program Entry Point - `Program.cs`**
- **Initializes the application** using `Application.Run(new MainForm());`
- **Loads the `MainForm` GUI**, which serves as the user interface.

---

### **2. GUI Main Window - `MainForm.cs`**
#### **Key Functions:**
- `Button1Click()` - Handles the **"Calculate"** button:
  - **Adds base costume price** based on selected radio button.
  - **Adds accessory prices** based on checked checkboxes.
  - **Displays total price** in `label3`.

- `RadioButton1CheckedChanged()`, `RadioButton2CheckedChanged()`, `RadioButton3CheckedChanged()` - Ensures that only one **base costume** is selected.

- `CheckBox1CheckedChanged()` - `CheckBox8CheckedChanged()` - Handles **accessory selections**.

---

### **3. Windows Form Designer - `MainForm.Designer.cs`**
- Defines UI components:
  - **Radio buttons** for selecting a **base costume**.
  - **Check boxes** for selecting **accessories**.
  - **Button** to trigger the price calculation.
  - **Labels** to display results.
- Controls the **layout and appearance** of the GUI.

---

## **Usage**
1. **Run the application** to open the GUI.
2. **Select one base costume** using the radio buttons.
3. **Check the boxes** for any additional accessories.
4. **Click "Calculate"** to display the total price.
5. **View the total cost** in the output label.

---

## **Example Input/Output**

### **Scenario 1 - Basic Selection**
#### **User Input:**
- Selected **Full Mask**: **$23.00**
- No accessories selected.

#### **Output:**
```
Total Price: $23.00
```

---

### **Scenario 2 - Costume with Accessories**
#### **User Input:**
- Selected **Face Makeup**: **$27.00**
- Added:
  - Scar: **$3.50**
  - Teeth: **$1.50**
  - Fingernails: **$3.00**

#### **Output:**
```
Total Price: $35.00
```

---

### **Scenario 3 - All-in-One Costume**
#### **User Input:**
- Selected **Partial Mask**: **$15.00**
- Added:
  - All-in-One Costume: **$23.00**
  - Hat: **$7.00**
  - Shirt/Blouse: **$6.00**
  - Pants: **$10.00**

#### **Output:**
```
Total Price: $61.00
```

---

## **Notes**
- **Ensures only one base costume is selected**.
- **Allows multiple accessories to be selected**.
- **Does not validate inputs**, but all selections are done via GUI elements.
- **No undo/reset option**; user must manually uncheck items.

