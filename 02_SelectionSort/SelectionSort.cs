internal sealed class SelectionSort
{
    private static List<int> SelectionSort(List<int> arr)
    {
        List<int> newArr = new();

        int size = arr.Count;
        for (int i = 0; i < size; i++)
        {
            int smallest = FindSmallest(arr);
            newArr.Add(arr[smallest]);
            
            arr.RemoveAt(smallest);
        }

        return newArr;
    }

    private static int FindSmallest(List<int> arr)
    {
        int smallest = arr[0];
        int smallestIndex = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }
    
    public static void Main()
    {
        List<int> arr = new List<int> { 5, 3, 6, 2, 10 };
        SelectionSort(arr).ForEach(x => Console.WriteLine(x));
    }
}