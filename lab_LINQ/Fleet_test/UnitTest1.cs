using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Fleet;
using System.Linq;

namespace Fleet_test;

[TestClass]
public class UnitTest_fleet
{
    private readonly List<Car> _fleet1 = new List<Car>();
    public UnitTest_fleet()
    {
        _fleet1.Add(new Car() { Make = "Toyota", Model = "Model1", Registration = "6123", EngineSize = 2000 });
        _fleet1.Add(new Car() { Make = "Toyota", Model = "Model2", Registration = "13232", EngineSize = 3000 });
        _fleet1.Add(new Car() { Make = "Nissan", Model = "M2", Registration = "3232113", EngineSize = 1600 });
        _fleet1.Add(new Car() { Make = "Ford", Model = "Focus", Registration = "54622", EngineSize = 500 });
        _fleet1.Add(new Car() { Make = "Mazda", Model = "FocusF", Registration = "3453455", EngineSize = 2300 });
        _fleet1.Add(new Car() { Make = "Musk", Model = "ModelT", Registration = "634237", EngineSize = 20000 });
    }

    [TestMethod]
    public void TestMethod1_Query1()
    {
        String output = "";
        var allCars = _fleet1.OrderBy(car => car.Registration);
        foreach (var car in allCars)
        {
            output += car + "\n";
        }
        Assert.AreEqual("Toyota Model2 13232 3000\nNissan M2 3232113 1600\nMazda FocusF 3453455 2300\nFord Focus 54622 500\nToyota Model1 6123 2000\nMusk ModelT 634237 20000\n", output);
    }

    [TestMethod]
    public void TestMethod2_Query2()
    {
        

        String output = "";
        var mazdaCars = _fleet1.Where(car => car.Make == "Mazda").Select(car => car.Model);
        foreach (var car in mazdaCars)
        {
            output += car + "\n";
        }
        Assert.AreEqual("FocusF\n", output);
    }
}