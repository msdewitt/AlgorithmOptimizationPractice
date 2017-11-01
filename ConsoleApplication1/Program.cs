using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



            //Question:  Given two sorted arrays, find the number of elements in common. The arrays are the same length
            //and each has all distinct elements. 

            //A: 13 27 35 40 49 55 59
            // B: 17 35 39 40 55 58 60

            //Brute Force: O(N^2)
            //Improved Algorithm: O(N(log(n)))
            //Perfect: O(N) runtime and O(1) space
            //BCR: O(N)

            Console.WriteLine("Brute Force Algorithm: O(N^2) runtime");
            Console.WriteLine("-------------------------------------");

            int[] arrayA = new int[] { 13, 27, 35, 40, 49, 55, 59 };
            int[] arrayB = new int[] { 17, 35, 39, 40, 55, 58, 60 };
            String answer = "";
            int loopTimes = 0;

            for (int i = 0; i< arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    loopTimes += 1;
                    if (arrayA[i] == arrayB[j])
                    {
                        answer = answer + arrayB[j] + " ";
                        
                    }
                }
            }
            Console.WriteLine(answer);
            Console.WriteLine("Loops:" + loopTimes);


            Console.WriteLine("Improved Algorithm via Binary Search: O(N(log(n))) runtime");
            Console.WriteLine("----------------------------------------------------------");


            String answer2 = "";

            for (int i = 0; i < arrayA.Length; i++)
            {
                int index = Array.BinarySearch(arrayB, arrayA[i]);
                    if (index > 0)
                    {
                        answer2 = answer2 + arrayA[i] + " ";
                    }
            }
            Console.WriteLine(answer2);

            Console.WriteLine("Improved Algorithm via HashTable: O(N) runtime and O(N) space");
            Console.WriteLine("-------------------------------------------------------------");

            Hashtable ht = new Hashtable();

            for (int i = 0; i < arrayB.Length; i++)
            {
                ht.Add(arrayB[i],arrayB[i]);
            }

                String answer3 = "";

            for (int i = 0; i < arrayA.Length; i++)
            {
                
                if (ht.Contains(arrayA[i]))
                {
                    answer3 = answer3 + arrayA[i] + " ";
                }
            }
            Console.WriteLine(answer3);

            Console.WriteLine("Improved Algorithm via HashTable: O(N) runtime and O(1) space");
            Console.WriteLine("-------------------------------------------------------------");


            String answer4 = "";
            int loopTimes2 = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {

                for (int j = 0; j < arrayB.Length; j++)
                {
                    loopTimes2 += 1;
                    if (arrayA[i] == arrayB[j])
                    {
                        
                        answer4 = answer4 + arrayB[j] + " ";
                        
                    }
                    if(arrayA[i] < arrayB[j])
                    {
                        j = arrayB.Length;
                    }
                }
            }
            Console.WriteLine(answer4);
            Console.WriteLine("Loops:" + loopTimes2);

            //Console Output
            //Brute Force Algorithm: O(N ^ 2) runtime
            // ------------------------------------ -
            //35 40 55
            // Loops: 49
            //  Improved Algorithm via Binary Search: O(N(log(n))) runtime
            //  ----------------------------------------------------------
            //  35 40 55
            //  Improved Algorithm via HashTable: O(N) runtime and O(N) space
            //  ------------------------------------------------------------ -
            //  35 40 55
            //   Improved Algorithm via HashTable: O(N) runtime and O(1) space
            //  ------------------------------------------------------------ -
            //  35 40 55
            //  Loops: 29

       //     Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you
        //   cannot use additional data structures ?
            string test1 = "reww";
            string test2 = "abcdefg";
            Console.WriteLine("Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you cannot use additional data structures ? \n");
            Console.WriteLine("String: " + test1 + ", Contains Unique Characters: " + containsUnique(test1) + "\n");
            Console.WriteLine("String: " + test2 + ", Contains Unique Characters: " + containsUnique(test2) + "\n");



            //Given two strings, write a method to decide if one is a permutation of the
            //other.
            string stringOne = "bbatabt";
            string stringTwo = "bat";
            Console.WriteLine("Given two strings, write a method to decide if one is a permutation of the other. \n");
            Console.WriteLine("StringOne: " + stringOne + " " + "StringTwo: " + stringTwo + ", Has Permutations: " + isPermutation(stringOne, stringTwo) + "\n");

            string urlString = "Mr John Smith     ";
            int length = 13;
            Console.WriteLine("Write a method to replace all spaces in a string with '%20:\n");
            Console.WriteLine("String: " + "'"+ urlString + "'" + ", Length: " + length + " = " + URLify(urlString, length) + " " + "\n");
           

        }
        private static bool containsUnique(string test) 
        {
            bool doesContain = true;
            ArrayList arrayL = new ArrayList();
            for (int i = 0; i < test.Length; i++)
            {   
                if (arrayL.Contains(test[i]))
                {
                    doesContain = false;
                }
                
                Console.WriteLine(arrayL.Contains(test[i]));
                arrayL.Add(test[i]);
            }
            return doesContain;
        }




        private static bool isPermutation(string one, string two)
        {
            var hasPerm = false;
            string[] permuations = findPermutations(two);
            for (int i = 0; i < permuations.Length; i++)
            {
                Console.WriteLine(permuations[i]);
            }
                
            for (int i =0; i< one.Length; i++)
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
                            
                            Console.WriteLine("Reset Success");
                        }
                        if (counter == perm.Length)
                        {
                            hasPerm = true;
                        }
                        if(perm[k] != one[i])
                        {
                            
                            Console.WriteLine("Reset");
                        }
                        k = perm.Length;

                    }
                }
            }
            return hasPerm;
        }
        private static string[] findPermutations(string message)
        {
            string variableMessage = message;
            string[] permutations = new string[message.Length];
            for (int i=0; i< variableMessage.Length; i++)
            {
                variableMessage = variableMessage.Substring(1, variableMessage.Length - 1) + variableMessage.Substring(0, 1);
                permutations[i] = variableMessage;
            }
            return permutations;
        }


        private static string URLify(string input, int length)
        {
            Hashtable ht = new Hashtable();
            string output = "";

            for (int i = 0; i < length; i++)
            {
                ht.Add(i, input[i]);

                Console.WriteLine(i);
            }

            for (int i = 0; i < ht.Count; i++) //O(n) space, O(n) time
            {
                if(ht[i].ToString() == " ")
                {
                    ht[i] = "%20";
                }
                Console.WriteLine(ht[i]);
                output += ht[i].ToString();
            }
            

                Console.WriteLine(output);
            return output;
        }
    }
}
