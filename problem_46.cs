/*This problem was asked by Amazon.

Given a string, find the longest palindromic contiguous substring.
If there are more than one with the maximum length, return any one.

For example, the longest palindromic substring of "aabcdcb" is "bcdcb". 
The longest palindromic substring of "bananas" is "anana".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem46
{
    class problem46
    {
        public string longestPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            string longest = "";
            //Odd
            for (int i = 0; i < str.Length; i++)
            {
                int l = i;
                int r = i;

                string current = "";
                while (l >= 0 && str.Length)
                {
                    if (str[l] != str[r]) break;
                    if (l == r)
                    {
                        current += str[l].ToString();
                    }
                    else
                    {
                        current = str[l].ToString() + current + str[r].ToString();
                    }
                    l--;
                    r++;
                }
                if (current.Length > longest.Length)
                {
                    longest = current;
                }

                //Even
                l = i;
                r = i + 1;
                current = "";
                while (l >= 0 && r < str.Length)
                {
                    if (str[l] != str[r]) break;
                    if (l == r)
                    {
                        current += str[l].ToString();
                    }
                    else
                    {
                        current = str[l].ToString() + current + str[r].ToString();
                    }
                    l--;
                    r++;
                }
                if (current.Length > longest.Length) longest = current;

            }
        }
    }
}