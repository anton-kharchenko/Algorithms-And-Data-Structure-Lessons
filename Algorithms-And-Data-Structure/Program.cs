using Algorithms_And_Data_Structure;
using Algorithms_And_Data_Structure.Models;


const int capacity = 1000000000;
Data _data = new Data();
List<int> _list = _data.GetList(capacity);

Performance performance = new Performance();
performance.CompareBinaryAndLinearSearch(_list, 999999999);