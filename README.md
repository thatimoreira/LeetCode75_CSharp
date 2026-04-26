# LeetCode 75 — C#

Solutions to the [LeetCode 75](https://leetcode.com/studyplan/leetcode-75/) study plan implemented in C# with unit tests.

## Problems

| # | Problem | Difficulty | Category | Solution |
|---|---------|------------|----------|----------|
| 1768 | [Merge Strings Alternately](https://leetcode.com/problems/merge-strings-alternately/) | Easy | Arrays & Strings | [Solution](LeetCode75_CSharp/ArrayAndStrings/MergeStringsAlternately.cs) |

## Notes

### 1768 — Merge Strings Alternately

**Approach:** Single loop iterating up to the length of the longer string using `StringBuilder`. When both strings have remaining characters, append alternately. When one is exhausted, append the remaining characters of the longer one in bulk using `StringBuilder.Append(string, startIndex, count)`.

**Time complexity:** O(n + m) — where n and m are the lengths of each string.  
**Space complexity:** O(n + m) — for the result string.