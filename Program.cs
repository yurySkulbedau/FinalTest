/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []
*/

string[] GetShortLines(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resArray = new string[count];
    int index = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            resArray[index] = arr[j];
            index++;
        }
    }

    return resArray;
}


string[] linesArray1 = { "Hello", "2", "world", ":-)" };
string[] linesArray2 = { "1234", "1567", "-2", "computer science" };
string[] linesArray3 = { "Russia", "Denmark", "Kazan" };

string[] shortLinesArray = GetShortLines(linesArray1);
Console.WriteLine($"[{string.Join(", ", linesArray1)}] -> [{string.Join(", ", shortLinesArray)}]");

shortLinesArray = GetShortLines(linesArray2);
Console.WriteLine($"[{string.Join(", ", linesArray2)}] -> [{string.Join(", ", shortLinesArray)}]");

shortLinesArray = GetShortLines(linesArray3);
Console.WriteLine($"[{string.Join(", ", linesArray3)}] -> [{string.Join(", ", shortLinesArray)}]");
