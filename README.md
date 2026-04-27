# LeetCode 75 — C#

Solutions to the [LeetCode 75](https://leetcode.com/studyplan/leetcode-75/) study plan implemented in C# with unit tests.

## Problems

| #    | Problem                          | Difficulty | Category         | Algorithm | Solution                                                                 |
|------|----------------------------------|------------|------------------|-----------|--------------------------------------------------------------------------|
| 1768 | [Merge Strings Alternately](https://leetcode.com/problems/merge-strings-alternately/) | Easy       | Arrays & Strings | ————      | [Solution](LeetCode75_CSharp/ArrayAndStrings/MergeStringsAlternately.cs) |
| 1071 | [Greatest Common Divisor of Strings](https://leetcode.com/problems/greatest-common-divisor-of-strings/) | Easy | Arrays & Strings | Euclidean | [Solution](LeetCode75_CSharp/ArrayAndStrings/GreatestCommonDivisorOfStrings.cs) |

<br>

## Notes

### 1768 — Merge Strings Alternately

**Approach:** Single loop iterating up to the length of the longer string using `StringBuilder`. When both strings have remaining characters, append alternately. When one is exhausted, append the remaining characters of the longer one in bulk using `StringBuilder.Append(string, startIndex, count)`.

**Time complexity:** O(n + m) — where n and m are the lengths of each string.  
**Space complexity:** O(n + m) — for the result string.

<br>

### 1071 — Greatest Common Divisor of Strings (GCD)

**Approach:** Applies the Euclidean algorithm to strings. While `str1` and `str2` differ, reduces the longer one by removing its prefix if it starts with the shorter one. If the prefix does not match, there is no common divisor and the method returns an empty string. When both strings become equal, that string is the GCD.

**Time complexity:** O(n + m) — each iteration reduces the total length by at least one string length.  
**Space complexity:** O(n + m) — due to string reassignment creating new string objects.