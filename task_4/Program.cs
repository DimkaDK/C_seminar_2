// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.5, 25  ->  да -4, 16  ->  да 25, 5  ->  да 8,9  ->  нет

Console.Clear();

Console.Write ("Введите первое число: ");

int firstNumber = int.Parse(Console.ReadLine());

Console.Write ("Введите второе число: ");

int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine ($"{firstNumber}  -> является квадратом {secondNumber}");
}

else
{
   Console.WriteLine ($"{firstNumber}  -> не является квадратом {secondNumber}");
}

if (secondNumber == firstNumber * firstNumber)
{
    Console.WriteLine ($"{secondNumber}  -> является квадратом {firstNumber}");
}
else
{
   Console.WriteLine ($"{secondNumber}  -> не является квадратом {firstNumber}");
}

