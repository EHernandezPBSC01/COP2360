using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Car myCar = new Car("Toyota", "Corolla", 2022);

      
        Console.WriteLine("Car Info: " + myCar.GetCarInfo());

        
        Console.WriteLine("Car Make: " + myCar.Make);
    }
}


public class Car
{
    public string Make;
    public string Model;
    public int Year;

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string GetCarInfo()
    {
        return $"{Year} {Make} {Model}";
    }
}
