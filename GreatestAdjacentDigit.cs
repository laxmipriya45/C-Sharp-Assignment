
using System;
using System.Text.RegularExpressions;

namespace AdjacentDigitProductFinder
{
	public class Assignment
	{
		public static void Main()
		{
			RunApplication();
		}

		private static void RunApplication()
		{
			bool continueProgram = true;

			while (continueProgram)
			{
				string input = GetInput("Enter a number: ");

				if (!IsValidNumber(input))
				{
					Console.WriteLine("Invalid input! Please enter digits only.");
					continueProgram = AskToContinue();
					continue;
				}

				long number = long.Parse(input);

				if (number <= 999)
				{
					Console.WriteLine("Invalid Entry! Number must have at least 4 digits.");
				}
				else
				{
					Console.WriteLine($"Greatest 4-digit adjacent product = {FindGreatestProduct(number)}");
				}

				continueProgram = AskToContinue();
			}
		}

		private static string GetInput(string prompt)
		{
			Console.Write(prompt);
			return Console.ReadLine();
		}

		private static bool IsValidNumber(string input)
		{
			return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^\d+$");
		}

		private static int FindGreatestProduct(long number)
		{
			string digits = number.ToString();
			int maxProduct = 0;

			for (int i = 0; i <= digits.Length - 4; i++)
			{
				int product = 1;                 // hold the multiply result of the 4 digits
				bool hasZero = false;

				for (int j = i; j < i + 4; j++)
				{
					if (digits[j] == '0')
					{
						hasZero = true;
						break;
					}
					product *= (digits[j] - '0');
				}

				if (!hasZero)
					maxProduct = Math.Max(maxProduct, product);
			}

			return maxProduct;
		}

		private static bool AskToContinue()
		{
			Console.Write("Do you want to continue? (y/n): ");
			return Console.ReadLine().Trim().ToLower() == "y";
		}
	}
}

