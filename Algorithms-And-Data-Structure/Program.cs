using Algorithms_And_Data_Structure.Models;
using Algorithms_And_Data_Structure.Search.Binary;

const int capacity = 64;
Data _data = new Data();
// List<int> sortedList = _data.GetSortedList(capacity);
//
// Performance performance = new Performance();
// performance.CompareBinaryAndLinearSearch(sortedList, 63);

List<int> sortedListWithDuplicates = _data.GetSortedListWithDuplicates(capacity);
BinarySearch binarySearch = new BinarySearch();
int insetIndex = binarySearch.FindInsertionPlace(sortedListWithDuplicates, 40);
Console.WriteLine($"Index for insert equals: {insetIndex}");
