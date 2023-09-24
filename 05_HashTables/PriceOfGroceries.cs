internal sealed class PriceOfGroceries
{
    public static void Main()
    {
        Dictionary<string, double> book = new();
        
        book["apple"] = 0.67;
        book["milk"] = 1.49;
        book["avocado"] = 1.49;

        foreach (var keyValuePair in book)
        {
            Console.WriteLine(keyValuePair.Key + " = " + keyValuePair.Value);
        }
    }
}