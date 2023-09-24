internal sealed class Greet
{
    private static void Greetings2(string name)
    {
        Console.WriteLine("How are you, " + name + "?");
    }

    private static void Bye()
    {
        Console.WriteLine("Ok bye!");
    }

    private static void Greetings(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
        Greetings2(name);
        Console.WriteLine("Getting ready to say bye...");
        Bye();
    }

    public static void Main()
    {
        Greetings("Vlad");
    }
}