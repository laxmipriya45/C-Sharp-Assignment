using System;

namespace SubStringSearch.App
{
	class Assignment
	{
		static void Main()
		{
			Assignment app = new Assignment();
			app.Run();

		}

		public void Run()
		{
			Console.WriteLine("Substring Search Program \n");

			while (true)
			{
				Console.WriteLine("Enter the Main string:");
				string mainString = Console.ReadLine();

				Console.WriteLine("Enter the Sub-String:");
				string subString = Console.ReadLine();

				FindSubString(mainString, subString);

				Console.WriteLine("\nDo you want to search again? (Y/N):");
				string choice = Console.ReadLine().Trim().ToUpper();

				if (choice != "Y")
				{
					Console.WriteLine("Program Exited!");
					break;
				}


			}
		}




		public static void FindSubString(string mainString, string subString)
		{

			//if (string.IsNullOrEmpty(mainString) || string.IsNullOrEmpty(subString) || string.IsNullOrWhiteSpace()
			if (string.IsNullOrWhiteSpace(mainString) || string.IsNullOrWhiteSpace(subString) ||
			   !mainString.All(char.IsLetter) || !subString.All(char.IsLetter))
			{
				Console.WriteLine("Please enter a valid string. The strings might be empty,numeric or alpha numeric");
				return;
			}

			int count = 0;
			string positions = "";
			int mainStringLength = mainString.Length;
			int subStringLength = subString.Length;

			for (int i = 0; i <= mainStringLength - subStringLength; i++)
			{
				// Extract substring from main string for comparison
				string temp = mainString.Substring(i, subStringLength);

				if (temp == subString)   
				{
					count++;
					positions += i + " ";
				}
			}
			//print how many matches and the indices string.
			if (count > 0)
			{
				Console.WriteLine($"Number of times occurred = {count}");
				Console.WriteLine("Index positions = " + positions);
			}
			else
			{
				Console.WriteLine("Substring not found.");
			}
		}
	}
}
