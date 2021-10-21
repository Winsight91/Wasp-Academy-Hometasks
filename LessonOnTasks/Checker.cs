using System;

namespace Checker
{
	class Checker
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
			int n = 0, m = 0;
			Console.WriteLine("Enter number");
			n = ReadNum();
			Console.WriteLine("Enter second");
			m = ReadNum();

			Console.WriteLine("Hooray!");
		}
	}
}
