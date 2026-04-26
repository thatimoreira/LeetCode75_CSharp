using System.Text;

namespace LeetCode75_CSharp.ArrayAndStrings;

public class MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        var wordsJoined = new StringBuilder();
        word1 ??= string.Empty;
        word2 ??= string.Empty;
        var word1Length = word1.Length;
        var word2Length = word2.Length;
        var w1Count = 0;
        var w2Count = 0;
        wordsJoined.Capacity = word1Length + word2Length;
        
        if (word1Length == 0 && word2Length == 0) return "";

        while ((w1Count <= word1Length - 1) && (w2Count <= word2Length - 1))
        {
            wordsJoined.Append(word1[w1Count]);
            wordsJoined.Append(word2[w2Count]);
            w1Count++;
            w2Count++;
        }

        while ((w1Count <= word1Length - 1) && (w2Count == word2Length))
        {
            wordsJoined.Append(word1[w1Count]);
            w1Count++;
        }

        while ((w2Count <= word2Length - 1) && (w1Count == word1Length))
        {
            wordsJoined.Append(word2[w2Count]);
            w2Count++;
        }

        return wordsJoined.ToString();
    }
}