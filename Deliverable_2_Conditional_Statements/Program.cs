// See https://aka.ms/new-console-template for more information
Console.WriteLine("What grade do you expect to get in ISM4300?");

try
{

	string[] letter_grade = new string[] {"A", "B", "C", "D", "F" };
	string input = Console.ReadLine();
	uint result;
	decimal grade = decimal.Parse(input);

	if (uint.TryParse(input, out result)) 
	{
		if (grade >= 90 && grade <= 100)
		{
			Console.WriteLine("You will get a " + letter_grade[0]);
		}

		else if (grade >= 80 && grade <= 89)
		{
			Console.WriteLine("You will get a " + letter_grade[1]);
		}

		else if (grade >= 70 && grade <= 79)
		{
			Console.WriteLine("You will get a " + letter_grade[2]);
		}

		else if (grade >= 60 && grade <= 69)
		{
			Console.WriteLine("You will get a " + letter_grade[3]);
		}

		else if (grade >= 0 && grade <= 59)
		{
			Console.WriteLine("You will get a " + letter_grade[4]);
		}
	}

	else
	{
		Console.WriteLine("Please enter a valid number grade!");
		Console.ReadLine(); //message shows up for negative int and decimal values. Does not show up for letters. 
	}

} //end of try

catch
{
	Console.WriteLine("Please enter a valid number grade!"); //these statements show up if user inputs a letter value
	Console.WriteLine("---------------------");
	Console.WriteLine("Press any key to exit program...");
	Console.ReadKey(true);
}


