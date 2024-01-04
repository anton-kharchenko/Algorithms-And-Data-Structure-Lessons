namespace Algorithms_And_Data_Structure.Models;

public class KeyValuePairs<TKey, TValue>(TKey key, TValue value)
{
    public TKey Key = key;
    public TValue Value = value;
}