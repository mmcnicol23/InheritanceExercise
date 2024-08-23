using System;

namespace Inheritance;

public class Bird : Animal
{
    public string Wingspan { get; set; }
    public string BeakColor { get; set; }
    public string Food { get; set; }
    public string Birdsong { get; set;  }
    
    //Bird Method

    public void AboutBirds()
    {
        Console.WriteLine($"Let's learn about the {Name}!");
        Console.WriteLine($"The {Name} has a wingspan of {Wingspan} inches.");
        Console.WriteLine($"The {Name}'s beak color is {BeakColor}.");
        Console.WriteLine($"The {Name}'s home is {Home}.");
        Console.WriteLine($"The {Name}'s food preference is {Food}.");
    }
}