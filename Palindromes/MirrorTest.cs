using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Palindromes
{
    public class MirrorTest
    {
        public bool Mirror(string palindrome)
        {
            char[] charsToTrim = { ' ', ',', '!' };
            var lowerCasePalindrome = palindrome.ToLower();
            string trimPalindrome(string p, char[] chars)
            {
                return new string(p.Where(c => !chars.Contains(c)).ToArray());
            }
            var trimmedPalindrome = trimPalindrome(lowerCasePalindrome, charsToTrim);
            var mirroredPalindrome = new string(trimmedPalindrome.Reverse().ToArray());
            if (trimmedPalindrome == mirroredPalindrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
