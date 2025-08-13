using System;
using System.Text.RegularExpressions;

namespace FloatBinaryAddition
{
	internal class Assignment
	{
		private static float valueOne, valueTwo;

		public static void Main()
		{
			RunApplication();
		}

		private static void RunApplication()
		{
			bool continueProgram = true;

			while (continueProgram)
			{
				if (!GetUserInputs())
				{
					Console.WriteLine("Invalid input! Please enter valid float values.");
					continueProgram = AskToContinue();
					continue;
				}

				DisplayBinaryAndSum();

				continueProgram = AskToContinue();
			}
		}

		private static bool GetUserInputs()
		{
			Console.WriteLine("Conversion of Two Float Values to Binary, Adding Them, and Converting the Result Back to Float");

			Console.Write("Enter the first input value: ");
			if (!float.TryParse(Console.ReadLine(), out valueOne))
				return false;

			Console.Write("Enter the second input value: ");
			if (!float.TryParse(Console.ReadLine(), out valueTwo))
				return false;

			return true;
		}

		private static void DisplayBinaryAndSum()
		{
			int binOne = BitConverter.SingleToInt32Bits(valueOne);
			int binTwo = BitConverter.SingleToInt32Bits(valueTwo);

			Console.WriteLine($"Binary of {valueOne} = {Convert.ToString(binOne, 2)}");
			Console.WriteLine($"Binary of {valueTwo} = {Convert.ToString(binTwo, 2)}");

			float sum = valueOne + valueTwo;
			Console.WriteLine($"Sum of {valueOne} and {valueTwo} = {sum}");
		}

		private static bool AskToContinue()
		{
			Console.Write("Do you want to continue? (y/n): ");
			return Console.ReadLine()?.Trim().ToLower() == "y";
		}
	}
}





