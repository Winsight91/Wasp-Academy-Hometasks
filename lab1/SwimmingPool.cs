using System;

namespace lab1
{
    class SwimmingPool
    {
	static int ReadNum() {
	    int res = 0;
	    bool done = false;
	    while (!done) {
		try {
		    res = int.Parse(Console.ReadLine());
		    done = true;
		} catch {
		    Console.WriteLine("Error, try again");
		}
	    }
	    return res;
	}

        static void Main(string[] args)
        {
	    int n=0, m=0, x=0, y=0;
	    int max, min;
	    Console.WriteLine("Enter size of pool: (N)");
	    n = ReadNum();
	    Console.WriteLine("Enter size of pool: (M)");
	    m = ReadNum();
	    Console.WriteLine("Enter size of pool: (X)");
	    x = ReadNum();
	    Console.WriteLine("Enter size of pool: (Y)");
	    y = ReadNum();

	    if (n >= m) {
		max = n;
		min = m;
	    } else {
		max = m;
		min = n;
	    }

	    int dx, dy;

	    dx = min - x;
	    dy = max - y;

	    int min_dist;

	    if (x < dx) {
		dx = x;
	    }

	    if (y < dy) {
		dy = y;
	    }

	    if (dx < dy) {
		min_dist = dx;
	    } else {
		min_dist = dy;
	    }

	    Console.WriteLine("{0}", min_dist);
	}
    }
}
