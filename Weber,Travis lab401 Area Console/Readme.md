# **Area Calculator - Console Application**

## **Overview**
This is a **C# console application** that calculates the area of **three different shapes** based on user input. The program prompts the user to choose a shape, requests relevant dimensions, and outputs the computed area.

---

## **Features**
- Supports **three shapes**:
  - **Circle** (Requires **radius**)
  - **Triangle** (Requires **base** and **height**)
  - **Rectangle** (Requires **length** and **width**)
- Takes **user input** to determine the shape and dimensions.
- Calculates and **displays the area** for the chosen shape.
- **Runs in the console** and waits for user interaction before exiting.

---

## **Functionality Breakdown**

### **Main Method (Program.cs)**
1. **Prompts the user** to choose a shape:
   - Enter `1` for **Circle**.
   - Enter `2` for **Triangle**.
   - Enter `3` for **Rectangle**.
2. Reads user input and converts it to an integer (`c`).
3. Based on the input:
   - If `1`: **Calculates the area of a Circle** using the formula:
     ```
     Area = π * r²
     ```
   - If `2`: **Calculates the area of a Triangle** using the formula:
     ```
     Area = (Base * Height) / 2
     ```
   - If `3`: **Calculates the area of a Rectangle** using the formula:
     ```
     Area = Length * Width
     ```
4. Displays the **computed area** in the console.
5. Waits for a key press before terminating the program.

---

## **Usage**
1. **Run the program** in a console environment.
2. **Enter a number (1, 2, or 3)** to choose a shape.
3. **Provide the required dimensions** as prompted.
4. **View the calculated area**.
5. **Press any key** to exit.

---

## **Example Input/Output**

### **Circle**
#### **Input:**
```
1
5
```
#### **Output:**
```
The area of your circle is 78.53975
```

---

### **Triangle**
#### **Input:**
```
2
10
5
```
#### **Output:**
```
The area of your triangle is 25
```

---

### **Rectangle**
#### **Input:**
```
3
4
6
```
#### **Output:**
```
The area of your rectangle is 24
```

---

## **Notes**
- Does **not handle invalid input** (e.g., letters instead of numbers).
- Uses **hardcoded value of π (3.14159)** instead of `Math.PI`.
- **Only supports three shapes** (expansion needed for other geometries).
- No input validation, so entering non-numeric values **will crash** the program.

---

## **Future Improvements**
- Implement **input validation** to handle incorrect inputs.
- Use **Math.PI** instead of hardcoded π value.
- Allow **more shape options**, such as **trapezoids or hexagons**.
- Add **unit selection** (e.g., cm², m², inch²).
