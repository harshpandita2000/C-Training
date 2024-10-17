using System;

class Vehicle
{
    
    public  void Drive() // allow overriding in derived classes
    {
        Console.WriteLine("Vehicle is driving");
    }
}

class Car : Vehicle
{
    // Override the Drive method
    public  void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        //myCar.Drive();
        Vehicle a = new Car();
        a.Drive();
    }
}
