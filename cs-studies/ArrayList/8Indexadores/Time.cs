namespace _8Indexadores;

public class Team
{
    //define array limits
    string[] values = new string[10];

    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < values.Length)
            {
                return values[i];
            }
            return "Erro";
        }

        set
        {
            if (i >= 0 && i < values.Length)
            { 
                values[i] = value;
            }
        }
    }
}