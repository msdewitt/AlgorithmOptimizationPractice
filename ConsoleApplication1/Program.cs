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

            ElementsInCommon.arrayComparator();


            // Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you
            //cannot use additional data structures ?
            string test1 = "reww";
            string test2 = "abcdefg";
            Console.WriteLine("Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you cannot use additional data structures ? \n");
            Console.WriteLine("String: " + test1 + ", Contains Unique Characters: " + IsUnique.containsUnique(test1) + "\n");
            Console.WriteLine("String: " + test2 + ", Contains Unique Characters: " + IsUnique.containsUnique(test2) + "\n");
            Console.WriteLine("-----------------------------------------------------------\n");


            //Given two strings, write a method to decide if one is a permutation of the
            //other.
            string stringOne = "bbatabt";
            string stringTwo = "bat";
            Console.WriteLine("Given two strings, write a method to decide if one is a permutation of the other. \n");
            Console.WriteLine("StringOne: " + stringOne + " " + "StringTwo: " + stringTwo + ", Has Permutations: " + FindPermutations.isPermutation(stringOne, stringTwo) + "\n");
            Console.WriteLine("-----------------------------------------------------------\n");
            //Write a method to replace all spaces in a string with '%20
            //
            string urlString = "Mr John Smith     ";
            int length = 13;
            Console.WriteLine("Write a method to replace all spaces in a string with '%20:\n");
            Console.WriteLine("String: " + "'"+ urlString + "'" + ", Length: " + length + " = " + CreateURL.URLify(urlString, length) + " " + "\n");
            Console.WriteLine("-----------------------------------------------------------\n");


            // Given a string, write a function to check if it is a permutation of a palindrome
            string trueTest = "tact coa";
            string falseTest = "aabb t s   ";
            Console.WriteLine("Given a string, write a function to check if it is a permutation of a palindrome:\n");
            Console.WriteLine( "String: " + "'" + trueTest + "'"+ ": " + PalindromePermutation.isPalindrome(trueTest));
            Console.WriteLine("String: " + "'" + falseTest + "'" + ": " + PalindromePermutation.isPalindrome(falseTest));
            Console.WriteLine("-----------------------------------------------------------\n");

        }

    }
}
