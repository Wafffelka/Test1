// Задача 1: Напишите программу, которая бесконечно запрашивает 
//целые числа с консоли. Программа завершается при вводе символа 
//‘q’ или при вводе числа, сумма цифр которого чётная.
int SumOfTheNumberInside(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

void InputOfNumbers()
{
    while (true)
    {
        Console.Write("Введите число или 'q' для выхода: ");
        string StrNumber = Console.ReadLine();
        int IntNumber = Convert.ToInt32(StrNumber);
        if (StrNumber == "q" && SumOfTheNumberInside(IntNumber) % 2 == 0)
        {
           break;
        }
    }
}

InputOfNumbers();

// Задача 2: Задайте массив заполненный случайными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных 
//чисел в массиве.

// не успеваю

// Задача 3: Напишите программу, которая перевернёт одномерный
// массив (первый элемент станет последним, второй – предпоследним 
// и т.д.)

Console.Write("Введите размер массива: ");
int size =  Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введиете {i + 1} значение массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] ArrayReversal(int[] TemporaryArray)
{
    int half = TemporaryArray.Length / 2;
    for(int i = 0; i <= half; i++)
    {
        int support = TemporaryArray[i];
        TemporaryArray[i] = TemporaryArray[-1 - i];
        TemporaryArray[-1 - i] = support;
    }
    return TemporaryArray;
}

Console.Write("\nПеревернутый массив: ");
foreach (int number in ArrayReversal(array))
{
    Console.Write(number + " ");
}