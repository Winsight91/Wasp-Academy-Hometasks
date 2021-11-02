using System;
using System.Linq;

namespace ht5
{
    namespace SingleElement
    {
        class se
        {
            int[] array;
            public se(int _size)
            {
                array = new int[_size];
            }

            public void FillArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine("Enter {0} element:", i);
                    array[i] = ReadNum();
                }
            }

            public void PrintUnique()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int target = array[i];
                    int count = 0;
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[j] == target)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(target);
                    }
                }
            }

            public static int ReadNum()
            {
                int res = 0;
                bool done = false;
                while (!done)
                {
                    try
                    {
                        res = int.Parse(Console.ReadLine());
                        done = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error, try again");
                    }
                }
                return res;
            }
        }
        class Homework5 { 
            static void Main(string[] args)
            {
                int size;

                Console.WriteLine("enter size of array");
                size = se.ReadNum();

                se myarray = new se(size);

                myarray.FillArray();

                myarray.PrintUnique();

            }
        }
    }
}
