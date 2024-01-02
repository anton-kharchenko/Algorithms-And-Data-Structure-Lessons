using Algorithms_And_Data_Structure;
using Algorithms_And_Data_Structure.Models;


const int capacity = 64;
Data _data = new Data();
List<int> _list = _data.GetSortedList(capacity);

Performance performance = new Performance();
performance.CompareBinaryAndLinearSearch(_list, 63);