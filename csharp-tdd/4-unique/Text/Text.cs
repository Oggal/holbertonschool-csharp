using System;

namespace Text
{
    public static class Str
    {
        public static int UniqueChar(string s)
        {
            if( s == null || s.Length == 0)
                return -1;
            int index = 0;
            for(int i = 1; i < s.Length; i++)
            {
                if(index == s.Length)
                    return -1;
                if(s[index] == s[i] && !(index == i))
                {
                    index++;
                    i = -1;
                    continue;
                }
            }
            
            return index;
        }
    }
}
