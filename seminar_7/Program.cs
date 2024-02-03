// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

// Console.WriteLine(FindFactorial(4)); // 4 * 3 * 2 * Find(1)

int SumOfDigits (int number)
{
// 63 = 3(63 % 10) + 6(6 % 10) + 0
    if (number == 0) return 0; // 6 + 3 + 0 = 9
    int result = number % 10 + SumOfDigits(number / 10);
    return result;
// number = 35
// result = 5 + 3 + SumOfDigits(0) = 5 + 3 + 0
// SumOfDigits(3) = 3 + SumOfDigits(0)
}
Console.WriteLine(SumOfDigits(45));


// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Использовать рекурсию. Не использовать цикл.
// Пример
// N = 5 => 1 2 3 4 5
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;
// start = 1, end = 5
void ShowNumbers(int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return; // Ломает всю программу, если попали в этот фрагмент
    }
    Console.Write(start + " "); // 1 2 3 4 5
    ShowNumbers(start + 1, end);
}
ShowNumbers(1, N); // start = 1, end = N


// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d
void ShowConsonant (string str)
{
// Базовый случай
    if (str.Length == 0)
    {
        return;
    }
    string vowels = "aoueyi"; // Гласные буквы
// CAT -> c
    if (char.IsLetter(str[0]) && !vowels.Contains(char.ToLower(str[0])))
    {
        Console.Write(str[0] + " ");
    }
// Рекурсивный случай
// CAT -> AT -> T
    ShowConsonant(str.Substring(1));
}
ShowConsonant("4!3CAT");