// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
string GetStringFromCharArray (char[] array)
{
    string result = string.Empty; // ""
    foreach (char symbol in array)
// symbol='a',symbol='b',symbol='c',symbol='d'
    {
        result += symbol;
    }
    return result;
}

char[] chars = {'1', 'd', '!', '2', 'f'};
string res = GetStringFromCharArray(chars);
Console.WriteLine($"Result: {res}");


// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] ConvertStringToCharArray(string str)
{
    char[] chars = new char[str.Length];
// "hi" => [h,i]
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}
string testString = "Hello world";
char[] chars = ConvertStringToCharArray(testString);
Console.WriteLine($"Массив: [ {string.Join(" ;", chars)} ]");



// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVovelsCount(string str)
{
    string vovels = "aoueiy";// Строка с гласными
    int countVovels = 0; // Количество гласных
    foreach (char symbol in str) // Берем каждую букву из str
    {
        foreach (char vovel in vovels) // Берем гласные буквы
        {
            if (symbol == vovel) // Мы нашли гласную букву
            {
                countVovels++;
                break;
            }
        }
    }
    return countVovels;
}
Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower(); // HELLO => hello
// ToUpper() -> hello => HELLO
int countVovels = GetVovelsCount(inputString);
Console.WriteLine($"Количество гласных: {countVovels}");


// дз>>
// // Задача 1: Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива. 
char[,] matrix_N = {{"a","b"},{"c","d"}};
string GetStringFromMatrix(char[,] matrix)
{
    string result = string.Empty; // ""
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; matrix.GetLength(1); k++)
        {
            result += matrix[i, k];
        }
        
    }
    return result;
}
string res = GetStringFromMatrix(matrix_N);
Console.WriteLine(res);



// // Задача 2: Задайте строку, содержащую латинские буквы в обоих 
// регистрах. Сформируйте строку, в которой все заглавные буквы 
// заменены на строчные.

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower();
Console.WriteLine(inputString);


// // Задача 3: Задайте произвольную строку. Выясните, является ли 
// она палиндромом.

Console.WriteLine("Ведите слово: ");
string word = Console.ReadLine();

bool palindrome(string str)
{
    int HalfWord = str.Length / 2;
    for (int i = 0; i < HalfWord; i++)
    {
        if (str[i] != str[-i-1])
        {
            return false;
        }
    }
    return true;
} 

if (palindrome(word))
{
    Console.WriteLine("Это слово палиндром");
}
else
{
    Console.WriteLine("Это слово НЕ палиндром");
}