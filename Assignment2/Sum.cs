using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Sum
    {
        static void Main(string[] args)
        {

            // 1)Write a program in C# Sharp to find the sum of all elements of the array.
            
            
            int[] array = {2,3,4,5,6,7,8,9 };
            int sum = 0;

            foreach (int i in array)
            {
                sum += i;
                
            }
            Console.Write(sum + "\n ");
        }
    }
}
