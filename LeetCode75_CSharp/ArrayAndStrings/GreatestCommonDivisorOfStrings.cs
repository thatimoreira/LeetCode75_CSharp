namespace LeetCode75_CSharp.ArrayAndStrings;

public class GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        var str1Length = str1.Length;
        var str2Length = str2.Length;

        while (!str1.Equals(str2))
        {
            if (str1Length > str2Length)
            {
                if (str1.StartsWith(str2))
                {
                    str1 = str1.Substring(str2Length);
                    str1Length -= str2Length;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                if (str2.StartsWith(str1))
                {
                    str2 = str2.Substring(str1Length);
                    str2Length -= str1Length;
                }
                else
                {
                    return "";
                }
            }
        }

        return str1;
    }
}