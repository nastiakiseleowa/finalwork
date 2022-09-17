// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

void PrintArray(string[] array)
{

    for (int m = 0; m < array.Length; m++)
    {
        Console.Write($"{array[m]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[] { "hello", "lesson", "x", "y", "oo" };
string[] array2 = new string[array1.Length];
int index = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[index] = array1[i];
        index++;
    }
}

PrintArray(array2);