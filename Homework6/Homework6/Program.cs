using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{

    /// <summary>
    /// Task for the weekend:
 ///  Create a program for sorting the array of numbers which are input by the user(user inputs the length of the array, and then enters the numbers one by one,
 ///  print out the unsorted array,
 ///  Create a class which will have two methods, one for sorting in ascending and one for descending order,
 ///  print out the two sorted arrays.
 ///
 ///  Hope that won't be too much :)

    /// 
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lenght of array");
            Console.WriteLine();
            int l = 0;
            l = int.Parse(Console.ReadLine());
            int[] array = new int[l];

            Console.WriteLine("Please enter numbers of array");
            for (int i = 0; i < l; i++)
            {
                
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Unsorted array");
            for (int i = 0; i < l; i++)
            {

                Console.Write($" {array[i]}");
            }

            BubbleSort sort = new BubbleSort();

            sort.SortedAscending(array,l);
            Console.WriteLine("");
            Console.WriteLine("SortedAscending looks like");

            for (int i = 0; i < l; i++)
            {
                Console.Write($" {array[i]}");
            }

            sort.SortedDescending(array, l);
            Console.WriteLine("");
            Console.WriteLine("SortedDescending looks like");

            for (int i = 0; i < l; i++)
            {
                Console.Write($" {array[i]}");
            }


            Console.ReadKey();
        }
    }
}
