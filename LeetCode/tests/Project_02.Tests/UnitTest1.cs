namespace Project_02.Tests;

[TestClass]
public class SolutionTests
{
    [TestMethod]
    public void GcdOfStrings()
    {
        Solution solution = new Solution();

        string result = solution.GcdOfStrings("ABABAB", "ABAB");

        Assert.AreEqual("AB", result);

    }
}