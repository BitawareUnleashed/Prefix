var ts = DateTime.Now;
Console.WriteLine(Solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));

var tt= DateTime.Now - ts;

Console.WriteLine("ns: " + tt.TotalMilliseconds);

Console.ReadLine();


public static class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        int minLength = int.MaxValue;
        foreach (var str in strs)
        {
            if (str.Length < minLength) minLength = str.Length;
        }

        for (int i = 0; i < minLength; i++)
        {
            char currentChar = strs[0][i];
            foreach (var str in strs)
            {
                if (str[i] != currentChar)
                    return strs[0].Substring(0, i);
            }
        }

        return strs[0].Substring(0, minLength);
    }
}
