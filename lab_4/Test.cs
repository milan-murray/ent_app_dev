// Milan Murray - 16 Oct 22
// Exceptions and Indexers

using System;
using Calculation;

/*
	Use a test class to call the method.
	
	Pass in 2 numbers which have been input by the user. 
	
	The test class should validate the inputs by using Double.Parse() to convert the inputs 
	to floating point numbers catching FormatException or OverflowExceptions if the inputs 
	are invalid. If valid then call the static method to divide the numbers and display 
	the result. Catch any exceptions that may arise.
*/

class Test
{
	public static void Main()
	{
		try
		{

			double num1 = 0, num2 = 0;
			bool valid = true;
			do
			{
				try
				{
					Console.WriteLine("Por favor, escribe numero 1: ");
					num1 = Double.Parse(Console.ReadLine());
					valid = true;
				}

				catch (FormatException)
				{
					valid = false;
				}
				catch (OverflowException)
				{
					valid = false;
				}
			} while (!valid);

			do
			{
				try
				{
					Console.WriteLine("Por favor, escribe numero 2: ");
					num2 = Double.Parse(Console.ReadLine());
					valid = true;
				}

				catch (Exception)
				{
					valid = false;
				}

			} while (!valid);
			
			Console.WriteLine(Calculator.Divide(num1, num2));
		}
		catch (ArgumentException e1)
		{
			Console.WriteLine(e1.Message);
		}


	}
}
