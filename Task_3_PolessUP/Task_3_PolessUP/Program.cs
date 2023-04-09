using System;

namespace Task_3_PolessUP
{
    class Program
    {
        static int IndFindEl(int[] vs,int goal)
        {
            int ind = -1;
            for (int i = 0; i < vs.Length-1; i++)
            {
                if (vs[i] == goal)
                {
                    ind = i;
                }
                if ( goal<vs[i+1] && goal > vs[i])
                {
                    ind = i+1;
                }
            }
            
            return ind;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1,2,3,4,6,7};
            Console.WriteLine(IndFindEl(a, 5));
        }
    }
}
