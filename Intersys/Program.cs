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


void IsPermutation()
{
	while (true)
	{
		int[] firstArray = new int[11];
		int[] secondArray = new int[11];
		var firstArrayIsCorrectlyFilled = false;
		var secondArrayIsCorrectlyFilled = false;
		var isPermutation = true;

		HashSet<int> firstHashSet = new HashSet<int>(firstArray);
		HashSet<int> secondHashSet = new HashSet<int>(secondArray);

		Console.WriteLine("Let's fill first array with numbers.");
		while (!firstArrayIsCorrectlyFilled)
		{
			for (int i = 0; i < 11; i++)
			{
				var userInputFirstArr = Console.ReadLine();
				var correctUserInputFirstArr = 0;

				if (int.TryParse(userInputFirstArr, out correctUserInputFirstArr))
				{
					firstArray[i] = correctUserInputFirstArr;
				}
				else
				{
					Console.WriteLine("Hmmm... Input seems to be invalid, pleas give me number");
					i--;
				}
			}
			firstArrayIsCorrectlyFilled = true;
		}

		Console.WriteLine("Now it's time to fill second array");
		while (!secondArrayIsCorrectlyFilled)
		{
			for (int i = 0; i < 11; i++)
			{
				var userInputSecondArr = Console.ReadLine();
				var correctUserInputSecondArr = 0;

				if (int.TryParse(userInputSecondArr, out correctUserInputSecondArr))
				{
					secondArray[i] = correctUserInputSecondArr;
				}
				else
				{
					Console.WriteLine("Hmmm... Input seems to be invalid, pleas give me number");
					i--;
				}
			}
			secondArrayIsCorrectlyFilled = true;
		}

		//nested loop option
		/*for (int i = 0; i < firstArray.Length; i++)
		{
			var found = false;
			for (int j = 0; j < secondArray.Length; j++)
			{
				if (firstArray[i] == secondArray[j])
				{
					found = true;
					break;
				}
			}
			if (!found)
			{
				isPermutation = false;
				break;
			}

		}

		if (isPermutation)
		{
			Console.WriteLine("YES");
		}
		else Console.WriteLine("NO");*/


		//HashMap option
		if (firstHashSet.SetEquals(secondHashSet))
		{
			Console.WriteLine("YES");
		}
		else Console.WriteLine("NO");
	}
}


void ShowAppearingPowersOfTwo()
{
	while (true)
	{
		Console.WriteLine();
		List<uint> numbersFromInputList = new List<uint>();
		List<uint> powersOfTwoList = new List<uint>();

		Console.WriteLine("Give me some unsigned integers, separated by ,");
		var userInput = Console.ReadLine();
		var regex = new Regex(@"^\d+(,\d+)*$");
		var userInputIsCorrect = false;

		while (!userInputIsCorrect)
		{
			if (!regex.IsMatch(userInput))
			{
				Console.WriteLine("Your input isn't correct, Give me some unsigned integers, separated by, please avoid white spaces and special characters");
				userInput = Console.ReadLine();
			}
			else userInputIsCorrect = true;
		}

		var userInputAsNumbers = userInput.Split(',');

		foreach (var item in userInputAsNumbers)
		{
			if (uint.TryParse(item, out uint parsedItem))
			{
				numbersFromInputList.Add(parsedItem);
			}
		}

		foreach (var item in numbersFromInputList)
		{
			if ((item & (item - 1)) == 0)
			{
				if (powersOfTwoList.Contains(item) || item == 0)
				{
					continue;
				}
				else powersOfTwoList.Add(item);
			}
			else continue;
		}

		if (!powersOfTwoList.Any())
		{
			Console.Write("NA");
		}
		else
		{
			powersOfTwoList.Sort();
			foreach (var item in powersOfTwoList)
			{
				Console.Write($"{item}, ");
			}
		};
		Console.WriteLine();
	}
}

void FindPrimes()
{
	while (true)
	{
		Console.WriteLine("how many cases do you want to consider?");
		var userInput = Console.ReadLine();
		var numberOfCases = 0;
		var numberOfCasesIsSet = false;
		var m = "";
		var mAsNumber = 0;
		var n = "";
		var nAsNumber = 0;	
		while (!numberOfCasesIsSet)
		{
			if (int.TryParse(userInput, out numberOfCases))
			{
				numberOfCasesIsSet = true;
			}
			else
			{
				Console.WriteLine("Input must be a number, please enter correct value");
				userInput = Console.ReadLine();
			}
		}
		for (int i = 0; i < numberOfCases; i++)
		{
			var mIsSet = false;
			var nIsSet = false;

			Console.WriteLine("Please give me m value:");
			m = Console.ReadLine();

			while (!mIsSet)
			{
				if (int.TryParse(m, out mAsNumber))
				{
					mIsSet = true;
				}
				else
				{
					Console.WriteLine("Input must be a number, please enter correct m value");
					m = Console.ReadLine();
				}
			}

			Console.WriteLine("Please give me n value:");
			n = Console.ReadLine();
			while (!nIsSet)
			{
				if (int.TryParse(n, out nAsNumber))
				{
					nIsSet = true;
				}
				else
				{
					Console.WriteLine("Input must be a number, please enter correct n value");
					n = Console.ReadLine();
				}
			}

			for (int j = mAsNumber + 1; j < nAsNumber; j++)
			{
				Console.WriteLine(j);
			}
		}

	}
}


//PrintReverseArray();
//CheckIfStringIsPalindrome();
//IsPermutation();
//ShowAppearingPowersOfTwo();
FindPrimes();

