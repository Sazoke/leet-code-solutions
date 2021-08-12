namespace Solution
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var source = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                var score = 0;
                while (i - score >= 0 && i + score < s.Length)
                {
                    if (s[i - score] == s[i + score])
                        score += 1;
                    else
                        break;
                }

                if (score * 2 - 1 > source.Length)
                    source = s.Substring(i - score + 1, score * 2 - 1);
                score = 0;
                
                while (i - score >= 0 && i + score + 1 < s.Length)
                {
                    if (s[i - score] == s[i + 1 + score])
                        score += 1;
                    else
                        break;
                }

                if (score * 2 > source.Length)
                    source = s.Substring(i - score + 1, score * 2);
            }

            return source;
        }
    }
}