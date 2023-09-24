internal sealed class CheckVoter
{
    private static Dictionary<string, bool> voted = new();

    private static void CheckVoter(string name)
    {
        if (voted.ContainsKey(name))
        {
            Console.WriteLine("Kick them out!");
        }
        else
        {
            voted[name] = true;
            Console.WriteLine("Let them vote!");
        }
    }
    
    public static void Main()
    {
        CheckVoter("tom");
        CheckVoter("mike");
        CheckVoter("mike");
    }
}