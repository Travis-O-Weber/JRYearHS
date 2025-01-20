/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/24/2016
 * Time: 12:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dice_test
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.Write("Enter the name of Player 1: ");
  Player[0] = Console.ReadLine();
  Console.Write("Enter the name of Player 2: ");
  Player[1] = Console.ReadLine();

  Random DiceRandom = new Random();

  do
    {

        int i = 0;
        while (i <= 1)
        {
            int thisThrow = DiceRandom.Next(1, 6);
            DiceThrow[0 + i] += thisThrow;
            Console.ReadLine();
            Console.Write(Player[0 + i] + " rolled a " + thisThrow);
            if (thisThrow != 6) i++;
        }

        Console.ReadLine();
        PlayerTotal[0] += DiceThrow[0];
        PlayerTotal[1] += DiceThrow[1];


        Console.ReadLine();
        Console.Write(Player[0] + " currently has " + PlayerTotal[0]);
        Console.ReadLine();
        Console.Write(Player[1] + " currently has " + PlayerTotal[1]);
        Console.ReadLine();

    }
    while (PlayerTotal[0] < 20 && PlayerTotal[1] < 20);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}