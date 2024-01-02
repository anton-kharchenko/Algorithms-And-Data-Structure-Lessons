namespace Algorithms_And_Data_Structure.Models;

public class Data
{
    public List<int> data;

    public Data()
    {
        data = new List<int>();
    }

    public List<int> GetSortedList(int capacity)
    {
        IsCorrectCapacityRange(capacity);
        
        for (int i = 0; i < capacity; i++)
        {
            data.Add(i);
        }

        return data;
    }

    public List<int> GetRandomSortedList(int capacity)
    {
        IsCorrectCapacityRange(capacity);
        
        var random = new Random();
        data.Add(random.Next());
        
        for (int i = 1; i < capacity - 1; i++)
        {
            var prevValue = data[0];
            data.Add(prevValue + random.Next());
        }
        
        return data;
    }

    private void IsCorrectCapacityRange(int capacity)
    {
        if (capacity <= 1)
        {
            throw new ArgumentOutOfRangeException($"{capacity} must be more than 1");
        }
    }
}