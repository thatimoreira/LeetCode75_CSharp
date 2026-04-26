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
    
//     public string MergeAlternately(string word1, string word2)
//     {
//         public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
//         protected static char[] dest = new char[6];
//         public static void Main()
//         {
//             StringBuilder src = new StringBuilder("abcdefghijklmnopqrstuvwxyz!");
//             dest[1] = ')';
//             dest[2] = ' ';
//
//     // Copy the source to the destination in 9 pieces, 3 characters per piece.
//
//             Console.WriteLine("\nPiece) Data:");
//             for(int ix = 0; ix < 9; ix++)
//             {
//                 dest[0] = ix.ToString()[0];
//                 src.CopyTo(ix * 3, dest, 3, 3);
//                 Console.Write("    ");
//                 Console.WriteLine(dest);
//             }
//         }
//         /*
//         This example produces the following results:
//
//         Piece) Data:
//             0) abc
//             1) def
//             2) ghi
//             3) jkl
//             4) mno
//             5) pqr
//             6) stu
//             7) vwx
//             8) yz!
//             */
//         StringBuilder src = new StringBuilder("abcdefghijklmnopqrstuvwxyz!");
//
//         StringBuilder wordsJoined = new StringBuilder();
//         int word1Length = word1.Length;
//         int word2Length = word2.Length;
//         int w1Count = 0;
//         int w2Count = 0;
//         wordsJoined.Capacity = word1Length + word2Length;
//
//         if (word1Length == 0 && word2Length == 0) return "";
//
//         while (w1Count < word1Length || w2Count < word2Length)
//         {
//             if (word1[w1Count] && word2[w2Count])
//             {
//                 wordsJoined.Append(word1[w1Count]);
//                 wordsJoined.Append(word2[w2Count]);
//                 w1Count++;
//                 w2Count++;
//             }
//
//             if (word1[w1Count] && !word2[w2Count])
//             {
//                 wordsJoined.Append(word1[w1Count]);
//                 w1Count++;
//             }
//
//             if (word2[w2Count] && !word1[w1Count])
//             {
//                 wordsJoined.Append(word2[w2Count]);
//                 w2Count++;
//             }
//         }
//
//         return wordsJoined.ToString();
//     }
}