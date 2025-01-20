/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/29/2016
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_604_Travis_Weber
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			static int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
 
                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num1;
        }
 
 
        int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
    
            
            int a = Convert.ToInt32(Console.ReadLine());
 
            int b = Convert.ToInt32(Console.ReadLine());
 
            int gcd = GetGCD(a, b);
            int lcm = GetLCM(a, b);
 
            Console.WriteLine("\nGCD({0,4},{1,4}) = {2,6}", a, b, gcd);
            Console.WriteLine("\nLCM({0,4},{1,4}) = {2,6}", a, b, lcm);
		}
	}
}
