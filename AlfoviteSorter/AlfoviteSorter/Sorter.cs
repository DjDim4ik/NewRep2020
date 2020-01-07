using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfoviteSorter
{
    class Sorter
    {
        public static int[] Sort(int[] mas)
        {
            int a;
            for(int i=0;i<mas.Length;i++)
            {
                for(int j=0;j<mas.Length-1;j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        a = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = a;
                    }
                }
            }
            return mas;
        }
        
        public static int[] SortDesc(int[] mas)
        {
            int a;
            for(int i=0;i<mas.Length;i++)
            {
                for(int j=0;j<mas.Length;j++)
                {
                    if(mas[j]<mas[j+1])
                    {
                        a = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = a;
                    }
                }
            }
            return mas;
        }
    }
}
