namespace Algorithms_And_Data_Structure.Search.Binary;

public class BinarySearch
{
    /// <summary>
    /// Return index of target element
    /// If target element not found, return -1
    /// Time - O(LogN) 
    /// </summary>
    /// <param name="sortedList">List has to be sort</param>
    /// <param name="target">Value of target element</param>
    /// <returns>Index of target element</returns>
    public int GetIndex(List<int> sortedList, int target)
    {
        int start = 0;
        int end = sortedList.Count - 1;
        int operations = 0;
        
        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (target == sortedList[mid])
            {
                Console.WriteLine($"Count of operations equals: {operations}");
                return mid;
            }
            
            if (target > sortedList[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }

            operations += 1;
        }
        
        Console.WriteLine($"Count of operations equals: {operations}");
        return -1;
    }

    public int FindInsertPlace(List<int> sortedList, int value)
    {
        int start = 0;
        int end = sortedList.Count - 1;
        int operations = 0;
        
        while (start < end)
        {
            int mid = (start + end) / 2;
            
            if (value > sortedList[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
            
            operations += 1;
        }
        
        Console.WriteLine($"Count of operations equals: {operations}");

        return start;
    }
}