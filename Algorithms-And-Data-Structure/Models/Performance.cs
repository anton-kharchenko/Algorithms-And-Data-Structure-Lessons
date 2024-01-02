using System.Diagnostics;
using Algorithms_And_Data_Structure.Search.Binary;
using Algorithms_And_Data_Structure.Search.Linear;

namespace Algorithms_And_Data_Structure.Models;

public class Performance
{
    private Stopwatch _stopwatch;
    private LinearSearch _linearSearch;
    private BinarySearch _binarySearch;
    
    public Performance()
    {
        _stopwatch = new Stopwatch();
        _linearSearch = new LinearSearch();
        _binarySearch = new BinarySearch();
    }
    
    public void CompareBinaryAndLinearSearch(List<int> arr, int target)
    {
        _stopwatch.Start();
        
        _linearSearch.GetIndex(arr, target);
        
        _stopwatch.Stop();

        TimeSpan linearSearchTime = _stopwatch.Elapsed;
        
        Console.WriteLine($"Linear search result: {linearSearchTime}");

        _stopwatch = new Stopwatch();
        
        _stopwatch.Start();
        
        _binarySearch.GetIndex(arr, target);
        
        _stopwatch.Stop();

        TimeSpan binarySearchTime = _stopwatch.Elapsed;

        Console.WriteLine($"Binary search result: {binarySearchTime}");
    }
}