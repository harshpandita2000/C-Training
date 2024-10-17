using System;

class Animal
{
    public string Name { get; set; } 
    public string Type { get; set; } 
}

class Bird : Animal
{
    public string CanFly { get; set; } 
}

class Fish : Animal
{
    public string WaterType { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        
        Bird myBird = new Bird
        {
            Name = "Sparrow",
            Type = "Bird",
            CanFly = "Yes" 
        };

        
        Fish myFish = new Fish
        {
            Name = "Goldfish",
            Type = "Fish",
            WaterType = "Freshwater" 
        };

       
        Console.WriteLine($"{myBird.Name} is a {myBird.Type} and can fly: {myBird.CanFly}.");

        
        Console.WriteLine($"{myFish.Name} is a {myFish.Type} and lives in {myFish.WaterType}.");
    }
}
