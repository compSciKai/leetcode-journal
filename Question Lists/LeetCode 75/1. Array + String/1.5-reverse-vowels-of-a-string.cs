public class Solution {
    private bool isVowel(char c)
    {
        switch (Char.ToLower(c))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }

    public string ReverseVowels(string s) {
        char[] resultArray = s.ToCharArray(); 

        int leftPointer = 0;
        int rightPointer = s.Length-1;
        while (leftPointer < rightPointer)
        {
            char leftChar = s[leftPointer];
            char rightChar = s[rightPointer];
            if (isVowel(leftChar) && isVowel(rightChar))
            {
                resultArray[leftPointer] = rightChar;
                resultArray[rightPointer] = leftChar;

                leftPointer++;
                rightPointer--;
            } else 
            {
                if (!isVowel(leftChar))
                {
                    leftPointer++;
                }

                if (!isVowel(rightChar))
                {
                    rightPointer--;
                }
            }
        } 

        return new String(resultArray);
    }
}