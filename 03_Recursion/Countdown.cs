{
    private static void Countdown(int i)
    {
        Console.WriteLine(i);
        
        //base case
        if (i <= 0)
        {
            return;
        }
        else
        {
            Countdown(i - 1);
        }
    }
    
    public static void Main()
    {
        Countdown(5);
    }
}