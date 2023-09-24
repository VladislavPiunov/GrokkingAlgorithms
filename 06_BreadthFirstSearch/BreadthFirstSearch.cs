internal sealed class BreadthFirstSearch
{
    private static Dictionary<string, List<string>> graph = new();

    private static bool Search(string name)
    {
        Queue<string> searchQueue = new Queue<string>(graph[name]);
        List<string> searched = new();

        while (searchQueue.Any())
        {
            string person = searchQueue.Dequeue();

            if (!searched.Contains(person))
            {
                if (PersonIsSeller(person))
                {
                    Console.WriteLine(person + " is a mango seller!");
                }
                else
                {
                    graph[person].ForEach(x => searchQueue.Enqueue(x));
                    searched.Add(person);
                }
            }
        }

        return false;
    }

    private static bool PersonIsSeller(string name)
    {
        return name.EndsWith("m");
    }

    public static void Main()
    {
        graph["you"] = new List<string> { "alice", "bob", "claire" };
        graph["bob"] = new List<string> { "anuj", "peggy" };
        graph["alice"] = new List<string> { "peggy" };
        graph["claire"] = new List<string> { "thom", "jonny" };
        graph["anuj"] = new List<string>();
        graph["thom"] = new List<string>();
        graph["jonny"] = new List<string>();

        Search("you");
    }
}