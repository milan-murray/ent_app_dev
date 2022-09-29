// Milan Murray - 28 Sep 22
// Polymorphism

using System;

namespace polymorphism
{
	/***********
	Vertex class
		1. Implement a Vertex class which stores the x and y coordinates of a vertex (e.g. the endpoint of a line, the origin of a circle) in 2-dimensional space. 
		2. Implement a constructor for Vertex which accepts the x and y coordinate (both are integers). 
		3. Implement appropriate properties for the class.
		4. Test the Vertex class. 
	************/
	public class Vertex
	{
		public int x_cord, y_cord;

		public Vertex(int x_cord_in, int y_cord_in)
		{
			this.x_cord = x_cord_in;
			this.y_cord = y_cord_in;
		}

		public override string ToString()
		{
			// return "(" + this.x_cord + ", " + this.y_cord + ")";
			return $"({this.x_cord}, {this.y_cord})";
		}
	}

	/*
	Shape class
		1. Implement a Shape class which stores the color (e.g. red, blue etc.) of a Shape. 
		2. Implement a constructor to set the color for the shape. 
		3. Implement appropriate properties for the class.
		4. Implement 2 methods in Shape, one to return details of the Shape (ToString() ) and one to allow a shape to be translated in 2D space (Translate(..)). The amount to be translated should be passed as a parameter to the translate method (as a reference to a Vertex object i.e. the amount the object is to be translated with respect to the X and Y axes). 
		5. Test the Shape class. 
	*/

	public enum ShapeColor
	{
		Red, Green, Blue
	}

	public abstract class Shape
	{
		public ShapeColor Color { get; set; }

		public Shape(ShapeColor color_in)
		{
			Color = color_in;
		}

		public override string ToString()
		{
			return "Color: " + Color + ". ";
		}

		public abstract void translate_shape(Vertex translation_amount_in);
	}

	/*
	Line class
		1. Implement a Line class as a subclass of Shape. A line is to represented by 2 vertices (the endpoints for the line). Implement a constructor for Line which take 5 parameters indicating the x and y coordinates of each vertex and the color of the line. 
	*/
	public class Line : Shape
	{
		// Keyword: readonly
		private readonly Vertex v1, v2;

		public Line(int point_1_x_in, int point_1_y_in, int point_2_x_in, int point_2_y_in, ShapeColor color_in) : base(color_in)
		{
			this.v1 = new Vertex(point_1_x_in, point_1_y_in);
			this.v2 = new Vertex(point_2_x_in, point_2_y_in);
		}

		public int X1
		{
			get
			{
				return v1.x_cord;
			}
			set
			{
				v1.x_cord = value;
			}
		}

		public int Y1
		{
			get
			{
				return v1.y_cord;
			}
			set
			{
				v1.y_cord = value;
			}
		}

		public int X2
		{
			get
			{
				return v2.x_cord;
			}
			set
			{
				v2.x_cord = value;
			}
		}

		public int Y2
		{
			get
			{
				return v2.y_cord;
			}
			set
			{
				v2.y_cord = value;
			}
		}

		public override string ToString()
		{
			return base.ToString() + $"A Line with points ({X1}, {Y1}), ({X2}, {Y2})";
		}

		public override void translate_shape(Vertex translation_amount_in)
		{
			v1.x_cord += translation_amount_in.x_cord;
			v2.x_cord += translation_amount_in.x_cord;
			v1.y_cord += translation_amount_in.y_cord;
			v2.y_cord += translation_amount_in.y_cord;
		}
	}
	class Test
	{
		public static void Main()
		{
			Line l = new Line(-3, 10, 8, 1, ShapeColor.Red);
			Console.WriteLine(l);
		}
	}
}


