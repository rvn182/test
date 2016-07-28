using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Permutations;

namespace testLibrary
{
    class Program
    {
        private static object identityPermutation;

        static void Main(string[] args)
        {
            int[] ejb = CreateIdentityPermutation(165465465);
            for (int i = 0; i < ejb.Length; i++)
                Console.WriteLine(ejb[i]);
            Console.ReadLine();
        }

        static public int[] VectorByNumber(int number, int n)
        {
            int[] vectorOfInversion = new int[n];
            int factorial;

            number--;
            n--;
            for(int i=0;i<vectorOfInversion.Length;i++)
            {
                factorial = MathFunctions.Factorial(n);
                vectorOfInversion[i] = number / factorial;
                number = number % factorial;
                n--;
            }

            return vectorOfInversion;
        }
        
        static public int[] VectorToPermutation(int[] vectorOfInversions)
        {
            int[] indentityPermutation = CreateIdentityPermutation(vectorOfInversions.Length);                   
            bool[] logicArray = new bool[vectorOfInversions.Length];
            int[] permutation = new int[vectorOfInversions.Length];


            return permutation;
        }

        static public int[] CreateIdentityPermutation(int n)
        {
            if (n < 2) throw new Exception("Bad number elements of permutation.");

            int[] identityPermutation = new int[n];

            for (int i = 0; i < n; i++)
                identityPermutation[i] = i + 1;

            return identityPermutation;
        }

    }
}
