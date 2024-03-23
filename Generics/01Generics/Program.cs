
GenericClass<int, int> genericClass = new GenericClass<int, int>();

int num1 = 10;
int num2 = 10;

float float1 = 10;
float float2 = 10;

string string1 = "10";
string string2 = "10";

//It would be necessary to create another class if I wanted to compare two floats
// Test.Compare(float1, float2); 

Test.CompareUsingGeneric(num1, num2);
Test.CompareUsingGeneric(float1, float2);
Test.CompareUsingGeneric(string1, string2);

public class Test
{
    // public static bool Compare(int num1, int num2)
    // {
    //     var result = num1.Equals(num2);
    //     return result;
    // }

    public static bool CompareUsingGeneric<T>(T value1, T value2)
    {
        var result = value1.Equals(value2);
        Console.WriteLine("\n###################################################");
        Console.WriteLine($"The types: {value1.GetType()} e {value2.GetType()}");
        Console.WriteLine($"{value1} e {value2} are equal? {result}");
        Console.WriteLine("###################################################");
        return result;
    } 
    
}

public class GenericClass<T1, T2>
{
    public static bool Compare(T1 value1, T2 value2)
    {
        var result = value1.Equals(value2);
        return result;
    }
}