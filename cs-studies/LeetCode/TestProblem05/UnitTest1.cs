namespace TestProblem05;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Solution solution = new Solution();
        string value = "hello";
        string valueReturned = solution.ReverseVowels(value);
        string expectedValue = "hallo";
        
        Assert.Equal(expectedValue, valueReturned);
    }
}