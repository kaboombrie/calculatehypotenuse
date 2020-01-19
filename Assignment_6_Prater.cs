// Brie Prater
// CIS 243
// 01/18/2020
// Assignment 6.1
// Calculate length of hypotenuse based on user input

using System;

public class Calculate
{
	double A; // variable for first side
	double B; // variable for second side
	double Total; // finds A^2+B^2
	double Hyp; // takes sqrt of total

	public void HypCalc() // function to calculate the hypotenuse
	{
		while (true) // to continue program until terminated
		{
			Console.Write("Please enter length of first side (enter 0 to exit): ");
			A = Convert.ToDouble(Console.ReadLine()); // sets A to input
			Console.Write("Please enter length of second side (enter 0 to exit): ");
			B = Convert.ToDouble(Console.ReadLine()); // sets B to input
			if (A != 0 && B != 0) // determines if program will continue
			{
				Total = Math.Pow(A, 2) + Math.Pow(B, 2);
				Hyp = Math.Sqrt(Total);
				Console.Write("The length of the Hypotenuse is: {0}", Hyp);
				Console.Write("\n");
			}
			else
			{
				Console.Write("Have a great day!");
				break; // terminates program
			}
			continue;
		}
	}
}
public class Test
{
	public static void Main(string[] args)
	{
		Calculate application = new Calculate(); 
		application.HypCalc(); // calls function to calculate hypotenuse
	}
}