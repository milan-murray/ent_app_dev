// Milan Murray 2020 Nov 13
// LINQ

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Fleet;

public class Car
{
    public String Make { get; set; }
    public String Model { get; set; }
    public String Registration { get; set; }
    public int EngineSize { get; set; }

    public override string ToString()
    {
        return $"{Make} {Model} {Registration} {EngineSize}";
    }
}

public class Fleet
{
    static void Main()
    {
        List<Car> fleet = new List<Car>();
        fleet.Add(new Car() {Make = "Toyota", Model = "Model1", Registration = "6123", EngineSize = 2000});
        fleet.Add(new Car() {Make = "Toyota", Model = "Model2", Registration = "13232", EngineSize = 3000});
        fleet.Add(new Car() {Make = "Nissan", Model = "M2", Registration = "3232113", EngineSize = 1600});
        fleet.Add(new Car() {Make = "Ford", Model = "Focus", Registration = "54622", EngineSize = 500});
        fleet.Add(new Car() {Make = "Mazda", Model = "FocusF", Registration = "3453455", EngineSize = 2300});
        fleet.Add(new Car() {Make = "Musk", Model = "ModelT", Registration = "634237", EngineSize = 20000});

        // Query 1 - List all cars
        var allCars = fleet.OrderBy(car => car.Registration);
        Console.WriteLine("Query 1");
        foreach (var car in allCars)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine();

        // Query 2 - List all models for all Mazda cars in the fleet
        var mazdaCars = fleet.Where(car => car.Make == "Mazda").Select(car => car.Model);
        Console.WriteLine("Query 2");
        foreach (var mazdaCar in mazdaCars)
        {
            Console.WriteLine(mazdaCar);
        }
        Console.WriteLine();

        // Query 3 - List all cars in descending engine size order
        var allCars1 = fleet.OrderByDescending(car => car.EngineSize);
        Console.WriteLine("Query 3");
        foreach (var car in allCars1)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine();

        // Query 4 - List just the make and model for cars whose engine size is 1600 cc
        var carMakeModel = fleet.Where(car => car.EngineSize == 1600).Select(car => new { car.Make, car.Model });
        Console.WriteLine("Query 4");
        foreach (var car in carMakeModel)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine();

        // Query 5 - Count the number of cars whose engine size is 1600 cc or less
        var carCount = fleet.Where(car => car.EngineSize <= 1600).Count();
        Console.WriteLine("Query 5");

        Console.WriteLine(carCount);
        
        Console.WriteLine();
    }
}
