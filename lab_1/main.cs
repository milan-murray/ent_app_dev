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
 *     Override the methos to calculate the volume, i.e. the volume of a sphere is PI * r³
 *
 *     Override the ToString() method inherited form ThreeDShape, 
 *     make it display information about the sphere
 *
 *     Test the class. Call the method to calculate the volume of a sphere polymorphically. 
 *     Display the details of the sphere object. Make a collection of spheres and call various methods on each sphere
 */

using System;

public abstract class ThreeDShape {
    public abstract string type;
   
    public ThreeDShape(string type_in) {
        type = type_in;
    }
}



public static class Test {
  static void Main() {
    ThreeDShape s = new("my_shape");
    Console.WriteLine(s.type);
  }
}

