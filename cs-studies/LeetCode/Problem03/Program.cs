using System.Collections;

Solution solution = new Solution();
int[] kids = new int[] { 1, 4, 6, 8, 9};
List<bool> result = solution.KidsWithCandies(kids, 5).ToList();

foreach (var value in result)
{
    Console.WriteLine(value);
}
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> result = new List<bool>(candies.Length);
        
        int greatestAmount = candies.Max();

        foreach (int kidCandie in candies)
        { 
            result.Add(kidCandie + extraCandies >= greatestAmount);
        }

        return result;
    }
}