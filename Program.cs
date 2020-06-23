using System;

namespace _3_1
{
    class Program
    {
        class Array
        {
            private int[,] a;

            public Array()
            {
                a = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            }
            public void search(int x)
            {
                int i, j;

                for (i = 3, j = 0; i >= 0 && j < 4;)
                {
                    if (x == a[i, j])
                    {
                        Console.WriteLine("ok");
                        return;
                    }
                    else if (x < a[i, j])
                    {
                        i--;
                        continue;
                    }
                    else if (x > a[i, j])
                    {
                        j++;
                        continue;
                    }
                }
            }
        }
            

        static void Main(string[] args)
        {
            Array a = new Array();
            a.search(90);
        }
    }
}
