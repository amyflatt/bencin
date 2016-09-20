using System;

class MainClass
{
	public static int locsub(int a,int b)
	{
		return a * b;
	}
	public static void Main()
	{
		int ret;
		Console.WriteLine ("I will run my subroutine for 3 and 5");
		ret = locsub (3, 5);
		Console.WriteLine ("Value is {0}", ret);
	}
}
