using System;

class FortuneTeller
{
	public static void Main(string[]args)
	{
	Start:
		Random randGen = new Random();


		Console.WriteLine("I will tell you your fortune for today...");
		Console.WriteLine ("Let me consult the magic 8Ball");


		int responseIndex = randGen.Next(1,4);
		switch (responseIndex)
		{
		case 1:
			Console.WriteLine("Silly thing, computers can't tell fortunes");
			break;

		case 2:
			Console.WriteLine("8Ball and I think your mom is going to fix soup");
			break;

		default:
			Console.WriteLine ("Answer hazy, I must be getting interference from the wizard next door again.  I wish she did not live so close.");
			break;
		

		}
		Console.ReadKey ();
		goto Start;
	}
}
