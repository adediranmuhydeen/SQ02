#nullable disable
namespace WeekFour;

public  class Animal : IAnimal
{
    public int NumberOfLegs { get; set; }
    public string Color { get; set; }
    string myName;

    public  void Speak()
    {
        Console.WriteLine("Bleat");
    }

    public void GetColor()
    {
        Console.WriteLine($"My color is {Color}");
    }
}

public interface IAnimal
{
    void Speak();
    void GetColor();
}

public class Store
{
    private IAnimal animal;

    public void WhatIsYourColor()
    {
        animal.GetColor();
    }
}
