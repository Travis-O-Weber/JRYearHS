
# **Weber Travis Lab 405 - Hallo Scream Qualification Program**

## **Overview**
This is a **C# console application** that determines whether a user meets the height and weight requirements for a ride or attraction. The program prompts the user to enter their **height (in inches)** and **weight (in pounds)** and then evaluates their eligibility based on predefined limits.

---

## **Features**
- **Prompts the user** for height (in inches) and weight (in pounds).
- **Checks multiple conditions** to determine if the user is too short, too tall, too light, or too heavy.
- **Displays a message** indicating whether the user qualifies or the specific reason for disqualification.
- **Handles multiple height and weight ranges** with detailed responses.

---

## **Functionality Breakdown**

### **Main Method (Program.cs)**
1. **Prompts the user for inputs**:
   - **Height in inches**
   - **Weight in pounds**
2. **Evaluates the following conditions**:
   - **Too light & too tall**: Weight `< 109` and Height `> 75`
   - **Too light & too short**: Weight `< 109` and Height `< 61`
   - **Too heavy & too tall**: Weight `> 211` and Height `> 75`
   - **Too heavy & too short**: Weight `> 211` and Height `< 61`
   - **Too light**: Weight `< 110` and Height between `62-74`
   - **Too heavy**: Weight `> 210` and Height between `62-74`
   - **Too short**: Height `< 62` and Weight `110-210`
   - **Too tall**: Height `> 74` and Weight `110-210`
   - **Qualified**: Height `62-74` and Weight `110-210`
3. **Displays an appropriate message** based on the evaluation.
4. **Waits for a key press before exiting.**

---

## **Usage**
1. **Run the program** in a console environment.
2. **Enter your height (in inches)** when prompted.
3. **Enter your weight (in pounds)** when prompted.
4. **View the qualification result**.
5. **Press any key to exit**.

---

## **Example Input/Output**

#### **Input:**
```
Height: 76
Weight: 105
```
#### **Output:**
```
You are too light and too tall
```
---
#### **Input:**
```
Height: 68
Weight: 180
```
#### **Output:**
```
Congratulations you qualify
```
---
#### **Input:**
```
Height: 60
Weight: 220
```
#### **Output:**
```
You are too heavy and too short
```

---

## **Notes**
- **Does not validate non-numeric inputs** (Entering letters instead of numbers will crash the program).
- **Does not account for extreme values** (e.g., negative numbers or unrealistic height/weight combinations).
- **Hardcoded limits** could be improved for better customization.

---

## **Future Improvements**
- Implement **input validation** to handle non-numeric values.
- Allow **customizable weight and height limits** via configuration.
- Provide **more detailed feedback** on eligibility adjustments.
