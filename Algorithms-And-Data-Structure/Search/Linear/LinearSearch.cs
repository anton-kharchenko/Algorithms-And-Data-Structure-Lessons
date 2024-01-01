namespace Algorithms_And_Data_Structure.Search.Linear;

public class LinearSearch
{
    /// <summary>
    /// Return index of target element
    /// If target element not found, return -1
    /// Time - O(N)
    /// </summary>
    /// <param name="sortedList">List has to be sort</param>
    /// <param name="target">Value of target element</param>
    /// <returns>Index of target element</returns>
    public int GetIndex(List<int> sortedList, int target)
    {
        int operations = 0;

        for (int i = 0; i < sortedList.Count; i++)
        {
            var currentNumber = sortedList[i];
            operations += 1;
            if (currentNumber == target)
            {
                Console.WriteLine($"Count of operations equals: {operations}");
                return i;
            }
        }
        
        Console.WriteLine($"Count of operations equals: {operations}");
        return -1;
    }
}