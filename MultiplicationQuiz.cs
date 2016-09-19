using System;

class QuizClass
{
	public static void Main(string[]arg)
	{
	Start:
		Random RandGen = new Random ();

		int No1 = RandGen.Next (1, 10);
		int No2 = RandGen.Next (1, 10);


		Console.WriteLine ("What is the answer to: " + No1 + " times " + No2 + "?");
		int answer = Convert.ToInt32 (Console.ReadLine ());

		if (answer == No1 * No2) 
		{
			int responseIndex = RandGen.Next (1, 5);
			switch (responseIndex)
			{
			case 1:
				Console.WriteLine ("That's Right!");
				break;
			
			case 2:
				Console.WriteLine ("Good Job!");
				break;
			case 3:
				Console.WriteLine ("I am so proud of you!");
				break;
			default:
				Console.WriteLine ("You're crushing it!");
				break;
			}
		} 
		else
		{
			int responseIndex = RandGen.Next (1, 4);
			switch (responseIndex) {
			case 1:
				Console.WriteLine ("Oops");
				break;
			case 2:
				Console.WriteLine ("Ewww No");
				break;
			default:
				Console.WriteLine ("Maybe I should make you some coffee?");
				break;
			}
		}
		Console.ReadKey ();
		goto Start;
	}
}
