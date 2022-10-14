using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
     class BubbleSort
    {
 
   public void SortedAscending(int[] n , int d)
   {
       int p = 0;  
       for (int i = 0; i < d-1; i++)
       {
           for (int j = i+1 ; j < d; j++)
           {
               if(n[i] > n[j])
               {
                   p = n[i];
                   n[i] = n[j];
                   n[j] = p;
               }
           }
       }
   }
 
   public void SortedDescending(int[] n, int d)
   {
       int p = 0;
       for (int i = 0; i < d - 1; i++)
       {
           for (int j = i + 1; j < d; j++)
           {
               if (n[i] < n[j])
               {
                   p = n[i];
                   n[i] = n[j];
                   n[j] = p;
               }
           }
       }
 
   }
    }
}
