Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

double SecondNumber(int number)
{
	double resultSecond = -1;
	if (number < 100 || number > 999)
	{
		Console.WriteLine("Error: Введите трехзначное число");
	}
	else{
		double result = number / 10;
		resultSecond = Math.Round(result,1)%10;
	}
	return resultSecond;
}

Console.WriteLine(SecondNumber(numberOne));
