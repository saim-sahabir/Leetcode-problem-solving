




  Console.WriteLine(LengthOfLastWord("moon"));

     int LengthOfLastWord(string s)
     {
         int LastWordCount = 0;
         
         var st = s.Trim();
         
         for (int i =  st.Length-1; i >= 0; i--)
         {
             
             if (st[i] != ' ')
             {
                 LastWordCount++;
             }
             else
             {
                 break;
             }


         }
         return LastWordCount;
    }
