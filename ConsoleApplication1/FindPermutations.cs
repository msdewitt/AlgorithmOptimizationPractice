using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FindPermutations
    {
        public static bool isPermutation(string one, string two)
        {
            var hasPerm = false;
            string[] permuations = findPermutations(two);
            for (int i = 0; i < permuations.Length; i++)
            {
               // Console.WriteLine(permuations[i]);
            }

            for (int i = 0; i < one.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < permuations.Length; j++)
                {
                    for (int k = 0; k < permuations[j].Length; k++)
                    {

                        string perm = permuations[j];

                        if (perm[k] == one[i])
                        {
                            counter++;

                        }
                        if (counter == perm.Length)
                        {
                            hasPerm = true;
                        }
                        if (perm[k] != one[i])
                        {


                        }
                        k = perm.Length;

                    }
                }
            }
            return hasPerm;

            //Console Output
            //Brute Force Algorithm: O(N^3) runtime, O(N) space
            // ------------------------------------ -
            //Given two strings, write a method to decide if one is a permutation of the other.

            // StringOne: bbatabt StringTwo: bat, Has Permutations: False

            //---------------------------------------------------------- -
        }
        private static string[] findPermutations(string message)
        {
            string variableMessage = message;
            string[] permutations = new string[message.Length];
            for (int i = 0; i < variableMessage.Length; i++)
            {
                variableMessage = variableMessage.Substring(1, variableMessage.Length - 1) + variableMessage.Substring(0, 1);
                permutations[i] = variableMessage;
            }
            return permutations;
        }
    }
}
