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
}

public interface IVehicle
{
    void Drive();
}
