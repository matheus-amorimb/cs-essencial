namespace ExerciseInterfaces;

public interface ISave
{
    void Save();

    void Compress()
    {
        Console.WriteLine("Compressing file...");
    }
}