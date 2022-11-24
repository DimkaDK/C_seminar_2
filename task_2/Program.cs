Console.Clear();

Console.Write ("Введите первое число: ");

int firstNumber = int.Parse(Console.ReadLine());

Console.Write ("Введите второе число: ");

int secondNumber = int.Parse(Console.ReadLine());

if (secondNumber % firstNumber == 0)
{
    Console.WriteLine ($"{secondNumber}  {firstNumber}  -> Кратно");
}
else
{
    int ostatok = secondNumber % firstNumber;
    Console.WriteLine ($"{secondNumber}  {firstNumber}   -> не кратно, остаток {ostatok}");
}