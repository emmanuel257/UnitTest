using System;
using System.Collections.Generic;
using System.Text;

namespace EquivalentString
{
    public class Solution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var word1String = string.Join("", word1);
            var word2String = string.Join("", word2);
            return word1String == word2String;
        }
    }
}
