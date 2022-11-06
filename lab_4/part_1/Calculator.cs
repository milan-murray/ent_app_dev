// Milan Murray - 16 Oct 22
// Exceptions and Indexers

using System;

/*
	Write a Calculator class which contains a static method which divides 2 floating point 
	numbers and returns the answer. If the second number is 0 throw an ArgumentException 
	since division by 0 is undefined.
*/

namespace Calculation
{
	public class Calculator
	{
		public static double Divide(double num_1_in, double num_2_in)
		{
			if (num_2_in == 0)
			{
				throw new InvalidOperationException("No es posible dividir por 0");
			}

			return num_1_in / num_2_in;
		}
	}
	
}

