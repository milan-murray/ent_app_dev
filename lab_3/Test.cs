using System;
using Shapes;

public class Test
{
	public static void Main()
	{
		Shapes.IHasVolume[] collection = { new Shapes.Sphere(), new Shapes.Sphere(10) };

		foreach (Shapes.IHasVolume s in collection)
		{
			Console.WriteLine(s);
		}
		// Sphere jim = new(radius_in: 22.2);
		// Console.WriteLine(jim);
	}

}
