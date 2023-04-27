// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());
string[] arr = CreateArray(size);
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
string[] arr2 = EditArray(arr);
Console.WriteLine("Полученный массив: ");
PrintArray(arr2);


string[] CreateArray(int s)
{
    string[] arr1 = new string[s];

    for (int i = 0; i < s; i++)
    {
        Console.Write("Введите элемент массива: ");
        string result = Console.ReadLine();
        arr1[i] = result;
    }
    return arr1;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] EditArray(string[] array)
{
    int count = 0;
    string[] array2 = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}