using System;

namespace Substring
{
    public static class StringExtensions
    {
        public static int MySubstring(this string sourceString, string substring)
        {
            if (sourceString.Length < substring.Length)
            {
                return -1;
            }

            for (int i = 0; i < sourceString.Length - (substring.Length - 1); i++)
            {
                if (IsSubstring(sourceString, substring, i))
                {
                    return i;
                }
            }

            return -1;
        }

        private static bool IsSubstring(string sourceString, string substring, int sourceIndexOffset)
        {
            for (int i = 0; i < substring.Length; i++)
            {
                if (char.ToUpperInvariant(sourceString[i + sourceIndexOffset]) != char.ToUpperInvariant(substring[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
