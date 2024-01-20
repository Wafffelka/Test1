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



// Задача 3: Напишите программу, которая перевернёт одномерный
//массив (первый элемент станет последним, второй – предпоследним 
//и т.д.)