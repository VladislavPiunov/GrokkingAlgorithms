internal sealed class Greet
{
    private static void Greet2(string name)
    {
        Console.WriteLine("How are you, " + name + "?");
    }

    private static void Bye()
    {
        Console.WriteLine("Ok bye!");
    }

    private static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
        Greet2(name);
        Console.WriteLine("Getting ready to say bye...");
        Bye();
    }

    public static void Main()
    {
        Greet("Vlad");
    }
}