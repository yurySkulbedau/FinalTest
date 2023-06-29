/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []
*/

string[] linesArray1 = new string[] {"Hello", "2", "world", ":-)"};
// string[] linesArray2 = new string ["1234", "1567", "-2", "computer science"];
// string[] linesArray3 = new string ["Russia", "Denmark", "Kazan"];


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
    count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resArray[count] = arr[i];
            count++;
        }
    }

    return resArray;
}

string[] shortLinesArray = GetShortLines(linesArray1);
Console.WriteLine($"Array: [{string.Join(", ", shortLinesArray)}]");
