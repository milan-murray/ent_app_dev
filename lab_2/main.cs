// Milan Murray - 28 Sep 22
// Polymorphism

using System;

namespace polymorphism
{
	/*
	Vertex class
		1. Implement a Vertex class which stores the x and y coordinates of a vertex (e.g. the endpoint of a line, the origin of a circle) in 2-dimensional space. 
		2. Implement a constructor for Vertex which accepts the x and y coordinate (both are integers). 
		3. Implement appropriate properties for the class.
		4. Test the Vertex class. 
	*/

	class vertex
	{
		int x_cord, y_cord;

		public vertex(int x_cord_in, int y_cord_in)
		{
			this.x_cord = x_cord_in;
			this.y_cord = y_cord_in;
		}

		public override string ToString()
		{
			return this.x_cord + ", " + this.y_cord;
		}
	}
}
class Test
{
	public static void Main()
	{
		polymorphism.vertex v = new polymorphism.vertex(2, 2);
		Console.Write(v);
	}
}

/*
Shape class
    1. Implement a Shape class which stores the color (e.g. red, blue etc.) of a Shape. 
    2. Implement a constructor to set the color for the shape. 
    3. Implement appropriate properties for the class.
    4. Implement 2 methods in Shape, one to return details of the Shape (ToString() ) and one to allow a shape to be translated in 2D space (Translate(..)). The amount to be translated should be passed as a parameter to the translate method (as a reference to a Vertex object i.e. the amount the object is to be translated with respect to the X and Y axes). 
    5. Test the Shape class. 

Line class
    1. Implement a Line class as a subclass of Shape. A line is to represented by 2 vertices (the endpoints for the line). Implement a constructor for Line which take 5 parameters indicating the x and y coordinates of each vertex and the color of the line. 
*/


