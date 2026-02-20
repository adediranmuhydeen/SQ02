namespace SQ02;

public class Algorithm 
{
    public bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    public bool IsOdd(int num)
    {
        return num%2 !=0;
    }
}

public static class  Methods
{
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    public static bool IsOdd(int num)
    {
        return num % 2 != 0;
    }
}

public sealed class NewMethods
{
    public bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    public bool IsOdd(int num)
    {
        return num % 2 != 0;
    }

    public static double SumArray(double[] array)
    {
        return array.Sum();
    }
}

public struct MyStruct
{
    public bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    public bool IsOdd(int num)
    {
        return num % 2 != 0;
    }
}


public interface IAlgorithm
{
    bool IsEven(int num);
    bool IsOdd(int num);
}


