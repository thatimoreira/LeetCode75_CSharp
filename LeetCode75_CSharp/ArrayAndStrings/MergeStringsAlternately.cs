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
        var maxLength = Math.Max(word1Length, word2Length);
        wordsJoined.Capacity = word1Length + word2Length;
        
        for (var i = 0; i < maxLength; i++)
        {
            if ((i < word1Length) && (i < word2Length))
            {
                wordsJoined.Append(word1[i]);
                wordsJoined.Append(word2[i]);
            }
            else
            {
                if (i < word1Length)
                {
                    return wordsJoined.Append(word1, i, word1Length - i).ToString();
                }
                else if (i < word2Length)
                {
                    return wordsJoined.Append(word2, i, word2Length - i).ToString();
                }
            }   
        }

        return wordsJoined.ToString();
    }
}