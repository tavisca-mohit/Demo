using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] A)
        {
            int indexOfMinusone = Array.IndexOf(A, -1);
            if ((indexOfMinusone >= 2))
            {
                if (indexOfMinusone <= A.Length - 2)
                {
                    A[indexOfMinusone] = A[indexOfMinusone + 1] - (A[indexOfMinusone - 1] + A[indexOfMinusone - 2]);
                }
            }
            if (indexOfMinusone == 0)
            {
                A[indexOfMinusone] = A[indexOfMinusone + 3] - (A[indexOfMinusone + 2] + A[indexOfMinusone + 1]);

            }
            if (indexOfMinusone == 1)
            {
                A[indexOfMinusone] = A[indexOfMinusone + 2] - A[indexOfMinusone + 1] - A[indexOfMinusone - 1];
            }

            if (indexOfMinusone == A.Length - 1)
            {
                A[indexOfMinusone] = A[indexOfMinusone - 1] + A[indexOfMinusone - 2] + A[indexOfMinusone - 3];

            }

            if (Checkseries(A))
            {
                return A[indexOfMinusone];
            }
            else
            {
                return -1;
            }

        }
        public bool Checkseries(int[] A)
        {
            for (int index = 3; index < A.Length; index++)
            {
                if (A[index] != A[index - 1] + A[index - 2] + A[index - 3])
                {
                    return false;
                }
            }
            return true;

        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
				string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate(string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}