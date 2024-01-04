using Algorithms_And_Data_Structure.Models;

namespace Algorithms_And_Data_Structure.Hash;

public class HashMap<TKey, TValue>
{
    private KeyValuePairs<TKey, TValue>[] _entries = new KeyValuePairs<TKey, TValue>[8];
    private int size = 8;
    private int count;

    private int HashFunction(TKey key)
    {
        return key.GetHashCode();
    }

    private int FindIndex(TKey key)
    {
        int hash = HashFunction(key);
        int index = hash % size;

        for (int i = 0; i<size; i++)
        {
            int inx = (index + i) % size;
            KeyValuePairs<TKey, TValue> entry = _entries[inx];
            if (entry == null || entry.Key.Equals(key))
            {
                return inx;
            }
        }
        
        return -1;
    }

    public void Add(TKey key, TValue value)
    {
        int index = FindIndex(key);

        _entries[index] = new KeyValuePairs<TKey, TValue>(key, value);

        count += 1;

        if (count != size) return;
        
        int newSize = size * 2;
            
        Resize(newSize);

    }

    private void Resize(int newSize)
    {
         KeyValuePairs<TKey, TValue>[] _newEntries = new KeyValuePairs<TKey, TValue>[newSize];

         for (int i = 0; i<size; i++)
         {
             KeyValuePairs<TKey, TValue> entry = _entries[i];

             int index = FindIndex(entry.Key);

             _newEntries[index] = entry;
         }

         _entries = _newEntries;

         size = newSize;
    }

    public TValue Get(TKey key)
    {
        int index = FindIndex(key);

        if (index == -1)
        {
            throw new ArgumentNullException($"Not found such key - {key}");
        }
        
        KeyValuePairs<TKey, TValue> entry = _entries[index];

        if (entry == null)
        {
            throw new ArgumentNullException($"Not found such key - {key}");
        }

        return entry.Value;
    }
}