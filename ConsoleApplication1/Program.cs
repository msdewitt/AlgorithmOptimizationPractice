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
        }
    }
}
