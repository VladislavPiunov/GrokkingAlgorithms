internal sealed class Countdown
{
    private static void countdown(int i)
    {
        Console.WriteLine(i);
        
        //base case
        if (i <= 0)
        {
            return;
        }
        else
        {
            countdown(i - 1);
        }
    }
    
    public static void Main()
    {
        countdown(5);
    }
}