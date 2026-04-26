using LeetCode75_CSharp.ArrayAndStrings;

namespace LeetCode75_CSharp.Tests.ArrayAndStrings;

public class MergeStringsAlternatelyTests
{
    [Theory]
    [InlineData("", "")]
    [InlineData(null, null)]
    public void ShouldReturnEmptyString_WhenStringsAreEmptyOrNull(string? word1, string? word2)
    {
        // Arrange
        var sb = new MergeStringsAlternately();

        // Act
        var result = sb.MergeAlternately(word1, word2).ToString();

        // Assert
        Assert.Equal("", result);
    }
    
    [Theory]
    [InlineData("s1", "s2", "ss12")]
    [InlineData("str1", "str2", "ssttrr12")]
    public void ShouldJoinStrings_WhenStringsHaveSameLength(string word1, string word2, string expected)
    {
        var sb = new MergeStringsAlternately();
        
        var result = sb.MergeAlternately(word1, word2);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("str111", "str2", "ssttrr1211")]
    [InlineData("str1", "str22222", "ssttrr122222")]
    public void ShouldJoinStrings_WhenStringsHaveDifferentLengths(string word1, string word2, string expected)
    {
        var sb = new MergeStringsAlternately();
        
        var result = sb.MergeAlternately(word1, word2);
        
        Assert.Equal(expected , result);
    }
}