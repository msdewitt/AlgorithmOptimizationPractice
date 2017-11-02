using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PalindromePermutation
    {
       public static bool isPalindrome(string gibberish)
        {
            bool isPalindrome = true;
            bool centerUsed = false;
            char center;
            Hashtable ht = new Hashtable();

            for (int i =0; i< gibberish.Length; i++)
            {

                if (ht.Contains(gibberish[i]))
                {
                    char c = gibberish[i];
                    ht[c] = Int32.Parse(ht[c].ToString()) + 1;
                }

                if (gibberish[i] != ' ' && !ht.Contains(gibberish[i]))
                {
                    ht.Add(gibberish[i], 1);
                }

            }

                foreach (char key in ht.Keys)
            {
                if (centerUsed == true)
                {
                    if(Int32.Parse(ht[key].ToString())%2 == 1)
                    {
                        isPalindrome = false;
                    }
                }

                if (Int32.Parse(ht[key].ToString()) == 1 && centerUsed == false)
                {
                    center = key;
                    centerUsed = true;
                }

            }
            return isPalindrome;
            //Console Output
            //Brute Force Algorithm: O(1) runtime, O(1) space (If you don't consider creating the hashtable part of the algorithm.)
            // ------------------------------------ -
            //Given a string, write a function to check if it is a permutation of a palindrome:

            //String: 'tact coa': True
            //String: 'aabb t s   ': False
            //---------------------------------------------------------- -
        }
    }
}
