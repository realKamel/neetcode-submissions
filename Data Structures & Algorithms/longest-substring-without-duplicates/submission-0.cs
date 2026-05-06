public class Solution {
    public int LengthOfLongestSubstring(string s) {
                if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        if (s.Length == 1)
        {
            return 1;
        }
        var chars = new Dictionary<char, int>(26);
        int maxLength = int.MinValue;

        for (int i = 0; i < s.Length; i++) // increment must change
        {
            int currentLength = 0;
            for (int j = i; j < s.Length; j++)
            {
                if (chars.TryAdd(s[j], j))
                {
                    currentLength++;
                }
                else
                {
                    chars.TryGetValue(s[j], out int newIndex);
                    i = newIndex;
                    chars.Clear();
                    break;
                }
            }
            maxLength = maxLength > currentLength ? maxLength : currentLength;
        }
        return maxLength;
    }
}