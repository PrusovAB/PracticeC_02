Console.Clear();
Console.WriteLine("Введите  число от 1 до 7 и получите день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

string dayWeek = "никакой";
string DayWeek(int number)
{
	if(number <= 0 || number >7){
		Console.WriteLine("Error: Введите  число от 1 до 7 и получите день недели: ");
	}
	if (number == 1){
		dayWeek = "Понедельник";
	}
	if (number == 2){
		dayWeek = "Вторник";
	}
	if (number == 3){
		dayWeek = "Среда";
	}
	if (number == 4){
		dayWeek = "Четверг";
	}
	if (number == 5){
		dayWeek = "Пятница";
	}
	if (number == 6){
		dayWeek = "Суббота";
	}
	if (number == 7){
		dayWeek = "Воскрсенье";
	}
	return dayWeek;
}


Console.WriteLine($"{numberDay} соответствует день недели {DayWeek(numberDay)}");

