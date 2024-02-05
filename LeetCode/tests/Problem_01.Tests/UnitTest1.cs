using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace problems.Problem_01;

[TestClass]
public class SolutionTests
{
    [TestMethod]
    public void TestMergeAlternately()
    {
        // Arrange
        Solution solution = new Solution();

        // Act
        string result = solution.MergeAlternately("party", "rocks");

        // Assert
        Assert.AreEqual("praorctkys", result);
    }

    // Add more test methods as needed to cover different scenarios
}
