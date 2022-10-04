// Milan Murray - 4 Oct 22
// Interfaces

using System;

/*
You are required to redesign the solution you came up with for Lab 1 to use an interface. 
Rather than having a ThreeDShape superclass and a Sphere subclass you should define a 
IHasVolume interface and make the Sphere class implement it. 

The program will have one interface and one class:
*/

namespace shape_interface;

/*
IHasVolume interface
    1. The interface should have a method which calculates the volume of an item 
*/

interface IHasVolume
{
	int volume();
}


public class Test
{
	public static void Main()
	{
		Console.WriteLine("Test class");
	}

}
