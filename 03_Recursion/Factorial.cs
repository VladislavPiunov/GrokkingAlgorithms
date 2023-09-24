internal sealed class Factorial
{
    private static int Fact(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        else
        {
            return x * Fact(x - 1);
        }
    }
    
    public static void Main()
    {
        Console.WriteLine(Fact(5));
    }
}