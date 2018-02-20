using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


    class Solution
{
    public static int simpleArraySum(int n, int[] ar)
    {
        // Complete this function
        int sum = 0;
        

        for (n = 0; n < ar.Length; n++)
        {
            sum += ar[n];
            
        }
        return sum;
       
    }

    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}