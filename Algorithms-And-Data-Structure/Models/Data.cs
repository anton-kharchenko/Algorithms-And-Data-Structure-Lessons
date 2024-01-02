namespace Algorithms_And_Data_Structure.Models;

public class Data
{
    private readonly List<int> data = [];

    public List<int> GetSortedList(int capacity)
    {
        CheckCapacityRange(capacity);
        
        ClearData();
        
        for (int i = 0; i < capacity; i++)
        {
            data.Add(i);
        }

        return data;
    }

    public List<int> GetRandomSortedList(int capacity)
    {
        CheckCapacityRange(capacity);
        
        ClearData();
        
        var random = new Random();
        data.Add(random.Next());
        
        for (int i = 1; i < capacity - 1; i++)
        {
            var prevValue = data[0];
            data.Add(prevValue + random.Next());
        }
        
        return data;
    }
    
    public List<int> GetSortedListWithDuplicates(int capacity)
    {
        CheckCapacityRange(capacity);
        
        ClearData();
        
        for (int i = 0; i < capacity; i++)
        {
            if (i % 2 == 0 && i > 1)
            {
                var prevValue = data[i-1];
                data.Add(prevValue);
            }
            else
            {
                data.Add(i);
            }
        }

        return data;
    }

    private void CheckCapacityRange(int capacity)
    {
        if (capacity <= 1)
        {
            throw new ArgumentOutOfRangeException($"{capacity} must be more than 1");
        }
    }

    private void ClearData()
    {
        if (data.Count > 0)
        {
            data.Clear();
        }
    }
}