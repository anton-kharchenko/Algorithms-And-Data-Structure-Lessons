using Algorithms_And_Data_Structure.Models;
using Algorithms_And_Data_Structure.Search.Binary;


const int capacity = 64;
Data _data = new Data();
List<int> sortedList = _data.GetSortedList(capacity);
List<int> sortedListWithDuplicates = _data.GetSortedListWithDuplicates(capacity);

Performance performance = new Performance();
performance.CompareBinaryAndLinearSearch(sortedList, 63);

BinarySearch binarySearch = new BinarySearch();
int insetIndex = binarySearch.FindInsertPlace(sortedListWithDuplicates, 40);
Console.WriteLine($"Index for insert equals: {insetIndex}");
