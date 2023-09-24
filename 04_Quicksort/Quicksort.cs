internal sealed class Quicksort
{
    public static void Main()
    {
        QuickSort(new List<int>{ 10, 5, 2, 3 , 7, 4 }).ForEach(x => Console.WriteLine(x));
    }

    static List<int> QuickSort(List<int> lst){
        if(lst.Count<=1)
            return lst;
        int pivotIndex = lst.Count/2;
        int pivot = lst[pivotIndex];
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        
        for(int i=0;i<lst.Count;i++){
            if(i==pivotIndex) continue;
            
            if(lst[i]<=pivot){
                left.Add(lst[i]);
            }
            else{
                right.Add(lst[i]);
            }
        }
        
        List<int> sorted = QuickSort(left);
        sorted.Add(pivot);
        sorted.AddRange(QuickSort(right));
        return sorted;
    }
}