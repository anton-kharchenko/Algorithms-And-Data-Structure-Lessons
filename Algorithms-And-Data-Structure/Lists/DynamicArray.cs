namespace Algorithms_And_Data_Structure.Lists;

public class DynamicArray<T>
{
    private T?[] data = new T?[1];
    private int length = 0;

    public int GetLength()
    {
        return length;
    }

    public void Set(int index, T? value)
    {
        CheckArgument(index);

        data[index] = value;
    }

    public T? Get(int index)
    {
        CheckArgument(index);

        return data[index];
    }

    public void Add(T? value)
    {
        if (length == data.Length)
        {
            T?[] newData = new T[length * 2];
            for (int i = 0; i < length; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }

        data[length] = value;
        length += 1;
    }

    public void Insert(int index, T value)
    {
        T? dummy = default;
        if (dummy != null) Add(dummy);
        
        for (int i = length - 1; i >= index; i--)
        {
            data[i] = data[i - 1];
        }

        data[index] = value;
    }

    public void RemoveLast()
    {
        length -= 1;
        if (length * 4 < data.Length)
        {
            T?[] newData = new T[length/2];
            for (int i = 0; i < length; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }
    }

    private void CheckArgument(int index)
    {
        if (index > length - 1)
        {
            throw new ArgumentException($"Index {index} cannot be more than length of array");
        }
    }
}