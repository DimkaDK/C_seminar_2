Console.Clear();

int randomDigit = new Random().Next(100 ,999);

Console.WriteLine($"случайное трехзначное число: {randomDigit} ");

int ostatok = randomDigit %10;

int firstDigit = randomDigit/100;

string end = ostatok.ToString();

string firs = firstDigit.ToString();

string digit = firs + end;

Console.WriteLine($"Трехзначное число без второй цифры: {digit} ");