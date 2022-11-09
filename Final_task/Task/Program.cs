/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами */

void GetNewArrayWithElementsUpFour(string[] mainArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < mainArray.Length; i++)
    {
    if(mainArray[i].Length <= 3)
        {
        newArray[count] = mainArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] mainArray = new string[9] {"hello", "2", "world", ":-)", "1234", "sun", "-2", "computer science", "Denmark"};
string[] newArray = new string[mainArray.Length];

GetNewArrayWithElementsUpFour(mainArray, newArray);
Console.Write($"Итоговый массив с длиною строк меньше или равной трем символам: ");
PrintArray(newArray);
Console.WriteLine();
