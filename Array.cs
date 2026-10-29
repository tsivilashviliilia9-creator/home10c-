using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace home10c_
{
    internal class Array : IOutput2, ICalc2
    {
        int[] rame1 = [1, 2, 3, 4, 5];
        public void ShowEven()
        {
            foreach (int item in rame1)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"luwi {item}");
                }
            }
        }
        public void ShowOdd()
        {
            foreach (int item in rame1)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine($"kenti {item}");
                }
            }
        }



        //2

        public int CountDistinct()
        {

            int countdistinct = 0;
            foreach (var item in rame1)  
            {
                int count = 0;

                foreach (var item1 in rame1)
                {
                    if (item == item1)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    countdistinct++;
                }
            }

            return countdistinct;

        }

        public int EqualToValue(int x)
        {
            foreach (var item in rame1)
            {
                if (x == item)
                {
                    return item;
                }
            }
            return default;
        }




    }

}
