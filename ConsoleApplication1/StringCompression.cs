using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringCompression
    {
        public static string compressString(string input)
        {
            string output = "";
            int counter = 1;
            //Order the string alphabetically
            string sortedInput = String.Concat(input.OrderBy(c => c));
            //Go through each character and test to see if it is the same as the previous
            for (int i = 0; i < sortedInput.Length; i++)
            {
                if(i == 0)
                {
                    output += sortedInput[i];
                }
                else
                {
                    if(sortedInput[i] == sortedInput[i - 1])
                    {
                        counter++;
                        if(i == sortedInput.Length-1)
                        {
                            output += counter.ToString();
                        }
                    }
                    if (sortedInput[i] != sortedInput[i - 1] && counter == 1)
                    {
                        output += sortedInput[i];
                    }
                    if (sortedInput[i] != sortedInput[i - 1] && counter > 1)
                    {
                        output += counter.ToString();
                        counter = 1;
                        output += sortedInput[i];
                    }

                }
            }
            return output;
        }
    }
}
