using System;

namespace Homework2
{
    class MainClass
    {
        public static bool ReadNum(ref int a)
        {
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static int getPosition(string prompt)
        {
            bool readDone = false;
            int s = 0;
            Console.WriteLine(prompt);
            while (!readDone)
            {
                readDone = ReadNum(ref s);
                if (s < 1 || s > 8)
                {
                    readDone = false;
                }
                if (!readDone)
                {
                    Console.WriteLine("Try again, number must be between 1 and 8");
                }
            }
            return s;
        }

        public static void Main(string[] args)
        {

            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            s1 = getPosition("Enter rook's position!");
            s2 = getPosition("Awesome choise! Enter the second num");
            s3 = getPosition("Nice work! Enter the third num");
            s4 = getPosition("Not bad! Enter the fourth num");

            if (s1 == s3 || s2 == s4)
            {
                Console.WriteLine("YEA!");
            }
            else
            {
                Console.WriteLine("NOPE!");
            }
        }
    }
}