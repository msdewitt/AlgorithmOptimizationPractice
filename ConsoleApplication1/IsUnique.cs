using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IsUnique
    {

        public static bool containsUnique(string test)
        {
            bool doesContain = true;
            ArrayList arrayL = new ArrayList();
            for (int i = 0; i < test.Length; i++)
            {
                if (arrayL.Contains(test[i]))
                {
                    doesContain = false;
                }
                arrayL.Add(test[i]);
            }
            return doesContain;

            //Console Output
            //Algorithm: O(N) runtime, O(N) space
            // ------------------------------------ -
            //  Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you cannot use additional data structures?

            //String: reww, Contains Unique Characters: False

            //String: abcdefg, Contains Unique Characters: True

            //---------------------------------------------------------- -
        }

    }
}
