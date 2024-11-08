public class TwoSumTest
{
    // Test cases:
    // 1. nums = { 2, 7, 11, 15 }, target = 9
    // 2. nums = { 3, 2, 4 }, target = 6
    // 3. nums = { 3, 3 }, target = 6
    // 4. nums = { -1, -2, -3, -4, -5 }, target = -8

    [Fact]
    public void TwoSum_ReturnsCorrectIndices_ForValidInput()
    {
        // Arrange
        var twoSumSolution = new LeetCode.TwoSumSolution();
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;

        // Act
        var result = twoSumSolution.TwoSum(nums, target);

        // Assert that { 0, 1 } or { 1, 0 } is returned
        Assert.Contains(0, result);
        Assert.Contains(1, result);

    }

    [Fact]
    public void TwoSum_ReturnsCorrectIndices_ForValidInput2()
    {
        // Arrange
        var twoSumSolution = new LeetCode.TwoSumSolution();
        var nums = new int[] { 3, 2, 4 };
        var target = 6;

        // Act
        var result = twoSumSolution.TwoSum(nums, target);

        // Assert that { 1, 2 } or { 2, 1 } is returned
        Assert.Contains(1, result);
        Assert.Contains(2, result);

    }

    [Fact]
    public void TwoSum_ReturnsCorrectIndices_ForValidInput3()
    {
        // Arrange
        var twoSumSolution = new LeetCode.TwoSumSolution();
        var nums = new int[] { 3, 3 };
        var target = 6;

        // Act
        var result = twoSumSolution.TwoSum(nums, target);

        // Assert that { 0, 1 } or { 1, 0 } is returned
        Assert.Contains(0, result);
        Assert.Contains(1, result);

    }

    [Fact]
    public void TwoSum_ReturnsCorrectIndices_ForValidInput4()
    {
        // Arrange
        var twoSumSolution = new LeetCode.TwoSumSolution();
        var nums = new int[] { -1, -2, -3, -4, -5 };
        var target = -8;

        // Act
        var result = twoSumSolution.TwoSum(nums, target);

        // Assert that { 2, 4 } or { 4, 2 } is returned
        Assert.Contains(2, result);
        Assert.Contains(4, result);

    }

}
