public class Solution {
    public int Compress(char[] chars) {
        if (chars.Length == 1)
        {
            return 1;
        }

        int p1 = 0;
        int p2 = 0;
        int p3 = 1;

        while (p2 < chars.Length)
        {
            char firstUnique = chars[p2];
            
            if (p3 < chars.Length) 
            {
                char secondUnique = chars[p3];
                if (firstUnique == secondUnique)
                {
                    p3++;

                    if (p3 < chars.Length)
                    {
                        continue;
                    }
                }
            }

            int charCount = p3 - p2;
            chars[p1] = firstUnique;
            p1++;

            if (charCount > 1) 
            {
                string countChars = charCount.ToString();
                foreach (var @char in countChars)
                {
                    chars[p1] = @char;
                    p1++;
                }
            }

            p2 = p3;
            p3++;
        }

        return p1;
    }
}