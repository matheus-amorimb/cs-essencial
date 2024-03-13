namespace TestProblem05;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Solution solution = new Solution();
        string value = "hello";
        string valueReturned = solution.ReverseVowels(value);
        string expectedValue = "holle";
        
        Assert.Equal(expectedValue, valueReturned);
    }    
    
    [Fact]
    public void Test2()
    {
        Solution solution = new Solution();
        string value = "leetcode";
        string valueReturned = solution.ReverseVowels(value);
        string expectedValue = "leotcede";
        
        Assert.Equal(expectedValue, valueReturned);
    }
}