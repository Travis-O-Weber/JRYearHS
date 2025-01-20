using System;
namespace lab_601_Travis_Weber
{
	class Program
	{
		public static void Main(string[] arg44s)
		{
			int testnum = int.Parse(Console.ReadLine());
			 int devisors = 0;
 for (int i = 2; i <= testnum ; i++)
     if (testnum  % i == 0)                        
          devisors++;

 if (testnum  != 1 && devisors == 1)                 
     Console.WriteLine("prime");
 else						    
 Console.WriteLine("not prime");
 Console.ReadKey(true);
 
 
		}
	}
}