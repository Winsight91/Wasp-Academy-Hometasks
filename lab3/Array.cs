using System;
using System.Linq;

namespace LastNumber
{
    namespace ht3
    {
        class Array
        {
            int[] array;
            public Array(int _size)
            {
                array = new int[_size];
            }

            public void FillArray()
            {
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine("Enter {0} element:", i);
                    array[i] = LastNumber.ReadNum();
                }
            }

            public void PrintArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("{0}, ", array[i]);
                }
            }

            public int GetMax()
            {
                return array.Max();
            }
        }

        class ArrayOfArrays
        {
            int[][] array;
            public ArrayOfArrays(int _size)
            {
                array = new int[_size][];
            }

            public void FillArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine("Enter size of row");
                    int row_size = LastNumber.ReadNum();
                    array[i] = new int[row_size];
                    for (int j = 0; j < row_size; j++)
                    {
                        Console.WriteLine("Enter {0} element:", j);
                        array[i][j] = LastNumber.ReadNum();
                    }
                }
            }

            public void PrintArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array[i].GetLength(0); j++)
                    {
                        Console.Write("{0}, ", array[i][j]);
                    }
                    Console.WriteLine("");
                }
            }

            public int GetMax()
            {
                int[] tmp = new int[array.GetLength(0)];
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    tmp[i] = array[i].Max();
                }
                return tmp.Max();
            }
        }
        class Array2D
        {
            int[,] array;
            public Array2D(int _size, int _size2)
            {
                array = new int[_size, _size2];
            }

            public void FillArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine("Enter {0} line:", i);
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine("Enter {0} element:", j);
                        array[i, j] = LastNumber.ReadNum();
                    }
                }
            }

            public void PrintArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0}, ", array[i,j]);
                    }
                    Console.WriteLine("");
                }
            }
            public int GetMax()
            {
                int[] tmp = new int[array.GetLength(0)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int[] tmp2 = new int[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        tmp2[i] = array[i,j];
                    }
                    tmp[i] = tmp2.Max();
                }
                return tmp.Max();
            }
        }


        class LastNumber
        {
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
            static void Main(string[] args)
            {
                int size;
                Array myarray;

                Console.WriteLine("enter size of array");
                size = ReadNum();

                myarray = new Array(size);

                myarray.FillArray();

                myarray.PrintArray();


                //int size2;
                //int size21;
                //Array2D myarray2;

                //Console.WriteLine("enter size of array");
                //size2 = ReadNum();

                //Console.WriteLine("enter size2 of array");
                //size21 = ReadNum();

                //myarray2 = new Array2D(size2, size21);

                //myarray2.FillArray();

                //myarray2.PrintArray();

                //int size3;
                //ArrayOfArrays myarray3;

                //Console.WriteLine("enter size of array");
                //size3 = ReadNum();

                //myarray3 = new ArrayOfArrays(size3);

                //myarray3.FillArray();

                //myarray3.PrintArray();
            }
        }
    }
}