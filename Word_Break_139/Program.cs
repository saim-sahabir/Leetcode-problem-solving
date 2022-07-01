// See https://aka.ms/new-console-template for more information




 Console.WriteLine(WordBreak("bb", new List<string>() { "a","b","bbb","bbbb" }));
bool WordBreak(string s, IList<string> wordDict)
{
    var str = String.Concat(wordDict).ToLower();
     
    int mash = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str.Length > s.Length)
        {
            break;
            return false; 
        }
        else
        {
            if ( str[i] == s[i])
            {
                mash++;
            }
            else
            {
                break;
            }
        }

    }

    if (mash == str.Length)
    {
        return true;
    }
    else
    {
         return false;
    }
}