//Reverse Array
using System.Text.RegularExpressions;

void PrintReverseArray()
{
	while (true)
	{
		int arraySize = 0;
		bool setArraySizeSuccess = false;
		string[] inputsArray = new string[0];

		while (!setArraySizeSuccess)
		{
			Console.WriteLine();
			Console.WriteLine("Please set array size (size must be a number):");
			var getArraySizeFromUser = Console.ReadLine();

			if (!int.TryParse(getArraySizeFromUser, out arraySize))
			{

				Console.WriteLine("Array size must be specified as a number");
				continue;
			}
			Console.WriteLine();
			Console.WriteLine($"Array size is {arraySize}");
			setArraySizeSuccess = true;
			inputsArray = new string[arraySize];
		}

		Console.WriteLine();
		Console.WriteLine($"Time to fill the array! Give me {arraySize} values, it can be numbers or strings");

		for (int i = 0; i < arraySize; i++)
		{
			var userInput = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(userInput))
			{
				inputsArray[i] = userInput;
			}
			else
			{
				Console.WriteLine("Hmmm... Input seems to be invalid, pleas give me string or number and remeber to avoid white spaces or nullable values");
				i--;
			}
		}

		Console.WriteLine();
		Console.WriteLine("This is your array, but reversed!");
		Console.WriteLine();

		foreach (var userInput in inputsArray.Reverse())
		{
			Console.Write($"{userInput} ");
		}

		/*for (int i = inputsArray.Length - 1; i >= 0; i--)
		{
			Console.Write($"{inputsArray[i]} ");
		}*/
		Console.WriteLine();
	}
}


void CheckIfStringIsPalindrome()
{
	while (true)
	{
		Console.WriteLine();
		Console.WriteLine("Let's check if the entered word is a palindrome! Please type some word...");
		var userWord = Console.ReadLine();
		string cleanedUserWord = "";
		string reversedCleanedUserWord = "";
		var inputIsEmpty = true;

		while (inputIsEmpty)
		{

			Console.WriteLine();

			if (!string.IsNullOrWhiteSpace(userWord))
			{
				cleanedUserWord = Regex.Replace(userWord, "[^a-zA-Z]", "").ToLower();
				reversedCleanedUserWord = new string(cleanedUserWord.Reverse().ToArray());
				inputIsEmpty = false;
			}
			else
			{
				Console.WriteLine("Input can't be empty, please enter a word");
				userWord = Console.ReadLine();
				continue;
			}
		}

		if (cleanedUserWord != reversedCleanedUserWord)
		{
			Console.WriteLine("NO");
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("YES");
			Console.WriteLine();
		}
	}

}




PrintReverseArray();
//CheckIfStringIsPalindrome();