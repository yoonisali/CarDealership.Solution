using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Name { get; set; }

    public string Age { get; set; }

    public string Color { get; set; }

    public string Miles { get; set; }

    private static List<Car> _instances = new List<Car> { };

    public Car(string name, string age, string color, string miles)
    {
      Name = name;
      Age = age;
      Color = color;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }


  }
}