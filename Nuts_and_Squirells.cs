using System;

namespace Nuts_and_Squirells
{
	namespace ht2
	{
		class Nuts_and_Squirells
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
				int y = 0;

				Console.WriteLine("Enter a num of nuts!");
				do
				{
					n = ReadNum();
				} while (n < 0 || n > 10000);

				Console.WriteLine("Enter a num of squirells!");
				do
				{
					k = ReadNum();
				} while (k < 0 || k > 10000);

				y = n / k;
				Console.WriteLine(y);
			}
		}
	}
}