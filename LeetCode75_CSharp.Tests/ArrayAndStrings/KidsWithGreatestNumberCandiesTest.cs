using LeetCode75_CSharp.ArrayAndStrings;

namespace LeetCode75_CSharp.Tests.ArrayAndStrings;

public class KidsWithGreatestNumberCandiesTest
{
    [Theory]
    [InlineData(new int[]{1,1}, 1, new bool[]{true,true})]
    [InlineData(new int[]{2, 5, 4, 3, 2}, 3, new bool[]{true, true, true, true, true})]
    public void ShouldReturnAllTrue_WhenAllKidsCanReachMaxWithExtra(int[] candies, int extraCandies, bool[] expected)
    {
        var kidsGnOfCandies = new KidsWithGreatestNumberCandies();

        var result = kidsGnOfCandies.KidsWithCandies(candies, extraCandies);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new int[]{1,2,11}, 5, new bool[]{false, false, true})]
    [InlineData(new int[]{5,5,1}, 1, new bool[]{true, true, false})]
    [InlineData(new int[]{4,2,1,1,2}, 1, new bool[]{true, false, false, false, false})]
    public void ShouldReturnOnlyOneTrue_WhenOnlyOneKidCanReachMaxWithExtra(int[] candies, int extraCandies, bool[] expected)
    {
        var kidsGnOfCandies = new KidsWithGreatestNumberCandies();

        var result = kidsGnOfCandies.KidsWithCandies(candies, extraCandies);
        
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[]{2,13,5,1,9}, 4, new bool[]{false,true, false, false, true})]
    [InlineData(new int[]{12,1,2}, 10, new bool[]{true, false, true})]
    public void ShouldSReturnMixedResults_WhenSomeKidsCanReachMaxWithExtra(
        int[] candies,
        int extraCandies,
        bool[] expected)
    {
        var kidsGnOfCandies = new KidsWithGreatestNumberCandies();
        
        var result = kidsGnOfCandies.KidsWithCandies(candies, extraCandies);
        
        Assert.Equal(expected, result);
    }
}