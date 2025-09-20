using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Wine basicWine = new Wine(15.99m);
        Wine vintageWine = new Wine(45.50m, 2015);

        
        Console.WriteLine("Basic Wine: Price = $" + basicWine.Price);
        Console.WriteLine("Vintage Wine: Price = $" + vintageWine.Price + ", Year = " + vintageWine.Year);
    }
}

public class Wine
{
    public decimal Price;
    public int Year;

    
    public Wine(decimal price) => Price = price;

  
    public Wine(decimal price, int year) : this(price) => Year = year;
}

