using System;

namespace Homework1
{
    class Triangle
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
	    int a, b, c;
	    Console.WriteLine("Enter nums");
	    a = ReadNum();
	    b = ReadNum();
	    c = ReadNum();

	    if (a == b && a == c) {
		Console.WriteLine("3");
	    } else if (a == b || b == c || a == c){
		Console.WriteLine("2");
	    } else {
		Console.WriteLine("0");
	    }
	}
    }
}

