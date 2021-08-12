using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class Solution
    {
        public List<string>[] GroupAnagrams(string[] strs)
        {
            var result = new List<List<string>>();
            var dict = new Dictionary<string, int>();
            foreach (var str in strs)
            {
                var copy = new string(str.OrderBy(c => c).ToArray());
                if (!dict.ContainsKey(copy))
                {
                    dict[copy] = result.Count;
                    result.Add(new List<string>() {str});
                }
                else
                    result[dict[copy]].Add(str);
            }

            return result.ToArray();
        }
    }
}