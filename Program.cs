using System;
using System.Collections.Generic;
namespace genlis
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            List<int> n=new List<int>();
            n.Add(20);
            n.Add(3);
            n.Add(13);
            n.Add(17);
            n.Add(50);
            foreach (int t in n)
            {
                sum+=t;
            }
            System.Console.WriteLine(sum);
            n.Remove(13);
            Console.WriteLine(n.BinarySearch(50));
        }
    }
}
