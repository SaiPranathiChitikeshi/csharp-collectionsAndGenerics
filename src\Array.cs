using System;
using System.Collections.Generic;

namespace arr
{
    class Program
    {
       public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] ar=new int[] {1,2,3,5,4};
            int b=6;
            var r=sumtarget(ar,b);
            Console.WriteLine(r);

        }
        public static bool sumtarget(int[] arr,int target){
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = arr[i] + arr[k];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
