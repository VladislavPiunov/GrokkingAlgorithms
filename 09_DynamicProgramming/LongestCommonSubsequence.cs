internal sealed class LongestCommonSubsequence
{
    public static void Main()
    {
        string wordA = "hish";
        string wordB = "fish";

        int[,] cell = new int[wordA.Length, wordB.Length];

        for (int i = 0; i < wordA.Length; i++)
        {
            for (int j = 0; j < wordB.Length; j++)
            {
                if (wordA[i] == wordB[j])
                {
                    if (i > 0 && j > 0)
                    {
                        cell[i, j] = cell[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        cell[i, j] = 1;
                    }
                }
                else
                {
                    if (i > 0 && j > 0)
                    {
                        cell[i, j] = Math.Max(cell[i - 1, j], cell[i, j - 1]);
                    }
                    else
                    {
                        cell[i, j] = 0;
                    }
                }
            }
        }
        PrintResult(cell);
        //  [0, 0, 0, 1]
        //  [0, 1, 1, 1]
        //  [0, 1, 2, 2]
        //  [0, 1, 2, 3]
    }

    private static void PrintResult(int[,] arr)
    {
        foreach (var row in arr)
        {
            Console.WriteLine(row);
        }
    }
}