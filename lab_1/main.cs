// Milan Murray - 26 Sep 22
// Abstract Classes & Properties

/*
 * ThreeDShape class
 *     Implement an abstract of ThreeDShape
 *     
 *     The class should have a field which stores the type of the shape,
 *     and a public read-only property corresponding to this field
 *     
 *     Implement appropriate constructors for the class
 *
 *     Override the ToString() method inherited from System.Object, 
 *     make it display information about the shape
 *
 * Sphere class
 *     A Sphere "is a" ThreeDShape
 *
 *     The class should have a field to store the radius of the sphere, 
 *     and a read-write property corresponding to the field. The radius cannot be negative
 *
 *     Implement appropriate constructors for the class
 *
 *     Override the methods to calculate the volume, i.e. the volume of a sphere is PI * r³
 *
 *     Override the ToString() method inherited form ThreeDShape, 
 *     make it display information about the sphere
 *
 *     Test the class. Call the method to calculate the volume of a sphere polymorphically. 
 *     Display the details of the sphere object. Make a collection of spheres and call various methods on each sphere
 */

using System;

namespace shapes
{
	public abstract class ThreeDShape
	{
		String type;

		protected ThreeDShape(string type_in)
		{
			this.type = type_in;
		}

		public String Type
		{
			get
			{
				return type;
			}
		}

		public abstract double CalcVolume();

		public override string ToString()
		{
			return base.ToString();
		}
	}

	public class Sphere : ThreeDShape
	{
		double radius;

		public Sphere(double radius_in) : base("Sphere")
		{
			Radius = radius_in;
		}

		public Sphere() : this(0)
		{
		}

		public double Radius
		{
			get
			{
				return radius;
			}

			set
			{
				if (value >= 0)
				{
					radius = value;
				}
				else
				{
					throw new ArgumentException("Radius cannot be negative");
				}
			}
		}

		public override double CalcVolume()
		{
			return Math.Pow(radius, 3) * Math.PI;
		}

		public override string ToString()
		{
			return base.ToString() + " of radius: " + radius.ToString();
		}
	}

}

public static class Test
{
	static void Main()
	{
		shapes.ThreeDShape[] collection = { new shapes.Sphere(0.1), new shapes.Sphere(10) };

		foreach (shapes.ThreeDShape s in collection)
		{
			Console.Writeline(s + " volume: " + s.CalcVolume());
		}
	}
}
