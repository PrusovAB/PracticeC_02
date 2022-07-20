using System;
class HelloWorld {
  static void Main() {
    Console.Clear();
Console.WriteLine("Введите число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
if (numberThree < 0){
    numberThree = numberThree * (-1);
}
int number = numberThree;

double rez = -1;


if (numberThree < 100){
	Console.WriteLine($"В числе {numberThree} не возможности показать третье число");
}else{
	for(int i = 0; i < numberThree; i++ ){
		if(numberThree < 10000){
			double num = ((numberThree % 100) / 10);
			rez = Math.Round(num,1);
			if(numberThree<1000){
			    num = numberThree % 10;
			    rez = Math.Round(num,1);
			}
		}
		if(numberThree >= 10000){
			numberThree = numberThree / 10;
		}
	}
}

if(rez >= 0){
	Console.WriteLine($"В числе {number} третье число по счету {rez}");
}

  }
}


