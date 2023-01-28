//Reverse Array
void PrintReverseArray()
{
	int arraySize;
	bool setArraySizeSuccess = false;
	string[] inputsArray;

	while (!setArraySizeSuccess)
	{
		Console.WriteLine("Please set array size (size must be a number):");
		var getArraySizeFromUser = Console.ReadLine();

		if (!int.TryParse(getArraySizeFromUser, out arraySize))
		{
			Console.WriteLine("Array size must be specified as a number");
			continue;
		}
		Console.WriteLine($"Array size is {arraySize}");
		setArraySizeSuccess = true;
		inputsArray = new string[arraySize];
	}





}
PrintReverseArray();