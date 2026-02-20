#nullable disable
namespace SQ02;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    protected int Month { get; set; }
}


public class  Honda :Car
{
    public int Addition(int a, int b)
    {
        var c = a + b;
        return c;
    }

    public int Addition(double a, double b)
    {
        var c = a + b;
        return (int)c;
    }

    public int Addition(int a, int b, int d)
    {
        var c = a + b + d;
        return c;
    }
    List<int> myNumbers = new List<int>();
    ICollection<int> myArray = new int[5];
    Dictionary<string, int> myDictionary = new Dictionary<string, int>();
}

public interface IVehicle
{
    void Drive();
}

// LINQ query in C#
/*String and string method
 * Int and int method
 * Collection and collection method (List and Array)
 * Generic Classes in C#
 */

public  class MyGenericClass
{
    List<Car> cars = new List<Car>
    {
        new Car { Make = "Honda", Model = "Civic", Year = 2020 },
        new Car { Make = "Honda", Model = "CrossTour", Year = 2020 },
        new Car { Make = "Honda", Model = "Accord", Year = 2020 },
        new Car { Make = "Honda", Model = "Accord", Year = 2022 },
        new Car { Make = "Toyota", Model = "Corolla", Year = 2019 },
        new Car { Make = "Ford", Model = "Mustang", Year = 2022 },
        new Car { Make = "KIA", Model = "Picanto", Year = 2022 },
        new Car { Make = "Lexus", Model = "RX330", Year = 2020 },
        new Car { Make = "Ford", Model = "Mustang", Year = 2023 },
        new Car { Make = "Ford", Model = "Mustang", Year = 2021 },
        new Car { Make = "Ford", Model = "Mustang", Year = 2022 },
        new Car { Make = "Ford", Model = "Mustang", Year = 2021 },
    };

    
}




