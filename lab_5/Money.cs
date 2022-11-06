// Milan Murray 24 Oct 22
// Enums and structs

using System;

namespace Currency;

public enum currencyUnit { Euro, USD, Yen }

/*
	Implement a Money structure which stores an amount of money and the currency unit for that 
	amount. Currency units should be euro or US dollar or yen. Use auto-implemented properties. Add 
	a non-default constructor allowing the amount and the currency unit to be specified at the time 
	of construction of an object.
*/

public struct Money
{
	private const double EuroToUSDRate = 0.9872014;
	private const double EuroToYenRate = 146.98514;
	private const double USDToEuroRate = 1 / EuroToUSDRate;
	private const double USDToYenRate = 148.91253;
	private const double YenToEuroRate = 1 / EuroToYenRate;
	private const double YenToUSDRate = 1 / USDToYenRate;

	private double amount
	{
		get;
		set;
	}
	private currencyUnit cUnit;

	public Money(double amount_in, currencyUnit currencyUnit_in) : this()
	{
		this.amount = amount_in;
		this.cUnit = currencyUnit_in;
	}

	/*
		Implement a method in the structure which allows the currency amount to be converted into 
		an amount in a different currency and returned. Store the various conversion rates to be 
		used in the conversion as constants in the structure.
	*/
	public double ConvertCurrency(currencyUnit cUnit_in)
	{
		if (cUnit == cUnit_in)
		{
			return amount;
		}
		else
		{
			if (cUnit == currencyUnit.Euro)
			{
				if (cUnit_in == currencyUnit.USD)
				{
					return amount * EuroToUSDRate;
				}
				else
				{
					return amount * EuroToYenRate;
				}
			}
			else if (cUnit == currencyUnit.USD)
			{
				if (cUnit_in == currencyUnit.Euro)
				{
					return amount * USDToEuroRate;
				}
				else
				{
					return amount * USDToYenRate;
				}
			}
			else // Is Yen
			{
				if (cUnit_in == currencyUnit.Euro)
				{
					return amount * YenToEuroRate;
				}
				else
				{
					return amount * YenToUSDRate;
				}
			}
		}
	}

	/*
		Implement a method which allows 2 Money objects to be added together. The first Money 
		object determines the currency unit for the result e.g. euro + dollar = euro. Convert 
		currencies if necessary in this method.
	*/

	public static Money operator +(Money lhs, Money rhs)
	{
		if (lhs.cUnit == rhs.cUnit)
		{
			return new Money(lhs.amount + rhs.amount, lhs.cUnit);
		}
		else
		{
			return new Money(lhs.amount + rhs.ConvertCurrency(lhs.cUnit), lhs.cUnit);
		}
	}

	public override string ToString()
	{
		return $"Amount: {amount}, Currency: {cUnit}";
	}
}

public class Test
{
	public static void Main()
	{
		Money m1 = new Money(240.21, currencyUnit.Euro);
		Console.WriteLine(m1);
		Money m2 = new Money(240.21, currencyUnit.Yen);
		Console.WriteLine(m2);
		Money m3 = m1 + m2;
		Console.WriteLine(m3);
	}
}