Console.Clear();
int randomDigit = new Random().Next(10 ,100);
Console.WriteLine($"случайное число: {randomDigit} ");

int ostatok = randomDigit %10;
Console.WriteLine($"последняя цифра: {ostatok} ");

int firstDigit = randomDigit/10;
Console.WriteLine($"первая цифра: {firstDigit} ");

int max = firstDigit;

if (ostatok > firstDigit) max = ostatok;
Console.WriteLine($"максимум: {max} ");
