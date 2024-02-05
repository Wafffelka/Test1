// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

// Console.Write("Введите 1 число: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2 число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// bool CheckNumbers(int m, int n)
// {
//     if (m < n)
//     {
//         return true;
//     }
//     return false;
// }

// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }
// CheckNumbers(M, N);
// if (CheckNumbers(M, N) == false)
// {
//     int temp = M;
//     M = N;
//     N = temp;
// }
// ShowNumbers(M, N);
// Можно было бы ещё проверку на ввод числа сделать, но не стала :)




// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите 1-е положительное число: ");
// int FirstNum= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е положительное число: ");
// int SecondNum = Convert.ToInt32(Console.ReadLine());

// int ExecuteAckermanFunction(int num1, int num2)
// {
//     if (num1 == 0)
//     {
//         return num2 + 1;
//     }
//     if (num2 == 0)
//     {
//         return ExecuteAckermanFunction(num1 - 1, 1);
//     }
//     return ExecuteAckermanFunction(num1 - 1, ExecuteAckermanFunction(num1, num2 - 1));
// }

// Console.Write($"Функция Аккермана равна {ExecuteAckermanFunction(FirstNum, SecondNum)}");




// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.



int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void ReverseArray(int[] arr, int size)
{
    if (size == 0)
    {
        Console.Write($"{arr[0]}");
        return;
    }
    Console.Write($"{arr[size]}, ");
    ReverseArray(arr, (size - 1));
}



Console.Write("Введите размер массива: ");
int InputSize = Convert.ToInt32(Console.ReadLine());
int[] ArrayNew = CreateArray(InputSize);

// Console.WriteLine($"Массив: [ {string.Join("; ", ArrayNew)} ]");
Console.Write("Перевернутый массив: ");
ReverseArray(ArrayNew, (InputSize - 1));