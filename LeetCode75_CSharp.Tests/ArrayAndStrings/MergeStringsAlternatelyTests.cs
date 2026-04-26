using LeetCode75_CSharp.ArrayAndStrings;

namespace LeetCode75_CSharp.Tests.ArrayAndStrings;

public class MergeStringsAlternatelyTests
{
    [Fact]
    public void ShouldReturnEmptyString_WhenAllStringsAreEmpty()
    {
        // Arrange
        var sb = new MergeStringsAlternately();

        // Act
        var result = sb.MergeAlternately("", "").ToString();

        // Assert
        Assert.Equal("", result);
    }
    
    [Fact]
    public void ShouldJoinStrings_WhenStringsHaveSameLength()
    {
        var word1 = "str1";
        var word2 = "str2";
        var sb = new MergeStringsAlternately();
        
        var result = sb.MergeAlternately(word1, word2);
        
        Assert.Equal("ssttrr12", result);
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

    [Fact]
    public void ShouldFail_WhenAtLeastOneStringIsNull()
    {
        var sb = new MergeStringsAlternately();
        
        var result = sb.MergeAlternately(null, null);
        
        Assert.Equal("" , result);
    }
}