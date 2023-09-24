internal sealed class SetCovering
{
    public static void Main()
    {
        HashSet<string> statesNeeded = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
        Dictionary<string, HashSet<string>> stations = new();

        stations.Add("kone", new HashSet<string> { "id", "nv", "ut", });
        stations.Add("ktwo", new HashSet<string> { "wa", "id", "mt" });
        stations.Add("kthree", new HashSet<string> { "or", "nv", "ca" });
        stations.Add("kfour", new HashSet<string> { "nv", "ut" });
        stations.Add("kfive", new HashSet<string> { "ca", "az" });

        HashSet<string> finalStations = new();
        while (statesNeeded.Any())
        {
            string bestStation = null;
            HashSet<string> statesCovered = new();

            foreach (var station in stations)
            {
                HashSet<string> covered = new HashSet<string>(statesNeeded);
                covered.IntersectWith(station.Value);

                if (covered.Count() > statesCovered.Count())
                {
                    bestStation = station.Key;
                    statesCovered = covered;
                }
                
                statesNeeded.ExceptWith(statesCovered);

                if (bestStation != null)
                {
                    finalStations.Add(bestStation);
                }
            }
        }
        
        foreach (var finalStation in finalStations)
        {
            Console.WriteLine(finalStation);
        }
    }
}