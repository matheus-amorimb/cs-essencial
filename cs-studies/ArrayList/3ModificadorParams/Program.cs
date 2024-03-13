int[] array = {1, 2, 3, 4};
int[] array2 = new int[]{1, 2, 3, 4};

var result = Calculate.Sum(1, 2, 3, 4);

Console.WriteLine(result);
public class Calculate
{
    public static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach(var number in numbers)
        {
            total += number;
        }
        return total;
    }
}

