using System;
using static System.Console;

namespace Array
{
    class Program
    {
        static int[] reverseArray(int[] a) 
        {

         int[] b = new int[a.Length];
         
         int j=0;

         for(int i=a.Length-1; i >= 0; i--)
         {
                b[j] = a[i];
                 j++;
         }

         return b;
       }

        static void Main(string[] args)
        {
            WriteLine("Program Reverse an Integer Array.");

            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            int[] res = reverseArray(arr);

            WriteLine(string.Join(" ", res));
        }
    }
}
