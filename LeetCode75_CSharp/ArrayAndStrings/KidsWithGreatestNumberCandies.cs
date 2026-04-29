using System.Linq;

namespace LeetCode75_CSharp.ArrayAndStrings;

public class KidsWithGreatestNumberCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandies = candies.Max();
        var kidsGNofCandies = new List<bool>();
        
        for (var i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= maxCandies)
                kidsGNofCandies.Add(true);
            else
                kidsGNofCandies.Add(false);
        }
        return kidsGNofCandies;        
    }
}