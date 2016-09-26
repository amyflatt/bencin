using System;

namespace ChattyCathy.cs
	//Chatty Cathy was a pull string doll.  I created this program in honor of my friend Chatty Cathy.
{
	class ChattyClass
	{

		public static void Main (string[] args)
		{
			Console.WriteLine ("Press P and then enter to pull the doll's string");
			string UsersChoice = Console.ReadLine ();
			Random RanGen = new Random ();

			do {
				if (UsersChoice != "P")
					break;
				int responseIndex = RanGen.Next (1, 19);
				switch (responseIndex) {
				//These Lines said by the 1960s doll were taken from the public domain.
				case 1:
					Console.WriteLine ("I love you");
					break;

				case 2:
					Console.WriteLine ("Give me a kiss.");
					break;

				case 3:
					Console.WriteLine ("Do you love me?");
					break;

				case 4:
					Console.WriteLine ("Let's have a party");
					break;

				case 5:
					Console.WriteLine ("Will you play with me?");
					break;

				case 6:
					Console.WriteLine ("Please change my dress");
					break;

				case 7:
					Console.WriteLine ("Please brush my hair");
					break;

				case 8:
					Console.WriteLine ("Where are we going?");
					break;

				case 9:
					Console.WriteLine ("Please take me with you");
					break;

				case 10:
					Console.WriteLine ("I'm hungry");
					break;

				case 11:
					Console.WriteLine ("May I have a cookie?");
					break;

				case 12:
					Console.WriteLine ("Please carry me");
					break;

				case 13:
					Console.WriteLine ("Let's play house");
					break;

				case 14:
					Console.WriteLine ("I hurt myself!");
					break;

				case 15:
					Console.WriteLine ("What can we do now?");
					break;

				case 16:
					Console.WriteLine ("Let's play school");
					break;


				case 17:
					Console.WriteLine ("I'm so tired");
					break;

				default:
					Console.WriteLine ("Tell me a story");
					break;

				
				}

			} while(Console.ReadLine() == "P");
		}
	}
}
