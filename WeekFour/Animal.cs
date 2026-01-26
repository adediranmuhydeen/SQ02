#nullable disable
namespace WeekFour;

public abstract class Animal
{
    public int NumberOfLegs { get; set; }
    public string Color { get; set; }
    string myName;

    public abstract void Speak();
    
}
