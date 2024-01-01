namespace Algorithms_And_Data_Structure.Models;

public class Data
{
    public List<int> data;

    public Data()
    {
        data = new List<int>();
    }

    public List<int> GetList(int capacity)
    {
        for (int i = 0; i < capacity; i++)
        {
            data.Add(i);
        }

        return data;
    }
}