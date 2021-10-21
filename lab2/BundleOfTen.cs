using System;

namespace BundleOfTen
{
    namespace ht4
    {
        class LastNumber
        {
            static int ReadNum()
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
                int n = 0;
                int k = 0;
                Console.WriteLine("Enter a random num!");
                do
                {
                    Console.WriteLine("Num must be under 10000!");
                    n = ReadNum();
                } while (n > 10000);
                n = n / 10;
                k = n % 10;
                Console.WriteLine(k);
            }
        }
    }
}