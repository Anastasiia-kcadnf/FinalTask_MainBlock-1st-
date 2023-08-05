
/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[] ProcessArray(string[] array)
{
    string[] temp = new string[array.Length];
    int j = 0;
    for(int i=0; i < array.Length; i++)
        if(array[i].Length <= 3)
            temp[j++] = array[i];
    string[] result = new string[j];
    for(int i = 0; i < j; i++)
        result[i] = temp[i];
    return result;
}

void InputStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива [{i}]: ");
        array[i] = Console.ReadLine();
    }
}

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"array[{i}]: \"{array[i]}\"");
}

Console.Write("Введите длину массива строк: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] myStringArray = new string[arraySize];
InputStringArray(myStringArray);
string[] processedArray = ProcessArray(myStringArray);
Console.WriteLine("Массив с элементами, длина которых меньше либо равна 3: ");
PrintStringArray(processedArray);
