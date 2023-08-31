public class Solution {
    public string LongestPalindrome(string s) {
         int maxLength = 1;
    string maxLengthStr = s.Substring(0, 1); 
    
    for (int i = 0; i < s.Length; i++)
    {
        // Odd Palindrome
        int L = i; int R = i;
        while (L >= 0 && R < s.Length && s[L] == s[R])
        {
            if (R - L + 1 > maxLength)
            {
                maxLength = R - L + 1;
                maxLengthStr = s.Substring(L, R - L + 1);
            }
            L--;
            R++;
        }

        // Even Palindrome
        L = i; R = i + 1;
        while (L >= 0 && R < s.Length && s[L] == s[R])
        {
            if (R - L + 1 > maxLength)
            {
                maxLength = R - L + 1;
                maxLengthStr = s.Substring(L, R - L + 1);
            }
            L--;
            R++;
        }
    }
    return maxLengthStr;
    }
}