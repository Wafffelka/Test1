// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
 // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100; // 275 / 100 = 2
    int thirdDigit = number % 10; // 275 % 10 = 5
    int result = firstDigit * 10 + thirdDigit;// 2 * 10+ 5 = 25
    //$"Текст {firstDigit} текст {firstDigit * 10 + thirdDigit}"
    Console.WriteLine($"Результат: {number} => {result}");
}
else
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
if (number >= 100 && number <= 999)
{
   int secondDigit = number / 10 % 10;
//     // 275 / 10 % 10 = 27 % 10 = 7
    int thirdDigit = number % 10; // 275 % 10 = 5
//     // Возвести число 7 в 5 степень
//     // Math.Pow(2, 3) => 2 в 3 степени: 2 * 2 * 2 = 8
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"{number} : {secondDigit} ^ {thirdDigit} = {result}");
}
else
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}

double a = Math.Round(2.1234, 2);
System.Console.WriteLine(a);

// Получить 3 цифру с начала (слева) введенного числа
// 12345678 -> 3
// 78671 -> 6
// 12 - 3 цифры нет
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;

if (number < 100)
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}

else // В числе >= 3 знака
{   
    while (number > 999) // В числе 4 знака
    {
        number /= 10; // number = number / 10
        // a = a + 500 (a += 500)
        // a = a * 30 (a *= 30)
    }
    Console.WriteLine($"Третья цифра от числа {copyNumber} = {number % 10}");
}

// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;

if (number < 100)
{
    Console.WriteLine("Число не трехзначное ИЛИ отрц.");
}

else // В числе >= 3 знака
{   
    Console.WriteLine($"Третья цифра от {copyNumber} (справа) =  {number / 100 % 10}");
}
int a = 100;
int b = 30;
if (a % b == 0) // Число а делится БЕЗ остатка
{
    Console.WriteLine("Число а делится БЕЗ остатка");
}
else // Число делится с остатком 
{
    Console.WriteLine($"{a} / {b} = {a % b}");
}