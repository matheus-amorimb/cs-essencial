namespace ExerciseInterfaces;

public class SaveXml : BaseFile, ISave
{
    public override void Name()
    {
        Console.WriteLine("Save file in Xml");
    }
    
    public void Save()
    {
        Console.WriteLine($"Saving file in Xml...");
    }
}