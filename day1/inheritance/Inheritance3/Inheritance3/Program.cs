using System;

class Device
{
    
    public virtual void PowerOn()
    {
        Console.WriteLine("Device is powering on");
    }
}

class Laptop : Device
{
    
    public override void PowerOn()
    {
        Console.WriteLine("Laptop is powering on");
    }
}

class Smartphone : Device
{
    
    public override void PowerOn()
    {
        Console.WriteLine("Smartphone is powering on");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Device myLaptop = new Laptop();
        Device mySmartphone = new Smartphone();

        myLaptop.PowerOn();      
        mySmartphone.PowerOn();  
    }
}
