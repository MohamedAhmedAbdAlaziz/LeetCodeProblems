public class Solution {
     public  bool ValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right - 1)
            {
                if (s[left] != s[right])
                {
                    if (isPalindrome(s, left, right - 1))
                    {
                        return true;
                    }
                    if (isPalindrome(s, left + 1, right))
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }

        public  bool isPalindrome(String input,
                                   int start, int i)
        {
            while (start < i)
            {
                if (input[start++] != input[i--])
                    return false;
            }
            return true;
        }
}