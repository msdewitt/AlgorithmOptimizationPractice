using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CreateURL
    {
        public static string URLify(string input, int length)
        {
            Hashtable ht = new Hashtable();
            string output = "";

            for (int i = 0; i < length; i++)
            {
                ht.Add(i, input[i]);

            }

            for (int i = 0; i < ht.Count; i++) //O(n) space, O(n) time
            {
                if (ht[i].ToString() == " ")
                {
                    ht[i] = "%20";
                }

                output += ht[i].ToString();
            }

            return output;

            //Console Output
            //Algorithm: O(N) runtime, O(N) space
            // ------------------------------------ -
            // Write a method to replace all spaces in a string with '%20:

            //String: 'Mr John Smith     ', Length: 13 = Mr % 20John % 20Smith

            //---------------------------------------------------------- -
        }
    }
}
