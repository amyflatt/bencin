using System;

class Mainclass
{
	public static void Main(string[]args)
	{
		start:
		int No1;
		int No2;
		char y;
		char n;

		Console.WriteLine ("Input number: ");
		No1 = Convert.ToInt32 (Console.ReadLine ());
		Console.WriteLine ("Input second number: ");
		No2 = Convert.ToInt32 (Console.ReadLine ());

		Console.WriteLine("Multiply "+ No1 + " and " + No2 +" ? Answer " + No1*No2);

		Console.WriteLine("Is my Answer correct, choose Y or N: ");

		if (OverWrite.ToUpper().Equals ("Y")(Console.ReadLine()))	 
		{

			Console.WriteLine ("Yay, I got it right!");
		}
		else if (Answer.ToUpper().Equals("N"))
			
		{
			//(Console.ReadLine());
			Console.WriteLine("No? What exactly do you mean by no?");
		}
		else
		{
			Console.WriteLine("I didn't understand what you said.");
		}
		Console.ReadKey();
		}
	}
}
