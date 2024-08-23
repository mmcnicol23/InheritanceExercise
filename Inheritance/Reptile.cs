using System;

namespace Inheritance;

public class Reptile : Animal
{
    public string Length { get; set; }
    public string LikesWater { get; set; }
    public string IsVenomous { get; set; }
    public string LivesInMichigan { get; set; }

    public void AboutReptiles()
    {
        Console.WriteLine($"Let's learn about the {Name}!");
        Console.WriteLine($"The {Name} has a length of {Length}.");
        Console.WriteLine($"Does the {Name} like water? {LikesWater}");
        Console.WriteLine($"Is the {Name} venomous? {IsVenomous}");
        Console.WriteLine($"Does the {Name} live in Michigan? {LivesInMichigan}");
        
    }
}