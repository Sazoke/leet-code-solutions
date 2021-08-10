using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class Solution
    {
        public int MinFlipsMonoIncr(string s)
        {
            var oneCount = 0;
            var flipCount = 0;
            foreach (var number in s)
            {
                if (number == '0')
                {
                    if(oneCount == 0)
                        continue;
                    flipCount++;
                }
                else
                    oneCount++;

                if (oneCount < flipCount)
                    flipCount = oneCount;
            }

            return flipCount;
        }
    }
}