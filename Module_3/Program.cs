using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Wine basicWine = new Wine(15.99m);
        Wine vintageWine = new Wine(45.50m, 2015);

<<<<<<< HEAD
       
=======
        
>>>>>>> d7955e18905f85955994b54a104d299afb19ebdf
        Console.WriteLine("Basic Wine: Price = $" + basicWine.Price);
        Console.WriteLine("Vintage Wine: Price = $" + vintageWine.Price + ", Year = " + vintageWine.Year);
    }
}

public class Wine
{
    public decimal Price;
    public int Year;

    
    public Wine(decimal price) => Price = price;

<<<<<<< HEAD
   
=======
  
>>>>>>> d7955e18905f85955994b54a104d299afb19ebdf
    public Wine(decimal price, int year) : this(price) => Year = year;
}

