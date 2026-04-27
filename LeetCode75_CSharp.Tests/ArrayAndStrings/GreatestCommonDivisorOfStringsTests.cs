using LeetCode75_CSharp.ArrayAndStrings;

namespace LeetCode75_CSharp.Tests.ArrayAndStrings;

public class GreatestCommonDivisorOfStringsTests
{
    [Theory]
    [InlineData("TEST", "ABC")]
    [InlineData("LEET", "CODE")]
    [InlineData("AAAAAB", "AAA")]
    [InlineData("ABC", "TEST")]
    public void ShouldReturnEmptyString_WhenStr2DoesNotDivideStr1(string str1, string str2)
    {
        var sb = new GreatestCommonDivisorOfStrings();
        
        var result = sb.GcdOfStrings(str1, str2);
        
        Assert.Equal("", result);
    }
    
    [Theory]
    [InlineData("ABCABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("ABC", "ABCABC", "ABC")]
    [InlineData("ABC", "ABC", "ABC")]
    public void ShouldReturnGcd_WhenStr2DividesStr1(string str1, string str2, string expected)
    {
        var sb = new GreatestCommonDivisorOfStrings();
        
        var result = sb.GcdOfStrings(str1, str2);
        
        Assert.Equal(expected, result);
    }
}