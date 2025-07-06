public int LengthOfLongestSubstring(string s)
{

    Dictionary<char, int> map = new Dictionary<char, int>();
    int maxL = 0;
    if (s.Length == 0)
        return 0;
    else
    {
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                j = Math.Max(j, map[s[i]] + 1);
            }
            map[s[i]] = i;
            maxL = Math.Max(maxL, i - j + 1);
        }
        return maxL;

    }
}
        
  