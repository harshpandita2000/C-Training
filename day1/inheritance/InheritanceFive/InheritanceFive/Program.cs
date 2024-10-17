using System;                                     //appliance->washingmachine->smartwashigachine

class Appliance
{
    
    public virtual void Start()
    {
        Console.WriteLine("Appliance is starting");
    }
}

class Refrigerator : Appliance
{
   
    public override void Start()
    {
        Console.WriteLine("Refrigerator is starting");
    }
}

class SmartRefrigerator : Refrigerator
{
    
    public override void Start()
    {
        Console.WriteLine("Smart Refrigerator is starting with smart features");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmartRefrigerator mySmartRefrigerator = new SmartRefrigerator();
        mySmartRefrigerator.Start(); 
       
    }
}
