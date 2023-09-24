// See https://aka.ms/new-console-template for more information

internal sealed class BinarySearch
{
    private static int BinarySearch(int[] list, int item)
    {
        int low = 0;
        int high = list.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = list[mid];
            if (guess == item)
            {
                return guess;
            }
            else
            {
                low = mid + 1;
            }
        }

        return 0;
    }
    public static void Main()
    {
        int[] list = { 1, 3, 5, 7, 9 };
        
        Console.WriteLine(BinarySearch(list, 5));
        Console.WriteLine(BinarySearch(list, -1));
    }
}