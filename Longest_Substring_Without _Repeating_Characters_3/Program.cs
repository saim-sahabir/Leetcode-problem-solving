



   
Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
       


        int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            var str = s.Substring(1);
            List<char> cr = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (cr.Contains(str[i]) )
                {
                    count++;
                }
            }
            return count;
        }