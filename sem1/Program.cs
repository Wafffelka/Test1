// - Комментарий 

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имяПеременной = значение;
// camelCase: firstNumber, secondNumber, thirdNumber
// Convert.ToInt32("123") => 123(int)
Console.ReadLine() -  получение информации из консоли
Console.Write("Введите 1 число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка на равенство: 5 == 5 (true), 4 == 5 (false)
if (firstNumber == secondNumber * secondNumber)
// // firstNumber = 25, secondNumber = 5 // Является ли первое число квадратом второго?
{
    // "Привет" + "мир" = "Приветмир" (конкатенация)
    Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
}
else // Первое число не является квадратом от второго 
{
     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
}

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

 Console.Write("Введите число: ");
 int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
     N *= -1; // N = N * -1
       a = a * 500; a *= 500
}

// int negativeN = -N; // negativeN = -N

while (negativeN <= N)
{
    Console.Write(negativeN + "\t");
    // "\t" = 4 пробела или Таб между элементами
    negativeN++;
    // "negativeN++": negativeN = negativeN + 1 (инкремент)
    // "negativeN--": negativeN = negativeN - 1 (декремент)
}

// Получить 3 цифру с левого края
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100) 
{
    while (number > 999)
    {
        number /= 10;
    }
    // 123 => 3
    Console.WriteLine(number % 10);
}
else
{
   Console.WriteLine("Вы ввели некорректное значение");
}

// int a = 3;   // Введенные числа равны `3`
Console.WriteLine("Введенные числа равны " + "`" + a + "`");