internal sealed class DijkstrasAlgorithm
{
    private static Dictionary<string, Dictionary<string, double>> graph = new();
    private static List<string> processed = new();

    private static string? FindLowestCostNode(Dictionary<string, double> costs)
    {
        double lowestCost = double.PositiveInfinity;
        string? lowestCostNode = null;

        foreach (var node in costs)
        {
            double cost = node.Value;
            if (cost < lowestCost && !processed.Contains(node.Key))
            {
                lowestCost = cost;
                lowestCostNode = node.Key;
            }
        }

        return lowestCostNode;
    }

    public static void Main()
    {
        graph.Add("start", new());
        graph["start"].Add("a", 6.0);
        graph["start"].Add("b", 2.0);
        
        graph.Add("a", new());
        graph["a"].Add("fin", 1.0);
        
        graph.Add("b", new());
        graph["b"].Add("a", 3.0);
        graph["b"].Add("fin", 5.0);
        
        graph.Add("fin", new());

        Dictionary<string, double> costs = new();
        costs.Add("a", 6.0);
        costs.Add("b", 2.0);
        costs.Add("fin", double.PositiveInfinity);
        
        Dictionary<string, string> parents = new();
        parents.Add("a", "start");
        parents.Add("b", "start");
        parents.Add("fin", null);

        string node = FindLowestCostNode(costs);
        while (node != null)
        {
            double cost = costs[node];

            Dictionary<string, double> neighbors = graph[node];

            foreach (var n in neighbors.Keys)
            {
                double newCost = cost + neighbors[n];

                if (costs[n] > newCost)
                {
                    costs[n] = newCost;

                    parents[n] = node;
                }
            }
            processed.Add(node);

            node = FindLowestCostNode(costs);
        }
        
        Console.WriteLine("Cost from the start to each node: ");
        foreach (var cost in costs)
        {
            Console.WriteLine(cost);
        }
    }
}