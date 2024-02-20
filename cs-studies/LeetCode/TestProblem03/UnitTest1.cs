public class TestProblem03
{
    [Fact]
    public void TestSolution()
    {
        Solution solution = new Solution();

        int[] kids = new int[] { 1, 7, 8, 10 };
        int extraCandies = 5;

        List<bool> expectedResult = new List<bool>() { false, true, true, true }; 
        
        Assert.Equal(expectedResult, solution.KidsWithCandies(kids, extraCandies));
    }
    
}