GenericClass<int> genericClass = new GenericClass<int>();

Console.WriteLine("GenericClass<T> of int objects");
for (int i = 0; i < 5; i++)
{
    genericClass[i] = (i + 1) * 10;
    Console.Write(genericClass[i] + "; ");
}

public class GenericClass<T>
{
    public T[] Objects = new T[5];
    // public List<T> Objects = new List<T>();
    public int Indexer = 0;
    
    public void Add(T item)
    {
        if (Indexer < Objects.Length)
        {
            Objects[Indexer] = item;
        }
        else
        {
            Console.WriteLine("Your array is already full");
        }
        Indexer++;
        // Objects.Add(item);
    }
    
    //Indexer
    public T this[int index]
    {
        get => Objects[index];
        set => Objects[index] = value;
    }
}