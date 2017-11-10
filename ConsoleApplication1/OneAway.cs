using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OneAway
    {

        //One Away: There are three types of edits that can be performed on strings: insert a character,
        //remove a character, or replace a character.Given two strings, write a function to check if they are
        //one edit (or zero edits) away.
        public static bool isOneEditAway(string mainString, string editedString)
        {
            int numOfEdits = 0;
            if(Math.Abs(mainString.Length - editedString.Length) == 1)
            {
                numOfEdits++;
            }
            
            for(int i =0; i < mainString.Length; i++)
            {
                bool key = true;
                if(!editedString.Contains(mainString[i]) && mainString.Length - editedString.Length == 1)
                {
                    
                    key = false;
                }
                if (!editedString.Contains(mainString[i]) && key == true)
                {
                    numOfEdits++;
                }

            }
            
            if(numOfEdits > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
            //Console Output
            //Algorithm: O(n) runtime, O(1) space 
            // ------------------------------------ -
            //One Away: There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character.

            //Parent String: 'bake', String to test: 'cake'
            //IsOneEditAway: True

            //Parent String: 'ake', String to test: 'cake'
            //IsOneEditAway: True

            //Parent String: 'bcake', String to test: 'cake'
            //IsOneEditAway: True

            //Parent String: 'bbake', String to test: 'cake'
            //IsOneEditAway: False

            //---------------------------------------------------------- -
        }
    }
}
